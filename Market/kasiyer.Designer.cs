namespace Market
{
    partial class kasiyer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kasiyer));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Adı = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.Miktar = new System.Windows.Forms.TextBox();
            this.Fiyat = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Ekle = new System.Windows.Forms.Label();
            this.SİL = new System.Windows.Forms.Label();
            this.Yazdir = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printDocument3 = new System.Drawing.Printing.PrintDocument();
            this.printDocument4 = new System.Drawing.Printing.PrintDocument();
            this.printDocument5 = new System.Drawing.Printing.PrintDocument();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label_Exit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Miktar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fiyat :";
            // 
            // Adı
            // 
            this.Adı.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Adı.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.Adı.Location = new System.Drawing.Point(176, 93);
            this.Adı.Margin = new System.Windows.Forms.Padding(2);
            this.Adı.Name = "Adı";
            this.Adı.Size = new System.Drawing.Size(172, 31);
            this.Adı.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ID.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.ID.Location = new System.Drawing.Point(176, 150);
            this.ID.Margin = new System.Windows.Forms.Padding(2);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(172, 31);
            this.ID.TabIndex = 1;
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            this.ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // Miktar
            // 
            this.Miktar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Miktar.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.Miktar.Location = new System.Drawing.Point(176, 209);
            this.Miktar.Margin = new System.Windows.Forms.Padding(2);
            this.Miktar.Name = "Miktar";
            this.Miktar.Size = new System.Drawing.Size(172, 31);
            this.Miktar.TabIndex = 1;
            this.Miktar.Text = "1";
            this.Miktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Miktar_KeyPress);
            // 
            // Fiyat
            // 
            this.Fiyat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Fiyat.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.Fiyat.Location = new System.Drawing.Point(176, 267);
            this.Fiyat.Margin = new System.Windows.Forms.Padding(2);
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Size = new System.Drawing.Size(172, 31);
            this.Fiyat.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(368, 68);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(452, 327);
            this.dataGridView1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(447, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 35);
            this.label5.TabIndex = 3;
            this.label5.Text = "KASİYER YÖNETİM";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Ekle
            // 
            this.Ekle.AutoSize = true;
            this.Ekle.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.Ekle.ForeColor = System.Drawing.Color.White;
            this.Ekle.Location = new System.Drawing.Point(51, 318);
            this.Ekle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(103, 41);
            this.Ekle.TabIndex = 4;
            this.Ekle.Text = "EKLE";
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            this.Ekle.MouseEnter += new System.EventHandler(this.Ekle_MouseEnter);
            this.Ekle.MouseLeave += new System.EventHandler(this.Ekle_MouseLeave);
            // 
            // SİL
            // 
            this.SİL.AutoSize = true;
            this.SİL.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.SİL.ForeColor = System.Drawing.Color.White;
            this.SİL.Location = new System.Drawing.Point(234, 318);
            this.SİL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SİL.Name = "SİL";
            this.SİL.Size = new System.Drawing.Size(75, 41);
            this.SİL.TabIndex = 4;
            this.SİL.Text = "SİL";
            this.SİL.Click += new System.EventHandler(this.SİL_Click);
            this.SİL.MouseEnter += new System.EventHandler(this.SİL_MouseEnter);
            this.SİL.MouseLeave += new System.EventHandler(this.SİL_MouseLeave);
            // 
            // Yazdir
            // 
            this.Yazdir.AutoSize = true;
            this.Yazdir.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.Yazdir.ForeColor = System.Drawing.Color.White;
            this.Yazdir.Location = new System.Drawing.Point(108, 392);
            this.Yazdir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Yazdir.Name = "Yazdir";
            this.Yazdir.Size = new System.Drawing.Size(152, 41);
            this.Yazdir.TabIndex = 4;
            this.Yazdir.Text = "YAZDIR";
            this.Yazdir.Click += new System.EventHandler(this.Yazdir_Click);
            this.Yazdir.MouseEnter += new System.EventHandler(this.Yazdir_MouseEnter);
            this.Yazdir.MouseLeave += new System.EventHandler(this.Yazdir_MouseLeave);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument3
            // 
            this.printDocument3.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDocument4
            // 
            this.printDocument4.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDocument5
            // 
            this.printDocument5.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(862, 75);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1024, 75);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 174);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(862, 272);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(136, 176);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1024, 272);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(136, 176);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label_Exit
            // 
            this.label_Exit.AutoSize = true;
            this.label_Exit.Font = new System.Drawing.Font("Segoe UI", 25.22F, System.Drawing.FontStyle.Bold);
            this.label_Exit.ForeColor = System.Drawing.Color.Red;
            this.label_Exit.Location = new System.Drawing.Point(1152, -3);
            this.label_Exit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Exit.Name = "label_Exit";
            this.label_Exit.Size = new System.Drawing.Size(42, 46);
            this.label_Exit.TabIndex = 6;
            this.label_Exit.Text = "X";
            this.label_Exit.Click += new System.EventHandler(this.label_Exit_Click);
            this.label_Exit.MouseEnter += new System.EventHandler(this.label_Exit_MouseEnter);
            this.label_Exit.MouseLeave += new System.EventHandler(this.label_Exit_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(405, 422);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 41);
            this.label6.TabIndex = 7;
            this.label6.Text = "TOPLAM TUTAR:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(695, 422);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 41);
            this.label7.TabIndex = 8;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(104, 465);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "FİŞİ TEMİZLE";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // kasiyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1192, 499);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_Exit);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Yazdir);
            this.Controls.Add(this.SİL);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Fiyat);
            this.Controls.Add(this.Miktar);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Adı);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "kasiyer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kasiyer";
            this.Load += new System.EventHandler(this.kasiyer_Load_1);
            this.Click += new System.EventHandler(this.kasiyer_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Adı;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Miktar;
        private System.Windows.Forms.TextBox Fiyat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Ekle;
        private System.Windows.Forms.Label SİL;
        private System.Windows.Forms.Label Yazdir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Drawing.Printing.PrintDocument printDocument3;
        private System.Drawing.Printing.PrintDocument printDocument4;
        private System.Drawing.Printing.PrintDocument printDocument5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label_Exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}