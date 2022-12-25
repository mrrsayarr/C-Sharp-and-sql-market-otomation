using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Market
{
    public partial class kasiyer : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SSD-CAT;Initial Catalog=marketDB.bacpac;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        public void listele()
        {
            da = new SqlDataAdapter("select * from Fis", con);

            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }
        public kasiyer()
        {
            InitializeComponent();
            
        }
        private void kasiyer_Load(object sender, EventArgs e)
        {
            listele();
            MessageBox.Show("dsa");
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into Fis(ÜrünID,ÜrünAdı,Fiyat,Miktar) values('" + int.Parse(ID.Text) + "','" + Adı.Text + "','" + int.Parse(Miktar.Text) * int.Parse(Fiyat.Text) + "','" + int.Parse(Miktar.Text) + "')", con);
            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();
            listele();
            hesapla();
        }

        private void SİL_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand("DELETE from Fis where ÜrünID = '" + int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()) + "'  ", con);
            //yada **
            //cmd = new SqlCommand("delete from Fis where ÜrünID='" + int.Parse(ID.Text) + "'", con);

            //cmd = new SqlCommand("DELETE from Fis where ÜrünID = '" + int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()) + "'  ", con);
            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();
            listele();
            hesapla();
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {
            if (ID.Text == "" || Convert.ToInt32(ID.Text) >= 200) foreach (Control item in Controls) if (item is System.Windows.Forms.TextBox) item.Text = "";

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from productTB where productID like '" + ID.Text + "' ", con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                Adı.Text = read["productName"].ToString();
                Fiyat.Text = read["productPrice"].ToString();
            }
            con.Close();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(imagebmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);

        }
        private void Yazdir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog(); // YAZICI GÖRMEZSE HATA VEREBİLİR VEYA PDF YAZICI!
        }

        private void hesapla()
        {
            //try
            //{
            //    con.Open();
            //    SqlCommand komut = new SqlCommand("Select sum(productPrice) from Fis", con);
            //    label7.Text = komut.ExecuteScalar() + " TL";
            //    con.Close();
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            label7.Text = sum.ToString();
        }

        private void Yazdir_Click_1(object sender, EventArgs e)
        {
           
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ID.Text = "32";
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ID.Text = "31";
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ID.Text = "30";
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ID.Text = "33";
        }
        private void kasiyer_Click(object sender, EventArgs e)
        {

        }
        private void X_Click(object sender, EventArgs e)
        {

        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sil = new SqlCommand("TRUNCATE TABLE Fis;", con);
            sil.ExecuteNonQuery();
            con.Close();

            Login login = new Login();
            login.Show();
            this.Hide();
            //Application.Exit();
        }

        private void label_Exit_MouseEnter(object sender, EventArgs e)
        {
            label_Exit.ForeColor = Color.Blue;
        }

        private void label_Exit_MouseLeave(object sender, EventArgs e)
        {
            label_Exit.ForeColor = Color.Red;
        }

        private void Ekle_MouseEnter(object sender, EventArgs e)
        {
            Ekle.ForeColor = Color.Gainsboro;
        }

        private void Ekle_MouseLeave(object sender, EventArgs e)
        {
            Ekle.ForeColor = Color.White;
        }

        private void SİL_MouseEnter(object sender, EventArgs e)
        {
            SİL.ForeColor = Color.Gainsboro;

        }

        private void SİL_MouseLeave(object sender, EventArgs e)
        {
            SİL.ForeColor = Color.White;
        }

        private void Yazdir_MouseEnter(object sender, EventArgs e)
        {
            Yazdir.ForeColor = Color.Gainsboro;

        }

        private void Yazdir_MouseLeave(object sender, EventArgs e)
        {
            Yazdir.ForeColor = Color.White;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void kasiyer_Load_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sil = new SqlCommand("TRUNCATE TABLE Fis;", con);
            sil.ExecuteNonQuery();
            con.Close();
            listele();
            hesapla();
        }

        private void Miktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.Show();
            //this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            // 1 
            ID.Text += label10.Text;
            //ID.Focus();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            // 2
            ID.Text += label11.Text;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            // 3
            ID.Text += label12.Text;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            // 4
            ID.Text += label13.Text;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            // 5
            ID.Text += label14.Text;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            // 6
            ID.Text += label15.Text;
        }

        private void label18_Click(object sender, EventArgs e)
        {
            // 7
            ID.Text += label18.Text;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            // 8
            ID.Text += label17.Text;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            // 9
            ID.Text += label16.Text;
        }

        private void label19_Click(object sender, EventArgs e)
        {
            // 0
            ID.Text += label19.Text;
        }

        private void label20_Click(object sender, EventArgs e)
        {
            // clear ID box
            ID.Text = "";
        }
        private void stok_takibi()
        {
            //String stok = "Select * from productTB where productPCS=@productPCS";

            //SqlCommand komut = new SqlCommand(stok, con);

            //komut.Parameters.AddWithValue("@productPCS", label21.Text);

            //SqlDataAdapter da = new SqlDataAdapter(komut);
            //DataTable dt = new DataTable();

            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //con.Close();
        }
    }
}
