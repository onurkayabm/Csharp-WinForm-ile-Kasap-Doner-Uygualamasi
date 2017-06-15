namespace Deneme
{
    partial class FormAna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAna));
            this.cmbMenuler = new System.Windows.Forms.ComboBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblPorsiyon = new System.Windows.Forms.Label();
            this.rdbTam = new System.Windows.Forms.RadioButton();
            this.rdbYarim = new System.Windows.Forms.RadioButton();
            this.grpExtra = new System.Windows.Forms.GroupBox();
            this.grpIslemler = new System.Windows.Forms.GroupBox();
            this.btnSiparisler = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.nmcAdet = new System.Windows.Forms.NumericUpDown();
            this.lblAdet = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.grpIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMenuler
            // 
            this.cmbMenuler.FormattingEnabled = true;
            this.cmbMenuler.Location = new System.Drawing.Point(145, 208);
            this.cmbMenuler.Name = "cmbMenuler";
            this.cmbMenuler.Size = new System.Drawing.Size(176, 21);
            this.cmbMenuler.TabIndex = 0;
            this.cmbMenuler.SelectedIndexChanged += new System.EventHandler(this.cmbMenuler_SelectedIndexChanged);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenu.Location = new System.Drawing.Point(38, 206);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(89, 20);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menü Seç";
            // 
            // lblPorsiyon
            // 
            this.lblPorsiyon.AutoSize = true;
            this.lblPorsiyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPorsiyon.Location = new System.Drawing.Point(38, 247);
            this.lblPorsiyon.Name = "lblPorsiyon";
            this.lblPorsiyon.Size = new System.Drawing.Size(77, 20);
            this.lblPorsiyon.TabIndex = 1;
            this.lblPorsiyon.Text = "Porsiyon";
            // 
            // rdbTam
            // 
            this.rdbTam.AutoSize = true;
            this.rdbTam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbTam.Location = new System.Drawing.Point(145, 250);
            this.rdbTam.Name = "rdbTam";
            this.rdbTam.Size = new System.Drawing.Size(57, 21);
            this.rdbTam.TabIndex = 2;
            this.rdbTam.TabStop = true;
            this.rdbTam.Text = "Tam";
            this.rdbTam.UseVisualStyleBackColor = true;
            // 
            // rdbYarim
            // 
            this.rdbYarim.AutoSize = true;
            this.rdbYarim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbYarim.Location = new System.Drawing.Point(236, 250);
            this.rdbYarim.Name = "rdbYarim";
            this.rdbYarim.Size = new System.Drawing.Size(67, 21);
            this.rdbYarim.TabIndex = 2;
            this.rdbYarim.TabStop = true;
            this.rdbYarim.Text = "Yarım";
            this.rdbYarim.UseVisualStyleBackColor = true;
            // 
            // grpExtra
            // 
            this.grpExtra.Location = new System.Drawing.Point(12, 283);
            this.grpExtra.Name = "grpExtra";
            this.grpExtra.Size = new System.Drawing.Size(348, 227);
            this.grpExtra.TabIndex = 3;
            this.grpExtra.TabStop = false;
            this.grpExtra.Text = "Extralar";
            // 
            // grpIslemler
            // 
            this.grpIslemler.Controls.Add(this.btnSiparisler);
            this.grpIslemler.Controls.Add(this.btnEkle);
            this.grpIslemler.Controls.Add(this.btnHesapla);
            this.grpIslemler.Controls.Add(this.txtTutar);
            this.grpIslemler.Controls.Add(this.nmcAdet);
            this.grpIslemler.Controls.Add(this.lblAdet);
            this.grpIslemler.Controls.Add(this.label5);
            this.grpIslemler.Controls.Add(this.lblToplam);
            this.grpIslemler.Location = new System.Drawing.Point(366, 283);
            this.grpIslemler.Name = "grpIslemler";
            this.grpIslemler.Size = new System.Drawing.Size(401, 227);
            this.grpIslemler.TabIndex = 4;
            this.grpIslemler.TabStop = false;
            this.grpIslemler.Text = "İşlemler";
            // 
            // btnSiparisler
            // 
            this.btnSiparisler.Location = new System.Drawing.Point(254, 41);
            this.btnSiparisler.Name = "btnSiparisler";
            this.btnSiparisler.Size = new System.Drawing.Size(132, 129);
            this.btnSiparisler.TabIndex = 4;
            this.btnSiparisler.Text = "SiparisTamamla";
            this.btnSiparisler.UseVisualStyleBackColor = true;
            this.btnSiparisler.Click += new System.EventHandler(this.btnSiparisler_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(135, 147);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(29, 147);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(80, 83);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(100, 20);
            this.txtTutar.TabIndex = 3;
            // 
            // nmcAdet
            // 
            this.nmcAdet.Location = new System.Drawing.Point(80, 41);
            this.nmcAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmcAdet.Name = "nmcAdet";
            this.nmcAdet.Size = new System.Drawing.Size(120, 20);
            this.nmcAdet.TabIndex = 2;
            this.nmcAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdet.Location = new System.Drawing.Point(17, 41);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(47, 20);
            this.lblAdet.TabIndex = 1;
            this.lblAdet.Text = "Adet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "TL";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(7, 83);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(67, 20);
            this.lblToplam.TabIndex = 1;
            this.lblToplam.Text = "Toplam";
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.Location = new System.Drawing.Point(366, 18);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(400, 251);
            this.lstSiparisler.TabIndex = 5;
            // 
            // pbResim
            // 
            this.pbResim.BackgroundImage = global::Deneme.Properties.Resources.Kasap;
            this.pbResim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbResim.Location = new System.Drawing.Point(12, 18);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(348, 174);
            this.pbResim.TabIndex = 6;
            this.pbResim.TabStop = false;
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(775, 528);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.lstSiparisler);
            this.Controls.Add(this.grpIslemler);
            this.Controls.Add(this.grpExtra);
            this.Controls.Add(this.rdbYarim);
            this.Controls.Add(this.rdbTam);
            this.Controls.Add(this.lblPorsiyon);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.cmbMenuler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAna";
            this.Text = "KasapDoner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpIslemler.ResumeLayout(false);
            this.grpIslemler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMenuler;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblPorsiyon;
        private System.Windows.Forms.RadioButton rdbTam;
        private System.Windows.Forms.RadioButton rdbYarim;
        private System.Windows.Forms.GroupBox grpExtra;
        private System.Windows.Forms.GroupBox grpIslemler;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.NumericUpDown nmcAdet;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Button btnSiparisler;
        private System.Windows.Forms.PictureBox pbResim;
    }
}

