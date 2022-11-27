
namespace SchoolDemo_MertSOLAK
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonIptal = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonEgitmenAta = new System.Windows.Forms.Button();
            this.textBoxEgitmenSoyad = new System.Windows.Forms.TextBox();
            this.comboBoxEgitmenBrans = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEgitmenAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSinifOlustur = new System.Windows.Forms.Button();
            this.comboBoxSube = new System.Windows.Forms.ComboBox();
            this.comboBoxBolum = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSinifNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxOgrenciAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonOgrenciEkle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxOgrenciAdres = new System.Windows.Forms.TextBox();
            this.textBoxOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.listBoxOgrenciler = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonIptal);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(908, 561);
            this.splitContainer1.SplitterDistance = 248;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonIptal
            // 
            this.buttonIptal.Enabled = false;
            this.buttonIptal.Location = new System.Drawing.Point(59, 402);
            this.buttonIptal.Name = "buttonIptal";
            this.buttonIptal.Size = new System.Drawing.Size(108, 103);
            this.buttonIptal.TabIndex = 2;
            this.buttonIptal.Text = "Eğitmen, Öğrenci Atama İptal";
            this.buttonIptal.UseVisualStyleBackColor = true;
            this.buttonIptal.Click += new System.EventHandler(this.buttonIptal_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonEgitmenAta);
            this.groupBox2.Controls.Add(this.textBoxEgitmenSoyad);
            this.groupBox2.Controls.Add(this.comboBoxEgitmenBrans);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxEgitmenAd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(10, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sınıf Eğitmeni Ata";
            // 
            // buttonEgitmenAta
            // 
            this.buttonEgitmenAta.Location = new System.Drawing.Point(10, 98);
            this.buttonEgitmenAta.Name = "buttonEgitmenAta";
            this.buttonEgitmenAta.Size = new System.Drawing.Size(204, 30);
            this.buttonEgitmenAta.TabIndex = 4;
            this.buttonEgitmenAta.Text = "Sınıf Eğitmeni Ata";
            this.buttonEgitmenAta.UseVisualStyleBackColor = true;
            this.buttonEgitmenAta.Click += new System.EventHandler(this.buttonEgitmenAta_Click);
            // 
            // textBoxEgitmenSoyad
            // 
            this.textBoxEgitmenSoyad.Location = new System.Drawing.Point(49, 45);
            this.textBoxEgitmenSoyad.Name = "textBoxEgitmenSoyad";
            this.textBoxEgitmenSoyad.Size = new System.Drawing.Size(166, 20);
            this.textBoxEgitmenSoyad.TabIndex = 2;
            // 
            // comboBoxEgitmenBrans
            // 
            this.comboBoxEgitmenBrans.FormattingEnabled = true;
            this.comboBoxEgitmenBrans.Location = new System.Drawing.Point(49, 71);
            this.comboBoxEgitmenBrans.Name = "comboBoxEgitmenBrans";
            this.comboBoxEgitmenBrans.Size = new System.Drawing.Size(166, 21);
            this.comboBoxEgitmenBrans.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Soyad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Branş";
            // 
            // textBoxEgitmenAd
            // 
            this.textBoxEgitmenAd.Location = new System.Drawing.Point(48, 19);
            this.textBoxEgitmenAd.Name = "textBoxEgitmenAd";
            this.textBoxEgitmenAd.Size = new System.Drawing.Size(166, 20);
            this.textBoxEgitmenAd.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSinifOlustur);
            this.groupBox1.Controls.Add(this.comboBoxSube);
            this.groupBox1.Controls.Add(this.comboBoxBolum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxSinifNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sınıf";
            // 
            // buttonSinifOlustur
            // 
            this.buttonSinifOlustur.Location = new System.Drawing.Point(9, 100);
            this.buttonSinifOlustur.Name = "buttonSinifOlustur";
            this.buttonSinifOlustur.Size = new System.Drawing.Size(204, 30);
            this.buttonSinifOlustur.TabIndex = 4;
            this.buttonSinifOlustur.Text = "Sınıf Oluştur";
            this.buttonSinifOlustur.UseVisualStyleBackColor = true;
            this.buttonSinifOlustur.Click += new System.EventHandler(this.buttonSinifOlustur_Click);
            // 
            // comboBoxSube
            // 
            this.comboBoxSube.FormattingEnabled = true;
            this.comboBoxSube.Location = new System.Drawing.Point(49, 73);
            this.comboBoxSube.Name = "comboBoxSube";
            this.comboBoxSube.Size = new System.Drawing.Size(166, 21);
            this.comboBoxSube.TabIndex = 3;
            // 
            // comboBoxBolum
            // 
            this.comboBoxBolum.FormattingEnabled = true;
            this.comboBoxBolum.Location = new System.Drawing.Point(49, 47);
            this.comboBoxBolum.Name = "comboBoxBolum";
            this.comboBoxBolum.Size = new System.Drawing.Size(166, 21);
            this.comboBoxBolum.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Şube";
            // 
            // textBoxSinifNo
            // 
            this.textBoxSinifNo.Location = new System.Drawing.Point(49, 20);
            this.textBoxSinifNo.Name = "textBoxSinifNo";
            this.textBoxSinifNo.Size = new System.Drawing.Size(166, 20);
            this.textBoxSinifNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bölüm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sınıf No";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Panel2.Controls.Add(this.listBoxOgrenciler);
            this.splitContainer2.Size = new System.Drawing.Size(656, 561);
            this.splitContainer2.SplitterDistance = 375;
            this.splitContainer2.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(652, 371);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sınıf Adı";
            this.columnHeader1.Width = 122;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Öğrenci Sayısı";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sınıf Eğitmeni";
            this.columnHeader3.Width = 204;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxOgrenciAd);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.buttonOgrenciEkle);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxOgrenciAdres);
            this.groupBox3.Controls.Add(this.textBoxOgrenciSoyad);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(37, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 134);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Öğrenci Ekle";
            // 
            // textBoxOgrenciAd
            // 
            this.textBoxOgrenciAd.Location = new System.Drawing.Point(47, 19);
            this.textBoxOgrenciAd.Name = "textBoxOgrenciAd";
            this.textBoxOgrenciAd.Size = new System.Drawing.Size(166, 20);
            this.textBoxOgrenciAd.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Soyad";
            // 
            // buttonOgrenciEkle
            // 
            this.buttonOgrenciEkle.Location = new System.Drawing.Point(10, 94);
            this.buttonOgrenciEkle.Name = "buttonOgrenciEkle";
            this.buttonOgrenciEkle.Size = new System.Drawing.Size(204, 30);
            this.buttonOgrenciEkle.TabIndex = 4;
            this.buttonOgrenciEkle.Text = "Öğrenci Ekle";
            this.buttonOgrenciEkle.UseVisualStyleBackColor = true;
            this.buttonOgrenciEkle.Click += new System.EventHandler(this.buttonOgrenciEkle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Adres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ad";
            // 
            // textBoxOgrenciAdres
            // 
            this.textBoxOgrenciAdres.Location = new System.Drawing.Point(48, 71);
            this.textBoxOgrenciAdres.Name = "textBoxOgrenciAdres";
            this.textBoxOgrenciAdres.Size = new System.Drawing.Size(166, 20);
            this.textBoxOgrenciAdres.TabIndex = 2;
            // 
            // textBoxOgrenciSoyad
            // 
            this.textBoxOgrenciSoyad.Location = new System.Drawing.Point(48, 45);
            this.textBoxOgrenciSoyad.Name = "textBoxOgrenciSoyad";
            this.textBoxOgrenciSoyad.Size = new System.Drawing.Size(166, 20);
            this.textBoxOgrenciSoyad.TabIndex = 2;
            // 
            // listBoxOgrenciler
            // 
            this.listBoxOgrenciler.FormattingEnabled = true;
            this.listBoxOgrenciler.Location = new System.Drawing.Point(320, 8);
            this.listBoxOgrenciler.Name = "listBoxOgrenciler";
            this.listBoxOgrenciler.Size = new System.Drawing.Size(322, 160);
            this.listBoxOgrenciler.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 561);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxSube;
        private System.Windows.Forms.ComboBox comboBoxBolum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSinifNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEgitmenSoyad;
        private System.Windows.Forms.ComboBox comboBoxEgitmenBrans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEgitmenAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSinifOlustur;
        private System.Windows.Forms.Button buttonEgitmenAta;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListBox listBoxOgrenciler;
        private System.Windows.Forms.Button buttonOgrenciEkle;
        private System.Windows.Forms.TextBox textBoxOgrenciAd;
        private System.Windows.Forms.TextBox textBoxOgrenciAdres;
        private System.Windows.Forms.TextBox textBoxOgrenciSoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonIptal;
    }
}

