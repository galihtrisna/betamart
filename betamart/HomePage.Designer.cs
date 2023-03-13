namespace betamart
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panelHome = new Panel();
            labelHome = new Label();
            pictureBoxHome = new PictureBox();
            panelTambah = new Panel();
            labelTambah = new Label();
            pictureBoxTambah = new PictureBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panelOperation = new Panel();
            btn_simpan = new Button();
            imageIdentifier = new TextBox();
            inpId = new TextBox();
            label8 = new Label();
            inp_image = new PictureBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            group_edit_delete = new TableLayoutPanel();
            btn_delete = new Button();
            btn_edit = new Button();
            btn_selectImage = new Button();
            inpImage = new PictureBox();
            label7 = new Label();
            panel7 = new Panel();
            inpStok = new TextBox();
            label6 = new Label();
            panel6 = new Panel();
            inpHarga = new TextBox();
            inp_merek = new Label();
            panel5 = new Panel();
            inpMerek = new TextBox();
            label5 = new Label();
            panel4 = new Panel();
            inpKadaluarsa = new DateTimePicker();
            label4 = new Label();
            panel3 = new Panel();
            inpNama = new TextBox();
            panel2 = new Panel();
            labelTitleOperation = new Label();
            panel9 = new Panel();
            inpSearch = new TextBox();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            image = new DataGridViewImageColumn();
            nama = new DataGridViewTextBoxColumn();
            merek = new DataGridViewTextBoxColumn();
            stok = new DataGridViewTextBoxColumn();
            kadaluarsa = new DataGridViewTextBoxColumn();
            harga = new DataGridViewTextBoxColumn();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            panelTambah.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTambah).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            panelOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inp_image).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            group_edit_delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inpImage).BeginInit();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.GhostWhite;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panelHome);
            flowLayoutPanel1.Controls.Add(panelTambah);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(15);
            flowLayoutPanel1.Size = new Size(237, 496);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 0;
            label1.Text = "Data Produk";
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(18, 39);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(198, 67);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 25);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(64, 8);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 1;
            label2.Text = "Galih Trisna";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._220px_Bung_Tomo;
            pictureBox1.Location = new Point(8, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelHome
            // 
            panelHome.BackColor = Color.FromArgb(37, 101, 239);
            panelHome.Controls.Add(labelHome);
            panelHome.Controls.Add(pictureBoxHome);
            panelHome.Location = new Point(18, 112);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(200, 48);
            panelHome.TabIndex = 4;
            panelHome.Click += labelHome_Click;
            panelHome.Paint += panelHome_Paint;
            // 
            // labelHome
            // 
            labelHome.AutoSize = true;
            labelHome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelHome.ForeColor = Color.White;
            labelHome.Location = new Point(41, 14);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(55, 21);
            labelHome.TabIndex = 2;
            labelHome.Text = "Home";
            // 
            // pictureBoxHome
            // 
            pictureBoxHome.Image = Properties.Resources.home_white;
            pictureBoxHome.Location = new Point(11, 10);
            pictureBoxHome.Name = "pictureBoxHome";
            pictureBoxHome.Size = new Size(28, 28);
            pictureBoxHome.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHome.TabIndex = 1;
            pictureBoxHome.TabStop = false;
            // 
            // panelTambah
            // 
            panelTambah.BackColor = Color.White;
            panelTambah.Controls.Add(labelTambah);
            panelTambah.Controls.Add(pictureBoxTambah);
            panelTambah.Location = new Point(18, 166);
            panelTambah.Name = "panelTambah";
            panelTambah.Size = new Size(200, 48);
            panelTambah.TabIndex = 5;
            panelTambah.Click += labelTambah_click;
            panelTambah.Paint += panelTambah_Paint;
            // 
            // labelTambah
            // 
            labelTambah.AutoSize = true;
            labelTambah.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTambah.Location = new Point(41, 14);
            labelTambah.Name = "labelTambah";
            labelTambah.Size = new Size(66, 21);
            labelTambah.TabIndex = 1;
            labelTambah.Text = "Tambah";
            // 
            // pictureBoxTambah
            // 
            pictureBoxTambah.Image = Properties.Resources.plus_square_black;
            pictureBoxTambah.Location = new Point(11, 10);
            pictureBoxTambah.Name = "pictureBoxTambah";
            pictureBoxTambah.Size = new Size(28, 28);
            pictureBoxTambah.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTambah.TabIndex = 0;
            pictureBoxTambah.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Controls.Add(panelOperation);
            flowLayoutPanel2.Controls.Add(panel9);
            flowLayoutPanel2.Controls.Add(dataGridView1);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(237, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(10);
            flowLayoutPanel2.Size = new Size(693, 496);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // panelOperation
            // 
            panelOperation.BackColor = Color.White;
            panelOperation.Controls.Add(btn_simpan);
            panelOperation.Controls.Add(imageIdentifier);
            panelOperation.Controls.Add(inpId);
            panelOperation.Controls.Add(label8);
            panelOperation.Controls.Add(inp_image);
            panelOperation.Controls.Add(flowLayoutPanel3);
            panelOperation.Controls.Add(btn_selectImage);
            panelOperation.Controls.Add(inpImage);
            panelOperation.Controls.Add(label7);
            panelOperation.Controls.Add(panel7);
            panelOperation.Controls.Add(label6);
            panelOperation.Controls.Add(panel6);
            panelOperation.Controls.Add(inp_merek);
            panelOperation.Controls.Add(panel5);
            panelOperation.Controls.Add(label5);
            panelOperation.Controls.Add(panel4);
            panelOperation.Controls.Add(label4);
            panelOperation.Controls.Add(panel3);
            panelOperation.Controls.Add(panel2);
            panelOperation.Location = new Point(13, 13);
            panelOperation.Name = "panelOperation";
            panelOperation.Size = new Size(647, 389);
            panelOperation.TabIndex = 0;
            panelOperation.Visible = false;
            panelOperation.Paint += panelOperation_Paint;
            // 
            // btn_simpan
            // 
            btn_simpan.BackColor = Color.FromArgb(37, 101, 239);
            btn_simpan.FlatStyle = FlatStyle.Flat;
            btn_simpan.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_simpan.ForeColor = Color.White;
            btn_simpan.Location = new Point(14, 318);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(616, 40);
            btn_simpan.TabIndex = 13;
            btn_simpan.Text = "Simpan";
            btn_simpan.UseVisualStyleBackColor = false;
            btn_simpan.Visible = false;
            btn_simpan.Click += btn_simpan_Click;
            btn_simpan.Paint += btn_simpan_Paint;
            // 
            // imageIdentifier
            // 
            imageIdentifier.Location = new Point(246, 40);
            imageIdentifier.Name = "imageIdentifier";
            imageIdentifier.Size = new Size(100, 23);
            imageIdentifier.TabIndex = 17;
            imageIdentifier.Visible = false;
            // 
            // inpId
            // 
            inpId.Location = new Point(140, 42);
            inpId.Name = "inpId";
            inpId.Size = new Size(100, 23);
            inpId.TabIndex = 16;
            inpId.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(369, 118);
            label8.Name = "label8";
            label8.Size = new Size(44, 17);
            label8.TabIndex = 13;
            label8.Text = "Image";
            // 
            // inp_image
            // 
            inp_image.BorderStyle = BorderStyle.FixedSingle;
            inp_image.Location = new Point(360, 134);
            inp_image.Name = "inp_image";
            inp_image.Size = new Size(273, 127);
            inp_image.TabIndex = 15;
            inp_image.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(group_edit_delete);
            flowLayoutPanel3.Location = new Point(14, 325);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(619, 48);
            flowLayoutPanel3.TabIndex = 14;
            // 
            // group_edit_delete
            // 
            group_edit_delete.ColumnCount = 2;
            group_edit_delete.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            group_edit_delete.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            group_edit_delete.Controls.Add(btn_delete, 0, 0);
            group_edit_delete.Controls.Add(btn_edit, 0, 0);
            group_edit_delete.Location = new Point(3, 3);
            group_edit_delete.Name = "group_edit_delete";
            group_edit_delete.RowCount = 1;
            group_edit_delete.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            group_edit_delete.Size = new Size(616, 43);
            group_edit_delete.TabIndex = 14;
            group_edit_delete.Visible = false;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(240, 88, 88);
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(311, 3);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(302, 37);
            btn_delete.TabIndex = 15;
            btn_delete.Text = "Hapus";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            btn_delete.Paint += btn_delete_Paint;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.FromArgb(241, 163, 30);
            btn_edit.BackgroundImageLayout = ImageLayout.None;
            btn_edit.FlatAppearance.BorderSize = 0;
            btn_edit.FlatStyle = FlatStyle.Flat;
            btn_edit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_edit.ForeColor = Color.Black;
            btn_edit.Location = new Point(3, 3);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(302, 37);
            btn_edit.TabIndex = 14;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            btn_edit.Paint += btn_edit_Paint;
            // 
            // btn_selectImage
            // 
            btn_selectImage.BackColor = Color.FromArgb(47, 161, 91);
            btn_selectImage.FlatStyle = FlatStyle.Flat;
            btn_selectImage.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_selectImage.ForeColor = Color.White;
            btn_selectImage.Location = new Point(360, 267);
            btn_selectImage.Name = "btn_selectImage";
            btn_selectImage.Size = new Size(273, 40);
            btn_selectImage.TabIndex = 12;
            btn_selectImage.Text = "Select Image";
            btn_selectImage.UseVisualStyleBackColor = false;
            btn_selectImage.Click += btn_selectImage_Click;
            btn_selectImage.Paint += btn_selectImage_Paint;
            // 
            // inpImage
            // 
            inpImage.BorderStyle = BorderStyle.FixedSingle;
            inpImage.Location = new Point(360, 134);
            inpImage.MaximumSize = new Size(273, 0);
            inpImage.Name = "inpImage";
            inpImage.Size = new Size(273, 0);
            inpImage.TabIndex = 11;
            inpImage.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(21, 251);
            label7.Name = "label7";
            label7.Size = new Size(78, 17);
            label7.TabIndex = 10;
            label7.Text = "Stok Produk";
            // 
            // panel7
            // 
            panel7.AutoSize = true;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(inpStok);
            panel7.Location = new Point(14, 267);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(5);
            panel7.Size = new Size(299, 40);
            panel7.TabIndex = 9;
            // 
            // inpStok
            // 
            inpStok.BackColor = Color.White;
            inpStok.BorderStyle = BorderStyle.None;
            inpStok.Location = new Point(15, 13);
            inpStok.Name = "inpStok";
            inpStok.Size = new Size(269, 16);
            inpStok.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(21, 185);
            label6.Name = "label6";
            label6.Size = new Size(89, 17);
            label6.TabIndex = 8;
            label6.Text = "Harga Produk";
            // 
            // panel6
            // 
            panel6.AutoSize = true;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(inpHarga);
            panel6.Location = new Point(14, 201);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(5);
            panel6.Size = new Size(299, 40);
            panel6.TabIndex = 7;
            // 
            // inpHarga
            // 
            inpHarga.BackColor = Color.White;
            inpHarga.BorderStyle = BorderStyle.None;
            inpHarga.Location = new Point(15, 11);
            inpHarga.Name = "inpHarga";
            inpHarga.Size = new Size(269, 16);
            inpHarga.TabIndex = 0;
            // 
            // inp_merek
            // 
            inp_merek.AutoSize = true;
            inp_merek.FlatStyle = FlatStyle.Flat;
            inp_merek.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            inp_merek.ForeColor = Color.Black;
            inp_merek.Location = new Point(21, 118);
            inp_merek.Name = "inp_merek";
            inp_merek.Size = new Size(90, 17);
            inp_merek.TabIndex = 6;
            inp_merek.Text = "Merek Produk";
            // 
            // panel5
            // 
            panel5.AutoSize = true;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(inpMerek);
            panel5.Location = new Point(14, 134);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(5);
            panel5.Size = new Size(299, 40);
            panel5.TabIndex = 5;
            // 
            // inpMerek
            // 
            inpMerek.BackColor = Color.White;
            inpMerek.BorderStyle = BorderStyle.None;
            inpMerek.Location = new Point(15, 11);
            inpMerek.Name = "inpMerek";
            inpMerek.Size = new Size(269, 16);
            inpMerek.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(369, 53);
            label5.Name = "label5";
            label5.Size = new Size(118, 17);
            label5.TabIndex = 4;
            label5.Text = "Kadaluarsa Produk";
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(inpKadaluarsa);
            panel4.Location = new Point(360, 69);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5);
            panel4.Size = new Size(273, 40);
            panel4.TabIndex = 3;
            // 
            // inpKadaluarsa
            // 
            inpKadaluarsa.Location = new Point(10, 7);
            inpKadaluarsa.Name = "inpKadaluarsa";
            inpKadaluarsa.Size = new Size(249, 23);
            inpKadaluarsa.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 53);
            label4.Name = "label4";
            label4.Size = new Size(88, 17);
            label4.TabIndex = 2;
            label4.Text = "Nama Produk";
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(inpNama);
            panel3.Location = new Point(14, 69);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(299, 40);
            panel3.TabIndex = 1;
            // 
            // inpNama
            // 
            inpNama.BackColor = Color.White;
            inpNama.BorderStyle = BorderStyle.None;
            inpNama.Location = new Point(15, 11);
            inpNama.Name = "inpNama";
            inpNama.Size = new Size(269, 16);
            inpNama.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 101, 239);
            panel2.Controls.Add(labelTitleOperation);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(647, 38);
            panel2.TabIndex = 0;
            // 
            // labelTitleOperation
            // 
            labelTitleOperation.AutoSize = true;
            labelTitleOperation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitleOperation.ForeColor = Color.White;
            labelTitleOperation.Location = new Point(14, 8);
            labelTitleOperation.Name = "labelTitleOperation";
            labelTitleOperation.Size = new Size(54, 21);
            labelTitleOperation.TabIndex = 0;
            labelTitleOperation.Text = "label4";
            // 
            // panel9
            // 
            panel9.AutoSize = true;
            panel9.BackColor = Color.White;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(inpSearch);
            panel9.Location = new Point(13, 408);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(5);
            panel9.Size = new Size(642, 34);
            panel9.TabIndex = 10;
            // 
            // inpSearch
            // 
            inpSearch.BackColor = Color.White;
            inpSearch.BorderStyle = BorderStyle.None;
            inpSearch.Location = new Point(15, 8);
            inpSearch.Name = "inpSearch";
            inpSearch.PlaceholderText = "Cari produk";
            inpSearch.Size = new Size(617, 16);
            inpSearch.TabIndex = 0;
            inpSearch.TextChanged += searchData;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, image, nama, merek, stok, kadaluarsa, harga });
            dataGridView1.Location = new Point(13, 448);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(647, 461);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += gridViewCell_Click;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            id.HeaderText = "ID";
            id.Name = "id";
            id.Width = 43;
            // 
            // image
            // 
            image.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            image.HeaderText = "Image";
            image.Name = "image";
            // 
            // nama
            // 
            nama.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nama.HeaderText = "Nama";
            nama.Name = "nama";
            nama.Width = 64;
            // 
            // merek
            // 
            merek.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            merek.HeaderText = "Merek";
            merek.Name = "merek";
            merek.Width = 65;
            // 
            // stok
            // 
            stok.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stok.HeaderText = "Stok";
            stok.Name = "stok";
            stok.Width = 55;
            // 
            // kadaluarsa
            // 
            kadaluarsa.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            kadaluarsa.HeaderText = "Kadaluarsa";
            kadaluarsa.Name = "kadaluarsa";
            kadaluarsa.Width = 89;
            // 
            // harga
            // 
            harga.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            harga.HeaderText = "Harga";
            harga.Name = "harga";
            harga.Width = 64;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 496);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "HomePage";
            Text = "Form1";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelHome.ResumeLayout(false);
            panelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            panelTambah.ResumeLayout(false);
            panelTambah.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTambah).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            panelOperation.ResumeLayout(false);
            panelOperation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inp_image).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            group_edit_delete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)inpImage).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel sideHome;
        private Label sideDashboardLabel;
        private PictureBox sideHomePic;
        private Panel sideTambah;
        private Label sideTambahLabel;
        private PictureBox sideTambahPic;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panelOperation;
        private Panel panel2;
        private Label labelTitleOperation;
        private Panel panel3;
        private TextBox inpNama;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button btn_simpan;
        private TableLayoutPanel group_edit_delete;
        private Button btn_delete;
        private Button btn_edit;
        private Label label8;
        private Button btn_selectImage;
        private PictureBox inpImage;
        private Label label7;
        private Panel panel7;
        private TextBox inpStok;
        private Label label6;
        private Panel panel6;
        private TextBox inpHarga;
        private Label inp_merek;
        private Panel panel5;
        private TextBox inpMerek;
        private Label label5;
        private Panel panel4;
        private Label label4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewImageColumn image;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewTextBoxColumn merek;
        private DataGridViewTextBoxColumn stok;
        private DataGridViewTextBoxColumn kadaluarsa;
        private DataGridViewTextBoxColumn harga;
        private PictureBox inp_image;
        private TextBox inpId;
        private TextBox imageIdentifier;
        private Panel panel9;
        private TextBox inpSearch;
        private Panel panelHome;
        private Label labelHome;
        private PictureBox pictureBoxHome;
        private Panel panelTambah;
        private Label labelTambah;
        private PictureBox pictureBoxTambah;
        private DateTimePicker inpKadaluarsa;

    }
}