using System;

namespace proje
{
   
    partial class Form2
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
            this.saat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cikis = new System.Windows.Forms.Button();
            this.bilgigirisekrani = new System.Windows.Forms.Button();
            this.listele = new System.Windows.Forms.DataGridView();
            this.sil = new System.Windows.Forms.Button();
            this.duzenle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listele)).BeginInit();
            this.SuspendLayout();
            // 
            // saat
            // 
            this.saat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saat.Location = new System.Drawing.Point(0, 434);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(1182, 16);
            this.saat.TabIndex = 0;
            this.saat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(602, 390);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(75, 32);
            this.cikis.TabIndex = 1;
            this.cikis.Text = "ÇIKIŞ";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // bilgigirisekrani
            // 
            this.bilgigirisekrani.Location = new System.Drawing.Point(441, 390);
            this.bilgigirisekrani.Name = "bilgigirisekrani";
            this.bilgigirisekrani.Size = new System.Drawing.Size(155, 32);
            this.bilgigirisekrani.TabIndex = 2;
            this.bilgigirisekrani.Text = "BİLGİ GİRİŞ EKRANI";
            this.bilgigirisekrani.UseVisualStyleBackColor = true;
            this.bilgigirisekrani.Click += new System.EventHandler(this.bilgigirisekrani_Click);
            // 
            // listele
            // 
            this.listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listele.Location = new System.Drawing.Point(0, 1);
            this.listele.Name = "listele";
            this.listele.RowHeadersWidth = 51;
            this.listele.RowTemplate.Height = 24;
            this.listele.Size = new System.Drawing.Size(1182, 371);
            this.listele.TabIndex = 3;
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(360, 390);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(75, 32);
            this.sil.TabIndex = 4;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // duzenle
            // 
            this.duzenle.Location = new System.Drawing.Point(264, 390);
            this.duzenle.Name = "duzenle";
            this.duzenle.Size = new System.Drawing.Size(90, 32);
            this.duzenle.TabIndex = 5;
            this.duzenle.Text = "DÜZENLE";
            this.duzenle.UseVisualStyleBackColor = true;
            this.duzenle.Click += new System.EventHandler(this.duzenle_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 450);
            this.Controls.Add(this.duzenle);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.bilgigirisekrani);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.saat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label saat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Button bilgigirisekrani;
        private System.Windows.Forms.DataGridView listele;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button duzenle;
    }
}