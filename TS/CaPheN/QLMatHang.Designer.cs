
namespace CaPheN
{
    partial class QLMatHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLMatHang));
            this.txtTenMon = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.txtGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMa = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvQLMon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.caPheMngDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.caPheMngDataSet = new CaPheN.CaPheMngDataSet();
            this.btnXoaMon = new Guna.UI2.WinForms.Guna2Button();
            this.btnCNmon = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemMon = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTableAdapter = new CaPheN.CaPheMngDataSetTableAdapters.AccountTableAdapter();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new CaPheN.CaPheMngDataSetTableAdapters.NHANVIENTableAdapter();
            this.foodCategoryTableAdapter = new CaPheN.CaPheMngDataSetTableAdapters.FoodCategoryTableAdapter();
            this.billinFoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billinFoTableAdapter = new CaPheN.CaPheMngDataSetTableAdapters.BillinFoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caPheMngDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caPheMngDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billinFoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenMon
            // 
            this.txtTenMon.BorderColor = System.Drawing.Color.Black;
            this.txtTenMon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenMon.DefaultText = "";
            this.txtTenMon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenMon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenMon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenMon.DisabledState.Parent = this.txtTenMon;
            this.txtTenMon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenMon.FillColor = System.Drawing.SystemColors.Control;
            this.txtTenMon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenMon.FocusedState.Parent = this.txtTenMon;
            this.txtTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(173)))));
            this.txtTenMon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenMon.HoverState.Parent = this.txtTenMon;
            this.txtTenMon.Location = new System.Drawing.Point(14, 175);
            this.txtTenMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.PasswordChar = '\0';
            this.txtTenMon.PlaceholderText = "";
            this.txtTenMon.SelectedText = "";
            this.txtTenMon.ShadowDecoration.Parent = this.txtTenMon;
            this.txtTenMon.Size = new System.Drawing.Size(179, 26);
            this.txtTenMon.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTenMon.TabIndex = 37;
            this.txtTenMon.TextChanged += new System.EventHandler(this.txtTenMon_TextChanged);
            this.txtTenMon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenMon_KeyPress);
            // 
            // cbbLoai
            // 
            this.cbbLoai.BackColor = System.Drawing.Color.White;
            this.cbbLoai.BorderColor = System.Drawing.Color.Black;
            this.cbbLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoai.FillColor = System.Drawing.SystemColors.Control;
            this.cbbLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoai.FocusedState.Parent = this.cbbLoai;
            this.cbbLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(173)))));
            this.cbbLoai.HoverState.Parent = this.cbbLoai;
            this.cbbLoai.ItemHeight = 30;
            this.cbbLoai.ItemsAppearance.Parent = this.cbbLoai;
            this.cbbLoai.Location = new System.Drawing.Point(14, 107);
            this.cbbLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.ShadowDecoration.Parent = this.cbbLoai;
            this.cbbLoai.Size = new System.Drawing.Size(185, 36);
            this.cbbLoai.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbbLoai.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(10, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 27);
            this.label4.TabIndex = 33;
            this.label4.Text = "Tên Món";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(243, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 27);
            this.label3.TabIndex = 34;
            this.label3.Text = "Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(10, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 27);
            this.label2.TabIndex = 35;
            this.label2.Text = "Loại";
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtGia
            // 
            this.txtGia.BorderColor = System.Drawing.Color.Black;
            this.txtGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGia.DefaultText = "";
            this.txtGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGia.DisabledState.Parent = this.txtGia;
            this.txtGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGia.FillColor = System.Drawing.SystemColors.Control;
            this.txtGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGia.FocusedState.Parent = this.txtGia;
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(173)))));
            this.txtGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGia.HoverState.Parent = this.txtGia;
            this.txtGia.Location = new System.Drawing.Point(248, 175);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGia.Name = "txtGia";
            this.txtGia.PasswordChar = '\0';
            this.txtGia.PlaceholderText = "";
            this.txtGia.SelectedText = "";
            this.txtGia.ShadowDecoration.Parent = this.txtGia;
            this.txtGia.Size = new System.Drawing.Size(179, 26);
            this.txtGia.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtGia.TabIndex = 38;
            this.txtGia.TextChanged += new System.EventHandler(this.txtGia_TextChanged);
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(243, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 27);
            this.label1.TabIndex = 45;
            this.label1.Text = "Mã";
            // 
            // txtMa
            // 
            this.txtMa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(229)))), ((int)(((byte)(232)))));
            this.txtMa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtMa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMa.DefaultText = "";
            this.txtMa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMa.DisabledState.Parent = this.txtMa;
            this.txtMa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMa.FillColor = System.Drawing.SystemColors.Control;
            this.txtMa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMa.FocusedState.Parent = this.txtMa;
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(173)))));
            this.txtMa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMa.HoverState.Parent = this.txtMa;
            this.txtMa.Location = new System.Drawing.Point(248, 107);
            this.txtMa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMa.Name = "txtMa";
            this.txtMa.PasswordChar = '\0';
            this.txtMa.PlaceholderText = "Mã Tự tăng";
            this.txtMa.SelectedText = "";
            this.txtMa.ShadowDecoration.Parent = this.txtMa;
            this.txtMa.Size = new System.Drawing.Size(179, 29);
            this.txtMa.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtMa.TabIndex = 44;
            this.txtMa.TextChanged += new System.EventHandler(this.txtMa_TextChanged);
            // 
            // dgvQLMon
            // 
            this.dgvQLMon.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvQLMon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLMon.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvQLMon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvQLMon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLMon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLMon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQLMon.ColumnHeadersHeight = 27;
            this.dgvQLMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMa,
            this.dgvLoai,
            this.dgvTenSP,
            this.dgvGia});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLMon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQLMon.EnableHeadersVisualStyles = false;
            this.dgvQLMon.GridColor = System.Drawing.SystemColors.Control;
            this.dgvQLMon.Location = new System.Drawing.Point(0, 240);
            this.dgvQLMon.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQLMon.Name = "dgvQLMon";
            this.dgvQLMon.ReadOnly = true;
            this.dgvQLMon.RowHeadersVisible = false;
            this.dgvQLMon.RowHeadersWidth = 51;
            this.dgvQLMon.RowTemplate.Height = 24;
            this.dgvQLMon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLMon.Size = new System.Drawing.Size(839, 236);
            this.dgvQLMon.TabIndex = 48;
            this.dgvQLMon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLMon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvQLMon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvQLMon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvQLMon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvQLMon.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvQLMon.ThemeStyle.GridColor = System.Drawing.SystemColors.Control;
            this.dgvQLMon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvQLMon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvQLMon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvQLMon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvQLMon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvQLMon.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvQLMon.ThemeStyle.ReadOnly = true;
            this.dgvQLMon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLMon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLMon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvQLMon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQLMon.ThemeStyle.RowsStyle.Height = 24;
            this.dgvQLMon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQLMon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQLMon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLMon_CellClick);
            this.dgvQLMon.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvQLMon_RowsAdded);
            // 
            // dgvMa
            // 
            this.dgvMa.HeaderText = "Mã";
            this.dgvMa.MinimumWidth = 6;
            this.dgvMa.Name = "dgvMa";
            this.dgvMa.ReadOnly = true;
            // 
            // dgvLoai
            // 
            this.dgvLoai.HeaderText = "Loại";
            this.dgvLoai.MinimumWidth = 6;
            this.dgvLoai.Name = "dgvLoai";
            this.dgvLoai.ReadOnly = true;
            // 
            // dgvTenSP
            // 
            this.dgvTenSP.HeaderText = "Tên Sản Phẩm";
            this.dgvTenSP.MinimumWidth = 6;
            this.dgvTenSP.Name = "dgvTenSP";
            this.dgvTenSP.ReadOnly = true;
            // 
            // dgvGia
            // 
            this.dgvGia.HeaderText = "Giá";
            this.dgvGia.MinimumWidth = 6;
            this.dgvGia.Name = "dgvGia";
            this.dgvGia.ReadOnly = true;
            // 
            // foodCategoryBindingSource
            // 
            this.foodCategoryBindingSource.DataMember = "FoodCategory";
            this.foodCategoryBindingSource.DataSource = this.caPheMngDataSetBindingSource;
            // 
            // caPheMngDataSetBindingSource
            // 
            this.caPheMngDataSetBindingSource.DataSource = this.caPheMngDataSet;
            this.caPheMngDataSetBindingSource.Position = 0;
            // 
            // caPheMngDataSet
            // 
            this.caPheMngDataSet.DataSetName = "CaPheMngDataSet";
            this.caPheMngDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoaMon.BorderRadius = 5;
            this.btnXoaMon.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnXoaMon.CheckedState.Parent = this.btnXoaMon;
            this.btnXoaMon.CustomImages.Parent = this.btnXoaMon;
            this.btnXoaMon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaMon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaMon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaMon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaMon.DisabledState.Parent = this.btnXoaMon;
            this.btnXoaMon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoaMon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaMon.ForeColor = System.Drawing.Color.White;
            this.btnXoaMon.HoverState.Parent = this.btnXoaMon;
            this.btnXoaMon.ImageSize = new System.Drawing.Size(50, 50);
            this.btnXoaMon.Location = new System.Drawing.Point(601, 138);
            this.btnXoaMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.ShadowDecoration.Parent = this.btnXoaMon;
            this.btnXoaMon.Size = new System.Drawing.Size(106, 49);
            this.btnXoaMon.TabIndex = 49;
            this.btnXoaMon.Text = "Xóa";
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // btnCNmon
            // 
            this.btnCNmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(173)))));
            this.btnCNmon.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCNmon.CheckedState.Parent = this.btnCNmon;
            this.btnCNmon.CustomImages.Parent = this.btnCNmon;
            this.btnCNmon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCNmon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCNmon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCNmon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCNmon.DisabledState.Parent = this.btnCNmon;
            this.btnCNmon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCNmon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCNmon.ForeColor = System.Drawing.Color.White;
            this.btnCNmon.HoverState.Parent = this.btnCNmon;
            this.btnCNmon.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCNmon.Location = new System.Drawing.Point(444, 138);
            this.btnCNmon.Margin = new System.Windows.Forms.Padding(2);
            this.btnCNmon.Name = "btnCNmon";
            this.btnCNmon.ShadowDecoration.Parent = this.btnCNmon;
            this.btnCNmon.Size = new System.Drawing.Size(107, 49);
            this.btnCNmon.TabIndex = 50;
            this.btnCNmon.Text = "Sửa";
            this.btnCNmon.Click += new System.EventHandler(this.btnCNmon_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(173)))));
            this.btnThemMon.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnThemMon.CheckedState.Parent = this.btnThemMon;
            this.btnThemMon.CustomImages.Parent = this.btnThemMon;
            this.btnThemMon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemMon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemMon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemMon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemMon.DisabledState.Parent = this.btnThemMon;
            this.btnThemMon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThemMon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemMon.ForeColor = System.Drawing.Color.White;
            this.btnThemMon.HoverState.Parent = this.btnThemMon;
            this.btnThemMon.ImageSize = new System.Drawing.Size(50, 50);
            this.btnThemMon.Location = new System.Drawing.Point(727, 138);
            this.btnThemMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.ShadowDecoration.Parent = this.btnThemMon;
            this.btnThemMon.Size = new System.Drawing.Size(112, 49);
            this.btnThemMon.TabIndex = 51;
            this.btnThemMon.Text = "Thêm";
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(322, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 27);
            this.label5.TabIndex = 52;
            this.label5.Text = "Quản Lí Mặt Hàng";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(229)))), ((int)(((byte)(232)))));
            this.txtTimKiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.Parent = this.txtTimKiem;
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FillColor = System.Drawing.SystemColors.Control;
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.FocusedState.Parent = this.txtTimKiem;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(173)))));
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.HoverState.Parent = this.txtTimKiem;
            this.txtTimKiem.Location = new System.Drawing.Point(444, 73);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Tìm Tên";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.ShadowDecoration.Parent = this.txtTimKiem;
            this.txtTimKiem.Size = new System.Drawing.Size(193, 43);
            this.txtTimKiem.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTimKiem.TabIndex = 53;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(663, 73);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(118, 37);
            this.guna2Button1.TabIndex = 54;
            this.guna2Button1.Text = "Tìm";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.DisabledState.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2Button2.Location = new System.Drawing.Point(767, 7);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(60, 38);
            this.guna2Button2.TabIndex = 55;
            this.guna2Button2.Text = "Back";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.caPheMngDataSetBindingSource;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.caPheMngDataSetBindingSource;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // foodCategoryTableAdapter
            // 
            this.foodCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // billinFoBindingSource
            // 
            this.billinFoBindingSource.DataMember = "BillinFo";
            this.billinFoBindingSource.DataSource = this.caPheMngDataSetBindingSource;
            // 
            // billinFoTableAdapter
            // 
            this.billinFoTableAdapter.ClearBeforeFill = true;
            // 
            // QLMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 476);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnXoaMon);
            this.Controls.Add(this.btnCNmon);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.dgvQLMon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.cbbLoai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QLMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLMon";
            this.Load += new System.EventHandler(this.QLMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caPheMngDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caPheMngDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billinFoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtTenMon;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2TextBox txtGia;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtMa;
        private Guna.UI2.WinForms.Guna2DataGridView dgvQLMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGia;
        private Guna.UI2.WinForms.Guna2Button btnXoaMon;
        private Guna.UI2.WinForms.Guna2Button btnCNmon;
        private Guna.UI2.WinForms.Guna2Button btnThemMon;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.BindingSource caPheMngDataSetBindingSource;
        private CaPheMngDataSet caPheMngDataSet;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private CaPheMngDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private CaPheMngDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.BindingSource foodCategoryBindingSource;
        private CaPheMngDataSetTableAdapters.FoodCategoryTableAdapter foodCategoryTableAdapter;
        private System.Windows.Forms.BindingSource billinFoBindingSource;
        private CaPheMngDataSetTableAdapters.BillinFoTableAdapter billinFoTableAdapter;
    }
}