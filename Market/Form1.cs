
//using System;

//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using Microsoft.Data.SqlClient;
//using System.Windows.Forms;



//namespace WinFormsApp1
//{

   
//    public partial class Form1 : Form
//    {

//        SqlConnection con = new SqlConnection("Data source=DESKTOP-O82KITD; initial catalog = market; integrated security =sspi;TrustServerCertificate=True");
//        SqlCommand cmd;
//        SqlDataAdapter da;
//        void listele() {
            
//            da = new SqlDataAdapter("select * from Fis",con);
            
//            DataTable tablo= new DataTable();
//            da.Fill(tablo);
//            dataGridView1.DataSource= tablo;
           
//        }
//        public Form1()
//        {
//            InitializeComponent();
//        }

       

//        private void label_Exit_MouseEnter(object sender, EventArgs e)
//        {
//            label_Exit.ForeColor = Color.Blue;
//        }

//        private void label_Exit_MouseLeave(object sender, EventArgs e)
//        {
//            label_Exit.ForeColor = Color.Salmon;
//        }

//        private void label_Exit_MouseClick(object sender, MouseEventArgs e)
//        {
//            Application.Exit();
//        }

//        private void label_Exit_Click(object sender, EventArgs e)
//        {

//        }

//        private void label1_Click(object sender, EventArgs e)
//        {

//        }

       

//        private void pictureBox1_Click(object sender, EventArgs e)
//        {
//            ID.Text = "1";

//        }
//        private void pictureBox2_Click(object sender, EventArgs e)
//        {
//            ID.Text = "2";

//        }
//        private void pictureBox3_Click(object sender, EventArgs e)
//        {
//            ID.Text = "3";

//        }
//        private void pictureBox4_Click(object sender, EventArgs e)
//        {
//            ID.Text = "4";

//        }


//        private void Form1_Load(object sender, EventArgs e)
//        {
//            listele();
//        }

//        private void ID_TextChanged(object sender, EventArgs e)


//        {
            

//            if (ID.Text == ""|| Convert.ToInt32(ID.Text)>=6) foreach (Control item in Controls) if (item is TextBox) item.Text = "" ;
//            con.Open();
//            SqlCommand cmd = new SqlCommand("select * from ToplamSatis where StokÜrünID like '"+ID.Text+"' ",con);
//            SqlDataReader  read=cmd.ExecuteReader();
//            while (read.Read())
//            {
//                Adý.Text= read["StokÜrünAdý"].ToString();
//                Fiyat.Text = read["StokÜrünFiyat"].ToString();
                

//            }
//            con.Close();
//        }

//        private void Ekle_Click(object sender, EventArgs e)
//        {
//            cmd = new SqlCommand("insert into Fis(ÜrünID,ÜrünAdý,Fiyat,Miktar) values('" + int.Parse(ID.Text) + "','" + Adý.Text + "','" +  int.Parse(Miktar.Text) * int.Parse(Fiyat.Text) + "','" + int.Parse(Miktar.Text) + "')", con);
//            con.Open();

//            cmd.ExecuteNonQuery();
//            con.Close();
//            listele();
//        }

//        private void SÝL_Click(object sender, EventArgs e)
//        {
//            cmd = new SqlCommand("DELETE from Fis where ÜrünID = '" + int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()) + "'  ", con);
//            con.Open();
            
//            cmd.ExecuteNonQuery();
//            con.Close();    
//            listele();
//        }
//        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
//        {
//            Bitmap imagebmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
//            dataGridView1.DrawToBitmap(imagebmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
//            e.Graphics.DrawImage(imagebmp, 120, 20);
//        }
//        private void Yazdir_Click(object sender, EventArgs e)
//        {
//            printPreviewDialog1.Document = printDocument1;
//            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
//            printPreviewDialog1.ShowDialog();
//        }

        
//    }
//}