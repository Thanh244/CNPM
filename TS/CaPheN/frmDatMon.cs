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
    public partial class frmDatMon : Form
    {
        DbCaPheConTent dbContent = new DbCaPheConTent();
        public frmDatMon()
        {
            InitializeComponent();
        }
        private void LoadDGV()
        {
            List<Food> newListFood = dbContent.Foods.ToList();
            FILLDataDGV(newListFood);
        }
        private void LoadForm()
        {
            txtTenMon.Clear();
          
            
        }
        private void FILLDataCBB(List<FoodCategory> listfoodCategories)
        {
            cbbLoai.DataSource = listfoodCategories;
            cbbLoai.DisplayMember = "nameCategory";
            cbbLoai.ValueMember = "idCategory";
        }
        // hiển thị tên nv lên cbb
        private void FILLDataCBB(List<NHANVIEN> listNhanVien)
        {
            cbbTenNV.DataSource = listNhanVien;
            cbbTenNV.DisplayMember = "Ten";
            cbbTenNV.ValueMember = "idNV";
        }

        private void FILLDataDGV(List<Food> listFood)
        {
            dgvTimKiem.Rows.Clear();

           // if(cbbLoai.SelectedValue)

            foreach (var item in listFood)
            {
                int RowNew = dgvTimKiem.Rows.Add();

                dgvTimKiem.Rows[RowNew].Cells[0].Value = item.nameFood;
                dgvTimKiem.Rows[RowNew].Cells[2].Value = item.price;
                dgvTimKiem.Rows[RowNew].Cells[1].Value = item.FoodCategory.nameCategory;

            }
        }
        private void frmDatMon_Load(object sender, EventArgs e)
        {
            List<Food> listFood = dbContent.Foods.ToList();
            List<FoodCategory> listfoodCategories = dbContent.FoodCategories.ToList();
            List<NHANVIEN> listNhanVien = dbContent.NHANVIENs.ToList();
            FILLDataCBB(listfoodCategories);
            FILLDataDGV(listFood);
            FILLDataCBB(listNhanVien);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //chọn
        private void dgvTimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvTimKiem.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvTimKiem.CurrentCell.Selected = true;

                    txtTenMon.Text = dgvTimKiem.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtGia.Text = dgvTimKiem.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                   
                    cbbLoai.SelectedIndex = cbbLoai.FindString(dgvTimKiem.Rows[e.RowIndex].Cells[1].FormattedValue.ToString());
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu f1 = new frmMenu();
            f1.ShowDialog();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {

                float a, b, kq;
                a = Convert.ToInt32(txtSL.Text);
                b = Convert.ToInt32(txtGia.Text);
                kq = a * b;
                txtTongTIen.Text = kq.ToString();
            }
            catch
            {

                MessageBox.Show("Nhập sai");
            }


            //string data_textbox_sl = txtSL.Text; // lấy dữ liệu từ Textbox A
            //string data_textbox_gia = txtGia.Text; // lấy dữ liệu từ Textbox B
            //if (data_textbox_sl.Length == 0 )
            //{
            //    MessageBox.Show("Vui lòng điền Số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    int a = Int32.Parse(data_textbox_sl); // ép kiểu dữ liệu lấy được từ Textbox A thành kiểu số nguyên
            //    double b = double.Parse(data_textbox_gia); // ép kiểu dữ liệu lấy được từ Textbox B thành kiểu số nguyên
            //    double result = a * b; // dùng biến result lưu trữ kết quả phép tính

            ////    result = double.Parse(txtTongTIen.Text);

            //    MessageBox.Show("Kết quả của phép toán " + result.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<Food> listFood = dbContent.Foods.ToList();
            var listTim = listFood.Where(p => (p is Food) //&& (p as Student).StudentID.ToLower().Contains(txtMa.Text.ToLower())
                                                    && (p as Food).nameFood.ToLower().Contains(txtTimKiem.Text.ToLower())

             && (p as Food).FoodCategory.nameCategory.ToLower().Contains(cbbLoai.Text.ToLower())).ToList();
            if (listTim.Count > 0)
            {
                FILLDataDGV(listTim);
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Món!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            //try
            //{

            //    float a, b, kq;
            //    a = Convert.ToInt32(txtSL.Text);
            //    b = Convert.ToInt32(txtGia.Text);
            //    kq = a * b;
            //    txtTongTIen.Text = kq.ToString();
            //}
            //catch
            //{

            //    MessageBox.Show("Nhập sai");
            //}
        }

        private void dgvDatMon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTenMon_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbTenNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool CheckDataInput()
        {
            if (txtTenMon.Text == "" || txtGia.Text == "" || txtSL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            return true;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dgvDatMon.Rows.Add(txtTenMon.Text + txtGia.Text + txtSL.Text + txtTongTIen.Text);
        }

        private void btnDatMon_Click(object sender, EventArgs e)
        {
            // method 1
            lbTongTien.Text = (from DataGridViewRow row in dgvDatMon.Rows
                            where row.Cells[3].FormattedValue.ToString() != string.Empty
                            select Convert.ToInt32(row.Cells[3].FormattedValue)).Sum().ToString();

            //  method 2
            int sum = 0;
            for (int i = 0; i <= dgvDatMon.Rows.Count - 1; i++)
            {
                sum += Convert.ToInt32(dgvDatMon.Rows[i].Cells[3].Value);
            }

            lbTongTien.Text = sum.ToString();

            // method 3
            int[] columnData = new int[dgvDatMon.Rows.Count];
            columnData = (from DataGridViewRow row in dgvDatMon.Rows
                          where row.Cells[2].FormattedValue.ToString() != string.Empty
                          select Convert.ToInt32(row.Cells[2].FormattedValue)).ToArray();
            lbTongTien.Text = columnData.Sum().ToString();
            MessageBox.Show("Tiền cần thanh toán là:" + lbTongTien.Text, "Thông báo", MessageBoxButtons.OK);
        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvDatMon.SelectedRows)
            {
                dgvDatMon.Rows.RemoveAt(item.Index);
            }
        }

        private void cbbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
