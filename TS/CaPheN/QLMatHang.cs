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
    public partial class QLMatHang : Form
    {
        DbCaPheConTent dbContent = new DbCaPheConTent();
        public QLMatHang()
        {
            InitializeComponent();
        }

        private void QLMon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'caPheMngDataSet.FoodCategory' table. You can move, or remove it, as needed.
            this.foodCategoryTableAdapter.Fill(this.caPheMngDataSet.FoodCategory);
            // TODO: This line of code loads data into the 'caPheMngDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.caPheMngDataSet.NHANVIEN);
            // TODO: This line of code loads data into the 'caPheMngDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.caPheMngDataSet.Account);
            List<Food> listFood = dbContent.Foods.ToList();
            List<FoodCategory> listfoodCategories = dbContent.FoodCategories.ToList();
            FILLDataCBB(listfoodCategories);
            FILLDataDGV(listFood);
        }

        private void FILLDataDGV(List<Food> listFood)
        {
            dgvQLMon.Rows.Clear();
            foreach (var item in listFood)
            {
                int RowNew = dgvQLMon.Rows.Add();
                dgvQLMon.Rows[RowNew].Cells[0].Value = item.idFood;
                dgvQLMon.Rows[RowNew].Cells[1].Value = item.FoodCategory.nameCategory;
                dgvQLMon.Rows[RowNew].Cells[2].Value = item.nameFood;
                dgvQLMon.Rows[RowNew].Cells[3].Value = item.price;
                

            }
        }
        private void LoadDGV()
        {
            List<Food> newListFood = dbContent.Foods.ToList();
            FILLDataDGV(newListFood);
        }
        private void LoadForm()
        {
            txtTenMon.Clear();
            txtGia.Clear();
            txtMa.Clear();
            txtTenMon.Focus();
        }
        private void FILLDataCBB(List<FoodCategory> listfoodCategories)
        {
            cbbLoai.DataSource = listfoodCategories;
            cbbLoai.DisplayMember = "nameCategory";
            cbbLoai.ValueMember = "idCategory";
        }

        private void dgvQLMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvQLMon.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvQLMon.CurrentCell.Selected = true;
                    txtMa.Text = dgvQLMon.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    cbbLoai.SelectedIndex = cbbLoai.FindString(dgvQLMon.Rows[e.RowIndex].Cells[1].FormattedValue.ToString());
                    txtTenMon.Text = dgvQLMon.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    txtGia.Text = dgvQLMon.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {

                if (checkIDFOOD(txtMa.Text) == -1)
                {
                    Food newFood = new Food();

                    // newFood = txtMaSo.Text;
                    newFood.nameFood = txtTenMon.Text;
                    newFood.price = Convert.ToDouble(txtGia.Text);
                    newFood.idCategory = Convert.ToInt32(cbbLoai.SelectedValue.ToString());

                    dbContent.Foods.AddOrUpdate(newFood);
                    dbContent.SaveChanges();
                    MessageBox.Show($"Thêm Món Mới  '{newFood.nameFood}' Thành Công!", "Thông Báo", MessageBoxButtons.OK);

                    LoadDGV();
                    LoadForm();
                    focusSP();
                }
                else
                {
                    MessageBox.Show($"Mã Món'{txtMa.Text}' đã tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private int checkIDFOOD(string IDNFOOD)
        {
            int length = dgvQLMon.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dgvQLMon.Rows[i].Cells[0].Value != null)
                    if (dgvQLMon.Rows[i].Cells[0].Value.ToString() == IDNFOOD)
                        return i;
            }
            return -1;
        }
        private bool CheckDataInput()
        {
            if (txtTenMon.Text == "" || txtGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //else
            //{
            //    float kq = 0;
            //    bool ketqua = float.TryParse(txtDTB.Text, out kq);
            //    if (!ketqua)
            //    {
            //        MessageBox.Show("điểm sv k đúng!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return false;

            //    }
            //}
            return true;
        }
        public void focusSP()
        {
            dgvQLMon.ClearSelection();
            int row = dgvQLMon.Rows.Count - 2;
            dgvQLMon.Rows[row].Selected = true;
            dgvQLMon.Rows[row].Cells[0].Selected = true;
        }

        private void btnCNmon_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(txtMa.Text);

            Food dbUpdate = dbContent.Foods.FirstOrDefault(p => p.idFood == temp);

            if (dbUpdate != null)
            {
                dbUpdate.nameFood = txtTenMon.Text;
                dbUpdate.price = Convert.ToDouble(txtGia.Text);
                dbUpdate.idCategory = Convert.ToInt32(cbbLoai.SelectedValue);
                dbContent.Foods.AddOrUpdate(dbUpdate);
                dbContent.SaveChanges();
                MessageBox.Show($"Cập  Nhật '{dbUpdate.nameFood}' thành công!", "Thông Báo", MessageBoxButtons.OK);
                LoadDGV();
                LoadForm();
                focusSP();

            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("SHow QUản lý Khoa");
            this.Hide();
            frmMenu f1 = new frmMenu();
            f1.ShowDialog();
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                int tam = int.Parse(txtMa.Text);
                Food delStudent = dbContent.Foods.FirstOrDefault
                 (p => p.idFood == tam );
                if (delStudent != null)
                {
                    dbContent.Foods.Remove(delStudent);
                    dbContent.SaveChanges();
                    LoadDGV();
                    LoadForm();
                    MessageBox.Show($"Xoá  '{delStudent.nameFood}' thành công!", "thông báo", MessageBoxButtons.OK);
                }
            }
        }
       
        //search
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            List<Food> listFood = dbContent.Foods.ToList();
            var listTimSinhVien = listFood.Where(p => (p is Food) //&& (p as Student).StudentID.ToLower().Contains(txtMa.Text.ToLower())
                                                    && (p as Food).nameFood.ToLower().Contains(txtTimKiem.Text.ToLower())).ToList();
            // && (p as Student).Faculty.FacultyName.ToLower().Contains(cbbKhoa.Text.ToLower())).ToList();
            if (listTimSinhVien.Count > 0)
            {
                FILLDataDGV(listTimSinhVien);
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Món!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvQLMon_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvQLMon.Rows[e.RowIndex].Height = 42;
        }

        private void txtTenMon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenMon_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Giá là Số", "Thông Báo ");

            }
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
