using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Market
{

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedText = "Kasiyer";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=SSD-CAT;Initial Catalog=marketDB.bacpac;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From adminTB Where adminName='" + txtUser.Text + "' and adminPass='" + txtPass.Text + "' and usertype='" + comboBox1.Text + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if (comboBox1.Text == "Yönetici")
                {
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                }
                else if (comboBox1.Text == "Kasiyer")
                {
                    kasiyer kasiyer = new kasiyer();
                    kasiyer.listele(); 
                    kasiyer.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
            }
            baglanti.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
