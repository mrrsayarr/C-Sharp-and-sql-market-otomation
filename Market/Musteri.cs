using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Market
{
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }
        public void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        static string constring_urun = "Data Source=SSD-CAT;Initial Catalog=marketDB.bacpac;Integrated Security=True";
        SqlConnection baglan_urun = new SqlConnection(constring_urun);

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan_urun.State == ConnectionState.Closed)
                {
                    baglan_urun.Open();
                    string kayit = "insert into CustomerTB (customerName, customerTel, customerCardID) values(@customerName, @customerTel, @customerCardID)";

                    SqlCommand komut = new SqlCommand(kayit, baglan_urun);

                    komut.Parameters.AddWithValue("@customerName", textBox1.Text);
                    komut.Parameters.AddWithValue("@customerTel", textBox2.Text);
                    komut.Parameters.AddWithValue("@customerCardID", textBox3.Text);
                    //komut.Parameters.AddWithValue("@id", textBox6.Text);

                    if (textBox3.TextLength < 1)
                    {
                        MessageBox.Show("Şifreniz 4 hane veya daha büyük olmalıdır !");
                        textBox3.Focus();
                        baglan_urun.Close();
                    }
                    else if (textBox1.TextLength < 3 || textBox2.TextLength < 10)
                    {
                        MessageBox.Show("Geçerli değerler girin !");

                        baglan_urun.Close();
                    }

                    else
                    {
                        komut.ExecuteNonQuery();
                        baglan_urun.Close();

                        MessageBox.Show("kayıt ekleme başarılı");

                        temizle();
                    }

                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata adı: " + hata.Message);
            }
        }

        public void kayitlari_getir()
        {
            string getir = "Select * from CustomerTB";

            SqlCommand komut = new SqlCommand(getir, baglan_urun);
            SqlDataAdapter ad = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

            baglan_urun.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayitlari_getir();
        }

        int i = 0;

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            if (i >= 0)
            {
                textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            }
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            String kayit = "Select * from custoemrTB where customerName=@customerName";

            SqlCommand komut = new SqlCommand(kayit, baglan_urun);

            komut.Parameters.AddWithValue("@customerName", textBox4.Text);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan_urun.Close();

            temizle();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            temizle();
        }


        public void veriyisil(int id)
        {
            string sil = "Delete from customerTB where customerID = @customerID";

            SqlCommand komut = new SqlCommand(sil, baglan_urun);

            baglan_urun.Open();

            komut.Parameters.AddWithValue("@customerID", id);
            komut.ExecuteNonQuery();

            baglan_urun.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                veriyisil(id);
                temizle();
                kayitlari_getir();
            }
        }

        private void Musteri_Load(object sender, EventArgs e)
        {

        }
    }
}
