namespace proje
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kupeno = new System.Windows.Forms.TextBox();
            this.kaydet = new System.Windows.Forms.Button();
            this.cinsiyet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.irk = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtarih = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.anakupeno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cicek = new System.Windows.Forms.CheckBox();
            this.sap = new System.Windows.Forms.CheckBox();
            this.sarbon = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.olum = new System.Windows.Forms.CheckBox();
            this.kkesim = new System.Windows.Forms.CheckBox();
            this.sati = new System.Windows.Forms.CheckBox();
            this.alim = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.dogum = new System.Windows.Forms.CheckBox();
            this.saat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.asi = new System.Windows.Forms.GroupBox();
            this.guncel = new System.Windows.Forms.GroupBox();
            this.liste = new System.Windows.Forms.Button();
            this.asi.SuspendLayout();
            this.guncel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.cikis_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "HAYVAN BİLGİ SİSTEMİ KAYIT YERİ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "KÜPE NO:";
            // 
            // kupeno
            // 
            this.kupeno.Location = new System.Drawing.Point(156, 45);
            this.kupeno.Name = "kupeno";
            this.kupeno.Size = new System.Drawing.Size(200, 22);
            this.kupeno.TabIndex = 3;
            this.kupeno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(210, 448);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(80, 23);
            this.kaydet.TabIndex = 4;
            this.kaydet.Text = "KAYDET";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // cinsiyet
            // 
            this.cinsiyet.FormattingEnabled = true;
            this.cinsiyet.Items.AddRange(new object[] {
            "DİŞİ",
            "ERKEK"});
            this.cinsiyet.Location = new System.Drawing.Point(157, 73);
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.Size = new System.Drawing.Size(200, 24);
            this.cinsiyet.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "CİNSİYET:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "IRK:";
            // 
            // irk
            // 
            this.irk.FormattingEnabled = true;
            this.irk.Items.AddRange(new object[] {
            "SİMENTAL",
            "MONTOFON",
            "ŞAROLE",
            "CARSE",
            "HOLSTEİN"});
            this.irk.Location = new System.Drawing.Point(157, 111);
            this.irk.Name = "irk";
            this.irk.Size = new System.Drawing.Size(200, 24);
            this.irk.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "DOĞUM TARİHİ:";
            // 
            // dtarih
            // 
            this.dtarih.Location = new System.Drawing.Point(157, 149);
            this.dtarih.Name = "dtarih";
            this.dtarih.Size = new System.Drawing.Size(200, 22);
            this.dtarih.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "ANA-KÜPE NO:";
            // 
            // anakupeno
            // 
            this.anakupeno.Location = new System.Drawing.Point(156, 183);
            this.anakupeno.Name = "anakupeno";
            this.anakupeno.Size = new System.Drawing.Size(200, 22);
            this.anakupeno.TabIndex = 12;
            this.anakupeno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "AŞI BİLGİLERİ:";
            // 
            // cicek
            // 
            this.cicek.AutoSize = true;
            this.cicek.Location = new System.Drawing.Point(6, 16);
            this.cicek.Name = "cicek";
            this.cicek.Size = new System.Drawing.Size(103, 20);
            this.cicek.TabIndex = 14;
            this.cicek.Text = "ÇİÇEK AŞISI";
            this.cicek.UseVisualStyleBackColor = true;
            // 
            // sap
            // 
            this.sap.AutoSize = true;
            this.sap.Location = new System.Drawing.Point(113, 15);
            this.sap.Name = "sap";
            this.sap.Size = new System.Drawing.Size(92, 20);
            this.sap.TabIndex = 15;
            this.sap.Text = "ŞAP AŞISI";
            this.sap.UseVisualStyleBackColor = true;
            // 
            // sarbon
            // 
            this.sarbon.AutoSize = true;
            this.sarbon.Location = new System.Drawing.Point(46, 42);
            this.sarbon.Name = "sarbon";
            this.sarbon.Size = new System.Drawing.Size(122, 20);
            this.sarbon.TabIndex = 16;
            this.sarbon.Text = "ŞARBON AŞISI";
            this.sarbon.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "GÜNCEL DURUMU:";
            // 
            // olum
            // 
            this.olum.AutoSize = true;
            this.olum.Location = new System.Drawing.Point(10, 21);
            this.olum.Name = "olum";
            this.olum.Size = new System.Drawing.Size(67, 20);
            this.olum.TabIndex = 19;
            this.olum.Text = "ÖLÜM";
            this.olum.UseVisualStyleBackColor = true;
            this.olum.CheckedChanged += new System.EventHandler(this.chkOlum_CheckedChanged);
            // 
            // kkesim
            // 
            this.kkesim.AutoSize = true;
            this.kkesim.Location = new System.Drawing.Point(109, 19);
            this.kkesim.Name = "kkesim";
            this.kkesim.Size = new System.Drawing.Size(128, 20);
            this.kkesim.TabIndex = 20;
            this.kkesim.Text = "KURBAN KESİM";
            this.kkesim.UseVisualStyleBackColor = true;
            this.kkesim.CheckedChanged += new System.EventHandler(this.chkkseim_CheckedChanged);
            // 
            // sati
            // 
            this.sati.AutoSize = true;
            this.sati.Location = new System.Drawing.Point(10, 47);
            this.sati.Name = "sati";
            this.sati.Size = new System.Drawing.Size(82, 20);
            this.sati.TabIndex = 21;
            this.sati.Text = "SATILDI ";
            this.sati.UseVisualStyleBackColor = true;
            this.sati.CheckedChanged += new System.EventHandler(this.chksati_CheckedChanged);
            // 
            // alim
            // 
            this.alim.AutoSize = true;
            this.alim.Location = new System.Drawing.Point(109, 47);
            this.alim.Name = "alim";
            this.alim.Size = new System.Drawing.Size(59, 20);
            this.alim.TabIndex = 22;
            this.alim.Text = "ALIM";
            this.alim.UseVisualStyleBackColor = true;
            this.alim.CheckedChanged += new System.EventHandler(this.chkalim_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 24;
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(157, 405);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(200, 22);
            this.tarih.TabIndex = 25;
            // 
            // dogum
            // 
            this.dogum.AutoSize = true;
            this.dogum.Location = new System.Drawing.Point(46, 73);
            this.dogum.Name = "dogum";
            this.dogum.Size = new System.Drawing.Size(80, 20);
            this.dogum.TabIndex = 26;
            this.dogum.Text = "DOĞUM";
            this.dogum.UseVisualStyleBackColor = true;
            this.dogum.CheckedChanged += new System.EventHandler(this.chkdtarih_CheckedChanged);
            this.dogum.Enter += new System.EventHandler(this.chkdtarih_CheckedChanged);
            // 
            // saat
            // 
            this.saat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saat.Location = new System.Drawing.Point(0, 488);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(451, 16);
            this.saat.TabIndex = 27;
            this.saat.Text = "label10";
            this.saat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // asi
            // 
            this.asi.Controls.Add(this.sarbon);
            this.asi.Controls.Add(this.sap);
            this.asi.Controls.Add(this.cicek);
            this.asi.Location = new System.Drawing.Point(157, 211);
            this.asi.Name = "asi";
            this.asi.Size = new System.Drawing.Size(219, 72);
            this.asi.TabIndex = 28;
            this.asi.TabStop = false;
            // 
            // guncel
            // 
            this.guncel.Controls.Add(this.dogum);
            this.guncel.Controls.Add(this.alim);
            this.guncel.Controls.Add(this.sati);
            this.guncel.Controls.Add(this.olum);
            this.guncel.Controls.Add(this.kkesim);
            this.guncel.Location = new System.Drawing.Point(156, 279);
            this.guncel.Name = "guncel";
            this.guncel.Size = new System.Drawing.Size(242, 106);
            this.guncel.TabIndex = 29;
            this.guncel.TabStop = false;
            // 
            // liste
            // 
            this.liste.Location = new System.Drawing.Point(108, 451);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(75, 23);
            this.liste.TabIndex = 30;
            this.liste.Text = "LİSTE";
            this.liste.UseVisualStyleBackColor = true;
            this.liste.Click += new System.EventHandler(this.liste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 504);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.guncel);
            this.Controls.Add(this.asi);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.anakupeno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.irk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cinsiyet);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.kupeno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.asi.ResumeLayout(false);
            this.asi.PerformLayout();
            this.guncel.ResumeLayout(false);
            this.guncel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kupeno;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.ComboBox cinsiyet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox irk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtarih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox anakupeno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cicek;
        private System.Windows.Forms.CheckBox sap;
        private System.Windows.Forms.CheckBox sarbon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox olum;
        private System.Windows.Forms.CheckBox kkesim;
        private System.Windows.Forms.CheckBox sati;
        private System.Windows.Forms.CheckBox alim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.CheckBox dogum;
        private System.Windows.Forms.Label saat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox asi;
        private System.Windows.Forms.GroupBox guncel;
        private System.Windows.Forms.Button liste;
    }
}

