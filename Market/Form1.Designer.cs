//namespace WinFormsApp1
//{
//    partial class Form1
//    {
//        /// <summary>
//        ///  Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        ///  Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        ///  Required method for Designer support - do not modify
//        ///  the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
//            this.label_Exit = new System.Windows.Forms.Label();
//            this.label1 = new System.Windows.Forms.Label();
//            this.Adı = new System.Windows.Forms.TextBox();
//            this.label2 = new System.Windows.Forms.Label();
//            this.ID = new System.Windows.Forms.TextBox();
//            this.label3 = new System.Windows.Forms.Label();
//            this.Kategori = new System.Windows.Forms.TextBox();
//            this.label4 = new System.Windows.Forms.Label();
//            this.Miktar = new System.Windows.Forms.TextBox();
//            this.dataGridView1 = new System.Windows.Forms.DataGridView();
//            this.label5 = new System.Windows.Forms.Label();
//            this.pictureBox1 = new System.Windows.Forms.PictureBox();
//            this.pictureBox2 = new System.Windows.Forms.PictureBox();
//            this.pictureBox3 = new System.Windows.Forms.PictureBox();
//            this.pictureBox4 = new System.Windows.Forms.PictureBox();
//            this.label6 = new System.Windows.Forms.Label();
//            this.Fiyat = new System.Windows.Forms.TextBox();
//            this.Ekle = new System.Windows.Forms.Button();
//            this.SİL = new System.Windows.Forms.Button();
//            this.Yazdir = new System.Windows.Forms.Button();
//            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
//            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // label_Exit
//            // 
//            this.label_Exit.AutoSize = true;
//            this.label_Exit.BackColor = System.Drawing.Color.LightSkyBlue;
//            this.label_Exit.Font = new System.Drawing.Font("Segoe UI", 25.22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
//            this.label_Exit.ForeColor = System.Drawing.Color.Salmon;
//            this.label_Exit.Location = new System.Drawing.Point(1251, 22);
//            this.label_Exit.Name = "label_Exit";
//            this.label_Exit.Size = new System.Drawing.Size(53, 59);
//            this.label_Exit.TabIndex = 0;
//            this.label_Exit.Text = "X";
//            this.label_Exit.Click += new System.EventHandler(this.label_Exit_Click);
//            this.label_Exit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_Exit_MouseClick);
//            this.label_Exit.MouseEnter += new System.EventHandler(this.label_Exit_MouseEnter);
//            this.label_Exit.MouseLeave += new System.EventHandler(this.label_Exit_MouseLeave);
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
//            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
//            this.label1.ForeColor = System.Drawing.Color.White;
//            this.label1.Location = new System.Drawing.Point(37, 161);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(188, 41);
//            this.label1.TabIndex = 1;
//            this.label1.Text = "Ürün Adı :";
//            this.label1.Click += new System.EventHandler(this.label1_Click);
//            // 
//            // Adı
//            // 
//            this.Adı.BorderStyle = System.Windows.Forms.BorderStyle.None;
//            this.Adı.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
//            this.Adı.Location = new System.Drawing.Point(220, 164);
//            this.Adı.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            this.Adı.Name = "Adı";
//            this.Adı.Size = new System.Drawing.Size(210, 38);
//            this.Adı.TabIndex = 2;
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
//            this.label2.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
//            this.label2.ForeColor = System.Drawing.Color.White;
//            this.label2.Location = new System.Drawing.Point(37, 216);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(176, 41);
//            this.label2.TabIndex = 1;
//            this.label2.Text = "Ürün ID :";
//            this.label2.Click += new System.EventHandler(this.label1_Click);
//            // 
//            // ID
//            // 
//            this.ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
//            this.ID.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
//            this.ID.Location = new System.Drawing.Point(219, 219);
//            this.ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            this.ID.Name = "ID";
//            this.ID.Size = new System.Drawing.Size(210, 38);
//            this.ID.TabIndex = 2;
//            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
//            // 
//            // label3
//            // 
//            this.label3.AutoSize = true;
//            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
//            this.label3.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
//            this.label3.ForeColor = System.Drawing.Color.White;
//            this.label3.Location = new System.Drawing.Point(37, 269);
//            this.label3.Name = "label3";
//            this.label3.Size = new System.Drawing.Size(185, 41);
//            this.label3.TabIndex = 1;
//            this.label3.Text = "Kategori :";
//            this.label3.Click += new System.EventHandler(this.label1_Click);
//            // 
//            // Kategori
//            // 
//            this.Kategori.BorderStyle = System.Windows.Forms.BorderStyle.None;
//            this.Kategori.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
//            this.Kategori.Location = new System.Drawing.Point(220, 272);
//            this.Kategori.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            this.Kategori.Name = "Kategori";
//            this.Kategori.Size = new System.Drawing.Size(210, 38);
//            this.Kategori.TabIndex = 2;
//            // 
//            // label4
//            // 
//            this.label4.AutoSize = true;
//            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
//            this.label4.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
//            this.label4.ForeColor = System.Drawing.Color.White;
//            this.label4.Location = new System.Drawing.Point(37, 323);
//            this.label4.Name = "label4";
//            this.label4.Size = new System.Drawing.Size(139, 41);
//            this.label4.TabIndex = 1;
//            this.label4.Text = "Miktar:";
//            this.label4.Click += new System.EventHandler(this.label1_Click);
//            // 
//            // Miktar
//            // 
//            this.Miktar.BorderStyle = System.Windows.Forms.BorderStyle.None;
//            this.Miktar.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
//            this.Miktar.Location = new System.Drawing.Point(220, 326);
//            this.Miktar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            this.Miktar.Name = "Miktar";
//            this.Miktar.Size = new System.Drawing.Size(210, 38);
//            this.Miktar.TabIndex = 2;
//            this.Miktar.Text = "1";
//            // 
//            // dataGridView1
//            // 
//            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
//            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
//            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dataGridView1.Location = new System.Drawing.Point(458, 105);
//            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            this.dataGridView1.Name = "dataGridView1";
//            this.dataGridView1.RowHeadersWidth = 51;
//            this.dataGridView1.RowTemplate.Height = 25;
//            this.dataGridView1.Size = new System.Drawing.Size(558, 472);
//            this.dataGridView1.TabIndex = 4;
//            // 
//            // label5
//            // 
//            this.label5.AutoSize = true;
//            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
//            this.label5.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
//            this.label5.ForeColor = System.Drawing.Color.White;
//            this.label5.Location = new System.Drawing.Point(413, 18);
//            this.label5.Name = "label5";
//            this.label5.Size = new System.Drawing.Size(509, 60);
//            this.label5.TabIndex = 5;
//            this.label5.Text = "KASİYER YÖNETİM";
//            // 
//            // pictureBox1
//            // 
//            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
//            this.pictureBox1.Location = new System.Drawing.Point(1045, 148);
//            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            this.pictureBox1.Name = "pictureBox1";
//            this.pictureBox1.Size = new System.Drawing.Size(95, 191);
//            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
//            this.pictureBox1.TabIndex = 7;
//            this.pictureBox1.TabStop = false;
//            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
//            // 
//            // pictureBox2
//            // 
//            this.pictureBox2.Image = global::WinFormsApp1.Properties.Resources.pngwing_com__1_;
//            this.pictureBox2.Location = new System.Drawing.Point(1175, 148);
//            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            this.pictureBox2.Name = "pictureBox2";
//            this.pictureBox2.Size = new System.Drawing.Size(106, 191);
//            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
//            this.pictureBox2.TabIndex = 7;
//            this.pictureBox2.TabStop = false;
//            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
//            // 
//            // pictureBox3
//            // 
//            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
//            this.pictureBox3.Location = new System.Drawing.Point(1045, 377);
//            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            this.pictureBox3.Name = "pictureBox3";
//            this.pictureBox3.Size = new System.Drawing.Size(95, 192);
//            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
//            this.pictureBox3.TabIndex = 7;
//            this.pictureBox3.TabStop = false;
//            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
//            // 
//            // pictureBox4
//            // 
//            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
//            this.pictureBox4.Location = new System.Drawing.Point(1175, 377);
//            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            this.pictureBox4.Name = "pictureBox4";
//            this.pictureBox4.Size = new System.Drawing.Size(106, 192);
//            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
//            this.pictureBox4.TabIndex = 7;
//            this.pictureBox4.TabStop = false;
//            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
//            // 
//            // label6
//            // 
//            this.label6.AutoSize = true;
//            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
//            this.label6.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
//            this.label6.ForeColor = System.Drawing.Color.White;
//            this.label6.Location = new System.Drawing.Point(37, 374);
//            this.label6.Name = "label6";
//            this.label6.Size = new System.Drawing.Size(114, 41);
//            this.label6.TabIndex = 1;
//            this.label6.Text = "Fiyat:";
//            this.label6.Click += new System.EventHandler(this.label1_Click);
//            // 
//            // Fiyat
//            // 
//            this.Fiyat.BorderStyle = System.Windows.Forms.BorderStyle.None;
//            this.Fiyat.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
//            this.Fiyat.Location = new System.Drawing.Point(220, 377);
//            this.Fiyat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            this.Fiyat.Name = "Fiyat";
//            this.Fiyat.Size = new System.Drawing.Size(210, 38);
//            this.Fiyat.TabIndex = 2;
//            // 
//            // Ekle
//            // 
//            this.Ekle.BackColor = System.Drawing.Color.LightSkyBlue;
//            this.Ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
//            this.Ekle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
//            this.Ekle.FlatAppearance.BorderSize = 0;
//            this.Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.Ekle.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
//            this.Ekle.ForeColor = System.Drawing.Color.White;
//            this.Ekle.Location = new System.Drawing.Point(57, 448);
//            this.Ekle.Name = "Ekle";
//            this.Ekle.Size = new System.Drawing.Size(131, 63);
//            this.Ekle.TabIndex = 8;
//            this.Ekle.Text = "EKLE";
//            this.Ekle.UseVisualStyleBackColor = false;
//            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
//            // 
//            // SİL
//            // 
//            this.SİL.FlatAppearance.BorderSize = 0;
//            this.SİL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.SİL.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
//            this.SİL.ForeColor = System.Drawing.Color.White;
//            this.SİL.Location = new System.Drawing.Point(252, 450);
//            this.SİL.Name = "SİL";
//            this.SİL.Size = new System.Drawing.Size(120, 61);
//            this.SİL.TabIndex = 9;
//            this.SİL.Text = "SİL";
//            this.SİL.UseVisualStyleBackColor = false;
//            this.SİL.Click += new System.EventHandler(this.SİL_Click);
//            // 
//            // Yazdir
//            // 
//            this.Yazdir.BackColor = System.Drawing.Color.LightSkyBlue;
//            this.Yazdir.FlatAppearance.BorderSize = 0;
//            this.Yazdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.Yazdir.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
//            this.Yazdir.ForeColor = System.Drawing.Color.White;
//            this.Yazdir.Location = new System.Drawing.Point(122, 542);
//            this.Yazdir.Name = "Yazdir";
//            this.Yazdir.Size = new System.Drawing.Size(190, 69);
//            this.Yazdir.TabIndex = 10;
//            this.Yazdir.Text = "YAZDIR";
//            this.Yazdir.UseVisualStyleBackColor = false;
//            this.Yazdir.Click += new System.EventHandler(this.Yazdir_Click);
//            // 
//            // printDocument1
//            // 
//            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
//            // 
//            // printPreviewDialog1
//            // 
//            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
//            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
//            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
//            this.printPreviewDialog1.Enabled = true;
//            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
//            this.printPreviewDialog1.Name = "printPreviewDialog1";
//            this.printPreviewDialog1.Visible = false;
//            // 
//            // Form1
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackColor = System.Drawing.Color.LightSkyBlue;
//            this.ClientSize = new System.Drawing.Size(1340, 668);
//            this.Controls.Add(this.Yazdir);
//            this.Controls.Add(this.SİL);
//            this.Controls.Add(this.Ekle);
//            this.Controls.Add(this.pictureBox4);
//            this.Controls.Add(this.pictureBox3);
//            this.Controls.Add(this.pictureBox2);
//            this.Controls.Add(this.pictureBox1);
//            this.Controls.Add(this.label5);
//            this.Controls.Add(this.dataGridView1);
//            this.Controls.Add(this.Fiyat);
//            this.Controls.Add(this.label6);
//            this.Controls.Add(this.Miktar);
//            this.Controls.Add(this.label4);
//            this.Controls.Add(this.Kategori);
//            this.Controls.Add(this.label3);
//            this.Controls.Add(this.ID);
//            this.Controls.Add(this.label2);
//            this.Controls.Add(this.Adı);
//            this.Controls.Add(this.label1);
//            this.Controls.Add(this.label_Exit);
//            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
//            this.Name = "Form1";
//            this.Text = "Form1";
//            this.Load += new System.EventHandler(this.Form1_Load);
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private Label label_Exit;
//        private Label label1;
//        private TextBox Adı;
//        private Label label2;
//        private TextBox ID;
//        private Label label3;
//        private TextBox Kategori;
//        private Label label4;
//        private TextBox Miktar;
//        private DataGridView dataGridView1;
//        private Label label5;
//        private PictureBox pictureBox1;
//        private PictureBox pictureBox2;
//        private PictureBox pictureBox3;
//        private PictureBox pictureBox4;
//        private Label label6;
//        private TextBox Fiyat;
//        private Button Ekle;
//        private Button SİL;
//        private Button Yazdir;
//        private System.Drawing.Printing.PrintDocument printDocument1;
//        private PrintPreviewDialog printPreviewDialog1;
//    }
//}