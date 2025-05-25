using Newtonsoft.Json;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace proje
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();

        }
         private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            if (File.Exists("veriler.json"))
            {
                string json = File.ReadAllText("veriler.json");
                Form1.hayvanListesi = JsonConvert.DeserializeObject<List<tr>>(json) ?? new List<tr>();
            }
        }
      
        private void cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textbox sadece sayı için kullanmak
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public static List<tr> hayvanListesi = new List<tr>();
    

        private void kaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kupeno.Text) || cinsiyet.SelectedItem == null || irk.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm bilgileri eksiksiz girin.");
                return;
            }

            tr yeniHayvan = new tr(); // HER TIKLAMADA YENİ NESNE

            yeniHayvan.KupeNo ="TR"+ kupeno.Text;
            yeniHayvan.Cinsiyet = cinsiyet.SelectedItem?.ToString() ?? "";
            yeniHayvan.Irk = irk.SelectedItem?.ToString() ?? "";
            yeniHayvan.DogumTarihi = dtarih.Value;
            yeniHayvan.AnaKupeNo ="TR"+ anakupeno.Text;
            yeniHayvan.Tarih = tarih.Value;

            string asi = "";
            if (cicek.Checked) asi += "Çiçek Aşısı;";
            if (sap.Checked) asi += "Şap Aşısı;";
            if (sarbon.Checked) asi += "Şarbon Aşısı;";
            yeniHayvan.AsiBilgileri = asi;

            string durum = "";
            if (olum.Checked) durum = "Ölüm";
            else if (sati.Checked) durum = "Satıldı";
            else if (alim.Checked) durum = "Alım";
            else if (dtarih.Checked) durum = "Doğum";
            else if (kkesim.Checked) durum = "Kurban Kesim";
            yeniHayvan.GuncelDurum = durum;

            Form1.hayvanListesi.Add(yeniHayvan);

            // JSON'a yaz
            string json = JsonConvert.SerializeObject(Form1.hayvanListesi, Formatting.Indented);
            File.WriteAllText("veriler.json", json);


            MessageBox.Show("Kayıt başarıyla eklendi.");


            // Gerekirse formu temizle
            kupeno.Clear();
            anakupeno.Clear();
            cicek.Checked = false;
            sap.Checked = false;
            sarbon.Checked = false;
            olum.Checked = false;
            sati.Checked = false;
            alim.Checked = false;
            dtarih.Checked = false;
            kkesim.Checked = false;
            cinsiyet.SelectedIndex = -1;
            irk.SelectedIndex = -1;
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            saat.Text = DateTime.Now.ToString();
        }

        private void chkOlum_CheckedChanged(object sender, EventArgs e)
        {
            if (olum.Checked)
            {
                sati.Checked = false;
                alim.Checked = false;
                dtarih.Checked = false;
                kkesim.Checked = false;

                label9.Text = olum.Text;
            }
        }
        private void chksati_CheckedChanged(object sender, EventArgs e)
        {
            if (sati.Checked)
            {
                olum.Checked = false;
                alim.Checked = false;
                dtarih.Checked = false;
                kkesim.Checked = false;

                label9.Text = sati.Text;
            }
        }
        private void chkalim_CheckedChanged(object sender, EventArgs e)
        {
            if (alim.Checked)
            {
                sati.Checked = false;
                olum.Checked = false;
                dtarih.Checked = false;
                kkesim.Checked = false;

                label9.Text = alim.Text;
            }
        }
        private void chkdtarih_CheckedChanged(object sender, EventArgs e)
        {
            if (dtarih.Checked)
            {
                sati.Checked = false;
                alim.Checked = false;
                olum.Checked = false;
                kkesim.Checked = false;

                label9.Text = dtarih.Text;
            }
        }
        private void chkkseim_CheckedChanged(object sender, EventArgs e)
        {
            if (kkesim.Checked)
            {
                sati.Checked = false;
                alim.Checked = false;
                dtarih.Checked = false;
                olum.Checked = false;

                label9.Text = kkesim.Text;
            }
        }

        private void liste_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

       
        public static void Kaydet()
        {
            string json = JsonConvert.SerializeObject(hayvanListesi, Formatting.Indented);
            File.WriteAllText("veriler1.json",json);
        } 
        public static void Yukle()
        {
            if (File.Exists("veriler1.json"))
            {
                string json = File.ReadAllText("veriler1.json"); 
                hayvanListesi = JsonConvert.DeserializeObject<List<tr>>(json);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Kaydet();
        }
        private void saat_Click(object sender, EventArgs e)
        {

        }

        private void kupeno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
