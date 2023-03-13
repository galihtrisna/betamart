using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace betamart
{
    public partial class HomePage : Form
    {
        MySqlConnection conn = Connections.getConnection();
        public HomePage()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            fillDataTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
        }

        private void sideDashboardClick(object sender, EventArgs e)
        {
            panelOperation.Visible = false;

            //dashboard
            sideHome.BackColor = Color.Blue;
            sideDashboardLabel.ForeColor = Color.White;
            sideHomePic.Image = betamart.Properties.Resources.home_white;

            //tambah
            sideTambah.BackColor = Color.White;
            sideDashboardLabel.ForeColor = Color.Black;
            sideTambahPic.Image = betamart.Properties.Resources.plus_square_black;
        }

        private void sideTambahClick(object sender, EventArgs e)
        {
            panelOperation.Visible = true;
            btn_simpan.Visible = true;
            group_edit_delete.Visible = false;

            //dashboard
            sideHome.BackColor = Color.White;
            sideDashboardLabel.ForeColor = Color.Black;
            sideHomePic.Image = betamart.Properties.Resources.home;

            //tambah
            sideTambah.BackColor = Color.Blue;
            sideTambahLabel.ForeColor = Color.White;
            sideTambahPic.Image = betamart.Properties.Resources.plus_square_white;

            setHeaderPanelOperation("Tambah Data");
            clearInput();
        }

        public void resetIncrement()
        {
            MySqlScript script = new MySqlScript(conn, "SET @id := 0; UPDATE products SET id = @id := (@id+1); " +
                "ALTER TABLE products AUTO_INCREMENT = 1;");
            script.Execute();
        }
        private void clearInput()
        {
            inpNama.Text = null;
            inpMerek.Text = null;
            inpKadaluarsa.Text = null;
            inp_image.Image = null;
            inpHarga.Text = null;
            inpStok.Text = null;
            inpId.Text = null;
            imageIdentifier.Text = null;
        }

        private void setHeaderPanelOperation(string text)
        {
            labelTitleOperation.Text = text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_selectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                inp_image.Image = new Bitmap(openFileDialog.FileName);
                inp_image.SizeMode = PictureBoxSizeMode.StretchImage;
                imageIdentifier.Text = openFileDialog.FileName;
            }
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (inpNama.Text == "" || inpMerek.Text == "" || inpHarga.Text == "" || inpStok.Text == "" || imageIdentifier.Text == "")
            {
                MessageBox.Show("Kolom Harus Diisi Semua");
            }
            else
            {
                MySqlCommand cmd;
                try
                {
                    MemoryStream ms = new MemoryStream();
                    inp_image.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] imageBytes = ms.ToArray();

                    conn.Open();
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "INSERT INTO products (nama, merek, harga, stok, kadaluarsa, image) VALUE(@nama, @merek, @harga, @stok, @kadaluarsa, @image)";
                    cmd.Parameters.AddWithValue("@nama", inpNama.Text);
                    cmd.Parameters.AddWithValue("@merek", inpMerek.Text);
                    cmd.Parameters.AddWithValue("@harga", inpHarga.Text);
                    cmd.Parameters.AddWithValue("@stok", inpStok.Text);
                    cmd.Parameters.AddWithValue("@kadaluarsa", inpKadaluarsa.Text);
                    cmd.Parameters.AddWithValue("@image", imageBytes);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    clearInput();
                    fillDataTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void fillDataTable()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.RowTemplate.Height = 150;
            string Query = "SELECT * FROM products";
            MySqlDataReader reader;
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(Query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    byte[] imageBytes = (byte[])reader["image"];
                    Image image = null;
                    if (imageBytes != null)
                    {
                        MemoryStream stream = new MemoryStream(imageBytes);
                        image = Image.FromStream(stream);
                    }
                    dataGridView1.Rows.Add(reader["id"].ToString(), image, reader["nama"].ToString(), reader["merek"].ToString(), reader["stok"].ToString(), reader["kadaluarsa"].ToString(), reader["harga"].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridViewCell_Click(object sender, DataGridViewCellEventArgs e)
        {
            setHeaderPanelOperation("Edit Dan Delete");
            btn_simpan.Visible = false;
            group_edit_delete.Visible = true;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            Bitmap bitmap = (Bitmap)row.Cells["image"].Value;
            inp_image.Image = bitmap;
            inp_image.SizeMode = PictureBoxSizeMode.StretchImage;

            panelOperation.Visible = true;
            inpId.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            inpNama.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            inpMerek.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            inpStok.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            inpKadaluarsa.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            inpHarga.Text = dataGridView1[6, e.RowIndex].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string Query = "DELETE FROM products WHERE id=" + inpId.Text + ";";
            try
            {

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(Query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                resetIncrement();
                fillDataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

            MySqlCommand cmd;

            if (inpNama.Text == "" || inpMerek.Text == "" || inpHarga.Text == "" || inpStok.Text == "")
            {
                MessageBox.Show("Kolom Harus Diisi Semua");
            }
            else
            {
                try
                {
                    conn.Open();
                    cmd = conn.CreateCommand();
                    string query = "UPDATE products SET nama=@nama, merek=@merek, harga=@harga, stok=@stok, kadaluarsa=@kadaluarsa";
                    if (imageIdentifier.Text != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        inp_image.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] imageBytes = ms.ToArray();
                        query += ", image=@image";
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@image", imageBytes);
                    }
                    else
                    {
                        query += "";
                        cmd.CommandText = query;
                    }
                    cmd.Parameters.AddWithValue("@nama", inpNama.Text);
                    cmd.Parameters.AddWithValue("@merek", inpMerek.Text);
                    cmd.Parameters.AddWithValue("@harga", inpHarga.Text);
                    cmd.Parameters.AddWithValue("@stok", inpStok.Text);
                    cmd.Parameters.AddWithValue("@kadaluarsa", inpKadaluarsa.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    fillDataTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void searchData(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM products products WHERE id LIKE '%" + inpSearch.Text + "%' OR nama LIKE '%" + inpSearch.Text + "%' OR harga LIKE '%" + inpSearch.Text + "%' OR merek LIKE '%" + inpSearch.Text + "%' OR kadaluarsa LIKE '%" + inpSearch.Text + "%' OR stok LIKE '%" + inpSearch.Text + "%'";
            dataGridView1.Rows.Clear();
            MySqlDataReader reader;
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(Query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    byte[] imageBytes = (byte[])reader["image"];
                    Image image = null;
                    if (imageBytes != null)
                    {
                        MemoryStream stream = new MemoryStream(imageBytes);
                        image = Image.FromStream(stream);
                    }
                    dataGridView1.Rows.Add(reader["id"].ToString(), image, reader["nama"].ToString(), reader["merek"].ToString(), reader["stok"].ToString(), reader["kadaluarsa"].ToString(), reader["harga"].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelHome_Click(object sender, EventArgs e)
        {
            panelOperation.Visible = false;

            //dashboard
            panelHome.BackColor = Color.Blue;
            labelHome.ForeColor = Color.White;
            pictureBoxHome.Image = betamart.Properties.Resources.home_white;

            //tambah
            panelTambah.BackColor = Color.White;
            labelTambah.ForeColor = Color.Black;
            pictureBoxTambah.Image = betamart.Properties.Resources.plus_square_black;
        }

        private void labelTambah_click(object sender, EventArgs e)
        {
            panelOperation.Visible = true;
            btn_simpan.Visible = true;
            group_edit_delete.Visible = false;

            //dashboard
            panelHome.BackColor = Color.White;
            labelHome.ForeColor = Color.Black;
            pictureBoxHome.Image = betamart.Properties.Resources.home;

            //tambah
            panelTambah.BackColor = Color.Blue;
            labelTambah.ForeColor = Color.White;
            pictureBoxTambah.Image = betamart.Properties.Resources.plus_square_white;
        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int arcSize = 35;
            path.AddArc(0, 0, arcSize, arcSize, 180, 90);
            path.AddArc(panelHome.Width - arcSize, 0, arcSize, arcSize, 270, 90);
            path.AddArc(panelHome.Width - arcSize, panelHome.Height - arcSize, arcSize, arcSize, 0, 90);
            path.AddArc(0, panelHome.Height - arcSize, arcSize, arcSize, 90, 90);
            panelHome.Region = new System.Drawing.Region(path);
        }

        private void panelTambah_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int arcSize = 35;
            path.AddArc(0, 0, arcSize, arcSize, 180, 90);
            path.AddArc(panelTambah.Width - arcSize, 0, arcSize, arcSize, 270, 90);
            path.AddArc(panelTambah.Width - arcSize, panelTambah.Height - arcSize, arcSize, arcSize, 0, 90);
            path.AddArc(0, panelTambah.Height - arcSize, arcSize, arcSize, 90, 90);
            panelTambah.Region = new System.Drawing.Region(path);
        }

        private void panelOperation_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int arcSize = 35;
            path.AddArc(0, 0, arcSize, arcSize, 180, 90);
            path.AddArc(panelOperation.Width - arcSize, 0, arcSize, arcSize, 270, 90);
            path.AddArc(panelOperation.Width - arcSize, panelOperation.Height - arcSize, arcSize, arcSize, 0, 90);
            path.AddArc(0, panelOperation.Height - arcSize, arcSize, arcSize, 90, 90);
            panelOperation.Region = new System.Drawing.Region(path);
        }

        private void btn_simpan_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int arcSize = 25;
            path.AddArc(0, 0, arcSize, arcSize, 180, 90);
            path.AddArc(btn_simpan.Width - arcSize, 0, arcSize, arcSize, 270, 90);
            path.AddArc(btn_simpan.Width - arcSize, btn_simpan.Height - arcSize, arcSize, arcSize, 0, 90);
            path.AddArc(0, btn_simpan.Height - arcSize, arcSize, arcSize, 90, 90);
            btn_simpan.Region = new System.Drawing.Region(path);
        }
        private void btn_delete_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int arcSize = 25;
            path.AddArc(0, 0, arcSize, arcSize, 180, 90);
            path.AddArc(btn_delete.Width - arcSize, 0, arcSize, arcSize, 270, 90);
            path.AddArc(btn_delete.Width - arcSize, btn_delete.Height - arcSize, arcSize, arcSize, 0, 90);
            path.AddArc(0, btn_delete.Height - arcSize, arcSize, arcSize, 90, 90);
            btn_delete.Region = new System.Drawing.Region(path);
        }
        private void btn_edit_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int arcSize = 25;
            path.AddArc(0, 0, arcSize, arcSize, 180, 90);
            path.AddArc(btn_edit.Width - arcSize, 0, arcSize, arcSize, 270, 90);
            path.AddArc(btn_edit.Width - arcSize, btn_edit.Height - arcSize, arcSize, arcSize, 0, 90);
            path.AddArc(0, btn_edit.Height - arcSize, arcSize, arcSize, 90, 90);
            btn_edit.Region = new System.Drawing.Region(path);
        }
        private void btn_selectImage_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int arcSize = 25;
            path.AddArc(0, 0, arcSize, arcSize, 180, 90);
            path.AddArc(btn_selectImage.Width - arcSize, 0, arcSize, arcSize, 270, 90);
            path.AddArc(btn_selectImage.Width - arcSize, btn_selectImage.Height - arcSize, arcSize, arcSize, 0, 90);
            path.AddArc(0, btn_selectImage.Height - arcSize, arcSize, arcSize, 90, 90);
            btn_selectImage.Region = new System.Drawing.Region(path);
        }
    }
}