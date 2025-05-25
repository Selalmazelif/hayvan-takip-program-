
using System;

namespace proje
{
    
    partial class Form3
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
            this.dogum = new System.Windows.Forms.CheckBox();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.alim = new System.Windows.Forms.CheckBox();
            this.sati = new System.Windows.Forms.CheckBox();
            this.kkesim = new System.Windows.Forms.CheckBox();
            this.olum = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sarbon = new System.Windows.Forms.CheckBox();
            this.sap = new System.Windows.Forms.CheckBox();
            this.cicek = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.anakupeno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.irk = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cinsiyet = new System.Windows.Forms.ComboBox();
            this.duzenle = new System.Windows.Forms.Button();
            this.kupeno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cikis = new System.Windows.Forms.Button();
            this.asi = new System.Windows.Forms.GroupBox();
            this.guncel = new System.Windows.Forms.GroupBox();
            this.asi.SuspendLayout();
            this.guncel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dogum
            // 
            this.dogum.AutoSize = true;
            this.dogum.Location = new System.Drawing.Point(52, 59);
            this.dogum.Name = "dogum";
            this.dogum.Size = new System.Drawing.Size(80, 20);
            this.dogum.TabIndex = 52;
            this.dogum.Text = "DOĞUM";
            this.dogum.UseVisualStyleBackColor = true;
            this.dogum.CheckedChanged += new System.EventHandler(this.chkdtarih_CheckedChanged);
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(161, 389);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(200, 22);
            this.tarih.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 50;
            // 
            // alim
            // 
            this.alim.AutoSize = true;
            this.alim.Location = new System.Drawing.Point(116, 33);
            this.alim.Name = "alim";
            this.alim.Size = new System.Drawing.Size(59, 20);
            this.alim.TabIndex = 48;
            this.alim.Text = "ALIM";
            this.alim.UseVisualStyleBackColor = true;
            this.alim.CheckedChanged += new System.EventHandler(this.chkalim_CheckedChanged);
            // 
            // sati
            // 
            this.sati.AutoSize = true;
            this.sati.Location = new System.Drawing.Point(10, 33);
            this.sati.Name = "sati";
            this.sati.Size = new System.Drawing.Size(82, 20);
            this.sati.TabIndex = 47;
            this.sati.Text = "SATILDI ";
            this.sati.UseVisualStyleBackColor = true;
            this.sati.CheckedChanged += new System.EventHandler(this.chksati_CheckedChanged);
            // 
            // kkesim
            // 
            this.kkesim.AutoSize = true;
            this.kkesim.Location = new System.Drawing.Point(116, 7);
            this.kkesim.Name = "kkesim";
            this.kkesim.Size = new System.Drawing.Size(128, 20);
            this.kkesim.TabIndex = 46;
            this.kkesim.Text = "KURBAN KESİM";
            this.kkesim.UseVisualStyleBackColor = true;
            this.kkesim.CheckedChanged += new System.EventHandler(this.chkkseim_CheckedChanged);
            // 
            // olum
            // 
            this.olum.AutoSize = true;
            this.olum.Location = new System.Drawing.Point(11, 4);
            this.olum.Name = "olum";
            this.olum.Size = new System.Drawing.Size(67, 20);
            this.olum.TabIndex = 45;
            this.olum.Text = "ÖLÜM";
            this.olum.UseVisualStyleBackColor = true;
            this.olum.CheckedChanged += new System.EventHandler(this.chkOlum_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "GÜNCEL DURUMU:";
            // 
            // sarbon
            // 
            this.sarbon.AutoSize = true;
            this.sarbon.Location = new System.Drawing.Point(49, 37);
            this.sarbon.Name = "sarbon";
            this.sarbon.Size = new System.Drawing.Size(122, 20);
            this.sarbon.TabIndex = 42;
            this.sarbon.Text = "ŞARBON AŞISI";
            this.sarbon.UseVisualStyleBackColor = true;
            // 
            // sap
            // 
            this.sap.AutoSize = true;
            this.sap.Location = new System.Drawing.Point(106, 10);
            this.sap.Name = "sap";
            this.sap.Size = new System.Drawing.Size(92, 20);
            this.sap.TabIndex = 41;
            this.sap.Text = "ŞAP AŞISI";
            this.sap.UseVisualStyleBackColor = true;
            // 
            // cicek
            // 
            this.cicek.AutoSize = true;
            this.cicek.Location = new System.Drawing.Point(1, 11);
            this.cicek.Name = "cicek";
            this.cicek.Size = new System.Drawing.Size(103, 20);
            this.cicek.TabIndex = 40;
            this.cicek.Text = "ÇİÇEK AŞISI";
            this.cicek.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "AŞI BİLGİLERİ:";
            // 
            // anakupeno
            // 
            this.anakupeno.Location = new System.Drawing.Point(160, 167);
            this.anakupeno.Name = "anakupeno";
            this.anakupeno.Size = new System.Drawing.Size(200, 22);
            this.anakupeno.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "ANA-KÜPE NO:";
            // 
            // dtarih
            // 
            this.dtarih.Location = new System.Drawing.Point(161, 130);
            this.dtarih.Name = "dtarih";
            this.dtarih.Size = new System.Drawing.Size(200, 22);
            this.dtarih.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "DOĞUM TARİHİ:";
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
            this.irk.Location = new System.Drawing.Point(161, 95);
            this.irk.Name = "irk";
            this.irk.Size = new System.Drawing.Size(200, 24);
            this.irk.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "IRK:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "CİNSİYET:";
            // 
            // cinsiyet
            // 
            this.cinsiyet.FormattingEnabled = true;
            this.cinsiyet.Items.AddRange(new object[] {
            "DİŞİ",
            "ERKEK",
            "DÜVE",
            "BUZAĞI"});
            this.cinsiyet.Location = new System.Drawing.Point(161, 57);
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.Size = new System.Drawing.Size(200, 24);
            this.cinsiyet.TabIndex = 31;
            // 
            // duzenle
            // 
            this.duzenle.Location = new System.Drawing.Point(220, 432);
            this.duzenle.Name = "duzenle";
            this.duzenle.Size = new System.Drawing.Size(93, 23);
            this.duzenle.TabIndex = 30;
            this.duzenle.Text = "DÜZENLE";
            this.duzenle.UseVisualStyleBackColor = true;
            this.duzenle.Click += new System.EventHandler(this.duzenle_Click);
            // 
            // kupeno
            // 
            this.kupeno.Location = new System.Drawing.Point(161, 25);
            this.kupeno.Name = "kupeno";
            this.kupeno.Size = new System.Drawing.Size(200, 22);
            this.kupeno.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "KÜPE NO:";
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(319, 432);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(75, 23);
            this.cikis.TabIndex = 27;
            this.cikis.Text = "ÇIKIŞ";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // asi
            // 
            this.asi.Controls.Add(this.sarbon);
            this.asi.Controls.Add(this.sap);
            this.asi.Controls.Add(this.cicek);
            this.asi.Location = new System.Drawing.Point(160, 199);
            this.asi.Name = "asi";
            this.asi.Size = new System.Drawing.Size(210, 68);
            this.asi.TabIndex = 53;
            this.asi.TabStop = false;
            // 
            // guncel
            // 
            this.guncel.Controls.Add(this.dogum);
            this.guncel.Controls.Add(this.alim);
            this.guncel.Controls.Add(this.sati);
            this.guncel.Controls.Add(this.kkesim);
            this.guncel.Controls.Add(this.olum);
            this.guncel.Location = new System.Drawing.Point(157, 273);
            this.guncel.Name = "guncel";
            this.guncel.Size = new System.Drawing.Size(243, 91);
            this.guncel.TabIndex = 54;
            this.guncel.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 488);
            this.Controls.Add(this.guncel);
            this.Controls.Add(this.asi);
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
            this.Controls.Add(this.duzenle);
            this.Controls.Add(this.kupeno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cikis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.asi.ResumeLayout(false);
            this.asi.PerformLayout();
            this.guncel.ResumeLayout(false);
            this.guncel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox dogum;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox alim;
        private System.Windows.Forms.CheckBox sati;
        private System.Windows.Forms.CheckBox kkesim;
        private System.Windows.Forms.CheckBox olum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox sarbon;
        private System.Windows.Forms.CheckBox sap;
        private System.Windows.Forms.CheckBox cicek;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox anakupeno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox irk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cinsiyet;
        private System.Windows.Forms.Button duzenle;
        private System.Windows.Forms.TextBox kupeno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.GroupBox asi;
        private System.Windows.Forms.GroupBox guncel;
    }
}