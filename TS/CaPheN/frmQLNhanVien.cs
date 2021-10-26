using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaPheN.Model;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
namespace CaPheN
{
    public partial class frmQLNhanVien : Form
    {
        DbCaPheConTent dbContent = new DbCaPheConTent();
        public frmQLNhanVien()
        {
            InitializeComponent();
        }
        //Tô màu dòng vừa thao tác
        public void focusSP()
        {
            dgvQLNV.ClearSelection();
            int row = dgvQLNV.Rows.Count - 2;
            dgvQLNV.Rows[row].Selected = true;
            dgvQLNV.Rows[row].Cells[0].Selected = true;
        }
        private void LoadDGV()
        {
            List<NHANVIEN> newListNV = dbContent.NHANVIENs.ToList();
            FILLDataDGV(newListNV);
        }
        private void LoadForm()
        {
            txtTen.Clear();
            txtSDT.Clear();
            txtDC.Clear();
            txtMa.Clear();
            txtMa.Focus();
        }
        private void FILLDataDGV(List<NHANVIEN> newListNV)
        {
            dgvQLNV.Rows.Clear();
            foreach (var item in newListNV)
            {
                int RowNew = dgvQLNV.Rows.Add();
                dgvQLNV.Rows[RowNew].Cells[0].Value = item.idNV;
                dgvQLNV.Rows[RowNew].Cells[1].Value = item.Ten;
                dgvQLNV.Rows[RowNew].Cells[2].Value = item.diachi;
                dgvQLNV.Rows[RowNew].Cells[3].Value = item.sdt;
                


            }
        }

        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            List<NHANVIEN> listNV = dbContent.NHANVIENs.ToList();          
            FILLDataDGV(listNV);
           
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu f1 = new frmMenu();
            f1.ShowDialog();
        }

        private void dgvQLNV_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvQLNV.Rows[e.RowIndex].Height = 42;
        }

        private void dgvQLNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvQLNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvQLNV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvQLNV.CurrentCell.Selected = true;
                    txtMa.Text = dgvQLNV.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();                  
                    txtTen.Text = dgvQLNV.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtDC.Text = dgvQLNV.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    txtSDT.Text = dgvQLNV.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                if (checkIDNV(txtMa.Text) == -1)
                {
                    NHANVIEN newNV = new NHANVIEN();

                    newNV.idNV = txtMa.Text;
                    newNV.Ten = txtTen.Text;
                    newNV.diachi = txtDC.Text;
                    newNV.sdt = Convert.ToInt32(txtSDT.Text);


                    dbContent.NHANVIENs.AddOrUpdate(newNV);
                    dbContent.SaveChanges();
                    MessageBox.Show($"Thêm Nhân Vên '{newNV.Ten}' Thành Công!", "Thông Báo", MessageBoxButtons.OK);

                    LoadDGV();
                    LoadForm();
                    focusSP();
                }
                else
                {
                    MessageBox.Show($"Mã Nhân Viên'{txtMa.Text}' đã tồn tại", "Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        private bool CheckDataInput()
        {
            if (txtMa.Text == "" || txtTen.Text == "" || txtSDT.Text == "" || txtDC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
           

            return true;
        }
        //check co trùng mã số hay k
        private int checkIDNV(string IDNVien)
        {
            int length = dgvQLNV.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dgvQLNV.Rows[i].Cells[0].Value != null)
                    if (dgvQLNV.Rows[i].Cells[0].Value.ToString() == IDNVien)
                        return i;
            }
            return -1;
        }
        private void btnCnNV_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                

                NHANVIEN dbUpdate = dbContent.NHANVIENs.FirstOrDefault(p => p.idNV == txtMa.Text);

                if (dbUpdate != null)
                {
                    dbUpdate.Ten = txtTen.Text;
                    dbUpdate.diachi = txtDC.Text;

                    dbUpdate.sdt = Convert.ToInt32(txtSDT.Text);                    
                    dbContent.NHANVIENs.AddOrUpdate(dbUpdate);
                    dbContent.SaveChanges();
                    MessageBox.Show($"Cập  Nhật '{dbUpdate.Ten}' thành công!", "Thông Báo", MessageBoxButtons.OK);
                    LoadDGV();
                    LoadForm();
                    focusSP();

                }
                
            }
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
               
                NHANVIEN delNV = dbContent.NHANVIENs.FirstOrDefault
                 (p => p.idNV == txtMa.Text);
                if (delNV != null)
                {
                    dbContent.NHANVIENs.Remove(delNV);
                    dbContent.SaveChanges();
                    LoadDGV();
                    LoadForm();
                    MessageBox.Show($"Xoá  '{delNV}' thành công!", "thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("SDT Là kí tự số!", "Thông Báo ");
            }
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtDC_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<NHANVIEN> listNV = dbContent.NHANVIENs.ToList();
            var listTimSinhVien = listNV.Where(p => (p is NHANVIEN) 
                                                    && (p as NHANVIEN).Ten.ToLower().Contains(txtTimKiem.Text.ToLower())

                                                    || (p as NHANVIEN).idNV.ToLower().Contains(txtTimKiem.Text.ToLower())).ToList();
            // && (p as Student).Faculty.FacultyName.ToLower().Contains(cbbKhoa.Text.ToLower())).ToList();
            if (listTimSinhVien.Count > 0)
            {
                FILLDataDGV(listTimSinhVien);
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtDC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
