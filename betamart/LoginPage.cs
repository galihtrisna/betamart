using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace betamart
{
    public partial class LoginPage : Form
    {
        MySqlConnection conn = Connections.getConnection();
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            try
            {
                if (textEmail.Text == "" || textPassword.Text == "")
                {
                    invalidLogin1.Visible = true;
                    invalidLogin2.Visible = true;
                }
                else if (textEmail.Text != "" && textPassword.Text != "")
                {
                    MySqlDataReader reader;
                    conn.Open();
                    string Query = "SELECT * FROM users WHERE email='" + textEmail.Text + "' AND password='" + textPassword.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(Query, conn);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        HomePage homePage = new HomePage();
                        homePage.Show();
                        this.Hide();

                    }
                    else
                    {
                        invalidLogin1.Visible = true;
                        invalidLogin2.Visible = true;
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Masuk_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int arcSize = 25;
            path.AddArc(0, 0, arcSize, arcSize, 180, 90);
            path.AddArc(btnMasuk.Width - arcSize, 0, arcSize, arcSize, 270, 90);
            path.AddArc(btnMasuk.Width - arcSize, btnMasuk.Height - arcSize, arcSize, arcSize, 0, 90);
            path.AddArc(0, btnMasuk.Height - arcSize, arcSize, arcSize, 90, 90);
            btnMasuk.Region = new System.Drawing.Region(path);
        }


    }
}
