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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void kullanıcıekle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=SSD-CAT;Initial Catalog=marketDB.bacpac;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into userTB (userName,userPass,usertype) values ('" + txtkullanıcıadı.Text + "','" + txtsifre.Text + "','" + comboBox1.Text + "' )", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kasiyer Başarıyla Eklendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=SSD-CAT;Initial Catalog=marketDB.bacpac;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from userTB where userName='" + txtkullanıcıadı.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kasiyer Başarıyla Silindi");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        static string constring = "Data Source=SSD-CAT;Initial Catalog=marketDB.bacpac;Integrated Security=True";
        SqlConnection baglan = new SqlConnection(constring);

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string kayit = "insert into userTB (userName, userTel, userMail, userPass ) values(@userName, @userTel, @userMail, @userPass )";

                    SqlCommand komut = new SqlCommand(kayit, baglan);

                    komut.Parameters.AddWithValue("@userName", textBox1.Text);
                    komut.Parameters.AddWithValue("@userTel", textBox2.Text);
                    komut.Parameters.AddWithValue("@userMail", textBox3.Text);
                    komut.Parameters.AddWithValue("@userPass", textBox4.Text);
                    //komut.Parameters.AddWithValue("@id", textBox6.Text);

                    if (textBox4.TextLength < 4)
                    {
                        MessageBox.Show("Şifreniz 4 hane veya daha büyük olmalıdır !");
                        textBox4.Focus();
                        baglan.Close();
                    }
                    else if (textBox1.TextLength < 3 || textBox2.TextLength < 2 || textBox3.TextLength < 6)
                    {
                        MessageBox.Show("Geçerli değerler girin !");

                        baglan.Close();
                    }

                    else
                    {
                        komut.ExecuteNonQuery();
                        baglan.Close();

                        btn_temizle_Click();

                        MessageBox.Show("kayıt ekleme başarılı");
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
            string getir = "Select * from userTB";

            SqlCommand komut = new SqlCommand(getir, baglan);
            SqlDataAdapter ad = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

            baglan.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kayitlari_getir();
        }

        public void btn_temizle_Click()
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btn_temizle_Click();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String kayit = "Select * from userTB where userName=@userName";

            SqlCommand komut = new SqlCommand(kayit, baglan);

            komut.Parameters.AddWithValue("@userName", textBox5.Text);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }

        public void veriyisil(int id)
        {
            string sil = "Delete from userTB where userID = @userID";

            SqlCommand komut = new SqlCommand(sil, baglan);

            baglan.Open();

            komut.Parameters.AddWithValue("@userID", id);
            komut.ExecuteNonQuery();

            baglan.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                veriyisil(id);
                kayitlari_getir();
            }
        }

        int i = 0;

        private void button5_Click(object sender, EventArgs e)
        {
            baglan.Open();

            string kayitguncelle = ("Update userTB set userName=@update_name, userPass=@update_userPass, userTel=@update_no, userMail=@userMail_update  where userID=@userID");

            SqlCommand komut = new SqlCommand(kayitguncelle, baglan);

            komut.Parameters.AddWithValue("@update_name", textBox1.Text);
            komut.Parameters.AddWithValue("@update_no", textBox2.Text);
            komut.Parameters.AddWithValue("@userMail_update", textBox3.Text);
            komut.Parameters.AddWithValue("@update_userPass", textBox4.Text);
            komut.Parameters.AddWithValue("userID", dataGridView1.Rows[i].Cells[0].Value);

            komut.ExecuteNonQuery();

            MessageBox.Show("kayıtlar başarıyla güncellendi");
            baglan.Close();
            kayitlari_getir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;

            textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

  