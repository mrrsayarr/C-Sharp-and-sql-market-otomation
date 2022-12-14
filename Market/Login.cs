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
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=SSD-CAT;Initial Catalog=marketDB.bacpac;Integrated Security=True");
            
            SqlCommand komut = new SqlCommand("Select * From adminTB Where adminName='" + txtUser.Text+ "' and adminPass='" + txtPass.Text + "'", baglanti);
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            string cmbItemValue = comboBox1.SelectedItem.ToString();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                if (cmbItemValue == "Yönetici")
                {
                    MessageBox.Show("Yönetici Girişi Başarılı");
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                }
                else if (cmbItemValue == "Kasiyer")
                {
                    MessageBox.Show("Kasiyer Girişi Başarılı");
                    Kasiyer kasiyer = new Kasiyer();
                    kasiyer.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
        }

    private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
