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
                    string kayit = "insert into userTB (userName, userTel, userMail, userPass, usertype ) values(@userName, @userTel, @userMail, @userPass, @usertype )";

                    SqlCommand komut = new SqlCommand(kayit, baglan);

                    komut.Parameters.AddWithValue("@userName", textBox1.Text);
                    komut.Parameters.AddWithValue("@userTel", textBox2.Text);
                    komut.Parameters.AddWithValue("@userMail", textBox3.Text);
                    komut.Parameters.AddWithValue("@userPass", textBox4.Text);
                    komut.Parameters.AddWithValue("@usertype", textBox13.Text);
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

                        MessageBox.Show("Kayıt ekleme başarılı");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
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
            dataGridView3.DataSource = dt;

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
            btn_temizle_Click(); // ÇALIŞMIYOR ?

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
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

            string kayitguncelle = ("Update userTB set " +
                "   userName=@update_name, " +
                "   userPass=@update_userPass, " +
                "   userTel=@update_no, " +
                "   userMail=@userMail_update, " +
                "   usertype=@update_usertype  " +
                "   where userID=@userID");

            SqlCommand komut = new SqlCommand(kayitguncelle, baglan);

            komut.Parameters.AddWithValue("@update_name", textBox1.Text);
            komut.Parameters.AddWithValue("@update_no", textBox2.Text);
            komut.Parameters.AddWithValue("@userMail_update", textBox3.Text);
            komut.Parameters.AddWithValue("@update_userPass", textBox4.Text);
            komut.Parameters.AddWithValue("@update_usertype", textBox13.Text);
            komut.Parameters.AddWithValue("userID", dataGridView1.Rows[i].Cells[0].Value);

            komut.ExecuteNonQuery();

            MessageBox.Show("kayıtlar başarıyla güncellendi");
            baglan.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox13.Text = "Kasiyer";

            kayitlari_getir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;

            textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();

        }

        private void button11_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }
  
        //ÇIKIŞ
        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        //ÜRÜN EKLEME
        static string constring_urun = "Data Source=SSD-CAT;Initial Catalog=marketDB.bacpac;Integrated Security=True";
        SqlConnection baglan_urun = new SqlConnection(constring_urun);
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        //ARAMA YAPMA **
        private void button16_Click(object sender, EventArgs e)
        {
            String kayit = "Select * from productTB where productName=@productName";

            SqlCommand komut = new SqlCommand(kayit, baglan_urun);

            komut.Parameters.AddWithValue("@productName", textBox12.Text);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView2.DataSource = dt;

            textBox12.Text = "";

            baglan_urun.Close();
        }

        //ÜRÜN SİLME FONKSİYONU
        public void urunu_sil(int id)
        {
            string sil = "Delete from productTB where productID = @productID";

            SqlCommand komut = new SqlCommand(sil, baglan_urun);

            baglan_urun.Open();

            komut.Parameters.AddWithValue("@productID", id);
            komut.ExecuteNonQuery();

            baglan_urun.Close();
        }

        // ÜRÜN SİLME GERÇEKLEŞTİRME
        private void button13_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView2.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                urunu_sil(id);

                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";

                urunleri_getir();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan_urun.State == ConnectionState.Closed)
                {
                    baglan_urun.Open();
                    string kayit = "insert into productTB (productName, productPrice, productPCS,  productBrand, kategoriID, tedarikID ) values(@productName, @productPrice, @productPCS, @productBrand, @kategoriID, @tedarikID )";

                    SqlCommand komut = new SqlCommand(kayit, baglan_urun);

                    komut.Parameters.AddWithValue("@productName", textBox6.Text);
                    komut.Parameters.AddWithValue("@productPrice", textBox7.Text);
                    komut.Parameters.AddWithValue("@productPCS", textBox8.Text);
                    komut.Parameters.AddWithValue("@productBrand", textBox9.Text);
                    komut.Parameters.AddWithValue("@kategoriID", textBox10.Text);
                    komut.Parameters.AddWithValue("@tedarikID", textBox11.Text);
                    komut.Parameters.AddWithValue("@id", textBox6.Text);

                    if (textBox6.TextLength < 3)
                    {
                        MessageBox.Show("doğru ürün girdiğinden emin olun. !");
                        textBox6.Focus();
                        baglan_urun.Close();
                    }
                    else if (textBox9.TextLength < 2 || textBox11.TextLength < 1)
                    {
                        MessageBox.Show("Geçerli değerler girin !");

                        baglan_urun.Close();

                    }

                    else
                    {
                        komut.ExecuteNonQuery();
                        baglan_urun.Close();

                        btn_temizle_Click();

                        MessageBox.Show("Ürün ekleme başarılı");

                        textBox6.Text = "";
                        textBox7.Text = "";
                        textBox8.Text = "";
                        textBox9.Text = "";
                    }

                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata adı: " + hata.Message);
            }
        }

        // ÜRÜNLERİ GETİR FONKSİYONU
        public void urunleri_getir()
        {
            string getir = "Select * from productTB";

            SqlCommand komut = new SqlCommand(getir, baglan_urun);
            SqlDataAdapter ad = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView2.DataSource = dt;

            baglan_urun.Close();
        }
        private void button17_Click(object sender, EventArgs e)
        {
            urunleri_getir(); // BUTONLA ÜRÜNLERİ GETİR FONKİSYONUNU ÇAĞIRIR
        }

        // DATAGRİDVİEW2 YE BİLGİLERİ SIRALAMA
        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //this.dataGridView2.Columns["productName"].SortMode = DataGridViewColumnSortMode.Automatic;
            i = e.RowIndex;

            textBox6.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            textBox7.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            textBox8.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
            textBox9.Text = dataGridView2.Rows[i].Cells[4].Value.ToString();
            textBox10.Text = dataGridView2.Rows[i].Cells[5].Value.ToString();
            textBox11.Text = dataGridView2.Rows[i].Cells[6].Value.ToString();



        }
        public void form_temizle_Click()
        {
            // BU FONKSİYONU ÇAĞIRARAK DAHA KISA SÜREDE FORM TEMİZLENİR. 
            // ÇALIŞMIYOR ??
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";
            }
        }

        // ÇALIŞMAYAN BUTON TEMİZLEME FONKSİYONU İÇİN TEMİZLEME KODLARI
        // HER BUTON İÇİN TEMİZLEME KODLARINI TEKER TEKER YAZMAK GEREKİR.
        private void button15_Click(object sender, EventArgs e)
        {
            textBox4.Text  =  "";
            textBox5.Text  =  "";
            textBox6.Text  =  "";
            textBox7.Text  =  "";
            textBox8.Text  =  "";
            textBox9.Text  =  "";
            textBox12.Text =  "";

        }

        // VAR OLAN BİR KAYDI GÜNCELLEME
        private void button14_Click(object sender, EventArgs e)
        {
            baglan_urun.Open();

            //komut.Parameters.AddWithValue("@productName", textBox6.Text);
            //komut.Parameters.AddWithValue("@productPrice", textBox7.Text);
            //komut.Parameters.AddWithValue("@productPCS", textBox8.Text);
            //komut.Parameters.AddWithValue("@productBrand", textBox9.Text);
            //komut.Parameters.AddWithValue("@kategoriID", textBox10.Text);
            //komut.Parameters.AddWithValue("@tedarikID", textBox11.Text);
            //komut.Parameters.AddWithValue("@id", textBox6.Text);

            string kayitguncelle = ("Update productTB set " +
                "   productName=@update_productName, " +
                "   productPrice=@update_productPrice, " +
                "   productPCS=@update_productPCS, " +
                "   productBrand=@update_productBrand, " +
                "   kategoriID=@update_kategoriID, " +
                "   tedarikID=@update_tedarikID  " +
                "   where productID=@productID");

            SqlCommand komut = new SqlCommand(kayitguncelle, baglan_urun);

            komut.Parameters.AddWithValue("@update_productName", textBox6.Text);
            komut.Parameters.AddWithValue("@update_productPrice", textBox7.Text);
            komut.Parameters.AddWithValue("@update_productPCS", textBox8.Text);
            komut.Parameters.AddWithValue("@update_productBrand", textBox9.Text);
            komut.Parameters.AddWithValue("@update_kategoriID", textBox10.Text);
            komut.Parameters.AddWithValue("@update_tedarikID", textBox11.Text);
            komut.Parameters.AddWithValue("productID", dataGridView2.Rows[i].Cells[0].Value);

            komut.ExecuteNonQuery();

            MessageBox.Show("kayıtlar başarıyla güncellendi");

            // ÜRÜN GÜNCELLENDİKTEN SONRA FORM TEMİZLENİR.
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";

            baglan_urun.Close(); // BAĞLANTIYI KAPATIR
            kayitlari_getir();  // ÜRÜNLERİ TEKRAR GETİRİR
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            i = e.RowIndex;

            textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
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

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string kayit = "insert into userTB (userName, userTel, userMail, userPass, usertype ) values(@userName, @userTel, @userMail, @userPass, @usertype )";

                    SqlCommand komut = new SqlCommand(kayit, baglan);

                    komut.Parameters.AddWithValue("@userName", textBox16.Text);
                    komut.Parameters.AddWithValue("@userTel", textBox17.Text);
                    komut.Parameters.AddWithValue("@userMail", textBox18.Text);
                    komut.Parameters.AddWithValue("@userPass", textBox15.Text);
                    komut.Parameters.AddWithValue("@usertype", textBox14.Text);
                    //komut.Parameters.AddWithValue("@id", textBox6.Text);

                    if (textBox15.TextLength < 4)
                    {
                        MessageBox.Show("Şifre en az 4 hane veya daha büyük olmalıdır !");
                        textBox4.Focus();
                        baglan.Close();
                    }
                    else if (textBox17.TextLength < 3 || textBox16.TextLength < 2 || textBox18.TextLength < 6)
                    {
                        MessageBox.Show("Geçerli değerler girin !");

                        baglan.Close();
                    }

                    else
                    {
                        komut.ExecuteNonQuery();
                        baglan.Close();

                        btn_temizle_Click();

                        MessageBox.Show("Kayıt ekleme başarılı");
                        textBox17.Text = "";
                        textBox18.Text = "";
                        textBox16.Text = "";
                        textBox15.Text = "";
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata adı: " + hata.Message);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            kayitlari_getir();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox17.Text = "";
            textBox18.Text = "";
            textBox16.Text = "";
            textBox15.Text = "";
        }

        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;

            textBox16.Text = dataGridView3.Rows[i].Cells[1].Value.ToString();
            textBox17.Text = dataGridView3.Rows[i].Cells[4].Value.ToString();
            textBox18.Text = dataGridView3.Rows[i].Cells[7].Value.ToString();
            textBox15.Text = dataGridView3.Rows[i].Cells[5].Value.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            baglan.Open();

            string kayitguncelle = ("Update userTB set " +
                "   userName=@update_name, " +
                "   userPass=@update_userPass, " +
                "   userTel=@update_no, " +
                "   userMail=@userMail_update, " +
                "   usertype=@update_usertype  where userID=@userID");

            SqlCommand komut = new SqlCommand(kayitguncelle, baglan);

            komut.Parameters.AddWithValue("@update_name", textBox16.Text);
            komut.Parameters.AddWithValue("@update_no", textBox17.Text);
            komut.Parameters.AddWithValue("@userMail_update", textBox18.Text);
            komut.Parameters.AddWithValue("@update_userPass", textBox15.Text);
            komut.Parameters.AddWithValue("@update_usertype", textBox14.Text);
            komut.Parameters.AddWithValue("userID", dataGridView3.Rows[i].Cells[0].Value);

            komut.ExecuteNonQuery();

            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox14.Text = "Yönetici";

            MessageBox.Show("Kayıtlar başarıyla güncellendi");
            baglan.Close();
            kayitlari_getir();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                veriyisil(id);

                textBox15.Text = "";
                textBox16.Text = "";
                textBox17.Text = "";
                textBox18.Text = "";

                kayitlari_getir();
            }
        }
    }
}

  