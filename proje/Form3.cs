using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class Form3 : Form
    {
        tr mevcutHayvan;
        int index;
        private tr secilenHayvan;
        private int secilenIndex;

        public Form3(tr hayvan, int hayvanIndex)
        {
            InitializeComponent();
            mevcutHayvan = hayvan;
            index = hayvanIndex;

            // Bilgileri forma yerleştir
            kupeno.Text = hayvan.KupeNo;
            cinsiyet.SelectedItem = hayvan.Cinsiyet;
            irk.SelectedItem = hayvan.Irk;
            dtarih.Value = hayvan.DogumTarihi;
            anakupeno.Text = hayvan.AnaKupeNo;
            // Aşı ve güncel durum checkbox'ları da burada ayarlanabilir

            // CheckBox’lar
            cicek.Checked = hayvan.AsiBilgileri.Contains("Çiçek Aşısı");
            sap.Checked = hayvan.AsiBilgileri.Contains("Şap Aşısı");
            sarbon.Checked = hayvan.AsiBilgileri.Contains("Şarbon Aşısı");

            olum.Checked = hayvan.GuncelDurum == "Ölüm";
            sati.Checked = hayvan.GuncelDurum == "Satıldı";
            alim.Checked = hayvan.GuncelDurum == "Alım";
            dtarih.Checked = hayvan.GuncelDurum == "Doğum";
            kkesim.Checked = hayvan.GuncelDurum == "Kurban Kesim";
        }

        private void duzenle_Click(object sender, EventArgs e)
        {
            string asilar = "";
            if (cicek.Checked) asilar = "Çiçek Aşısı";
            if (sap.Checked) asilar = "Şap Aşısı";
            if (sarbon.Checked) asilar = "Şarbon Aşısı";

            string durum = "";
            if (olum.Checked) durum = "Ölüm";
            else if (sati.Checked) durum = "Satıldı";
            else if (alim.Checked) durum = "Alım";
            else if (dtarih.Checked) durum = "Doğum";
            else if (kkesim.Checked) durum = "Kurban Kesim";

            label9.Text = durum;  

            // Güncelle
            mevcutHayvan.KupeNo = kupeno.Text;
            mevcutHayvan.Cinsiyet = cinsiyet.SelectedItem.ToString();
            mevcutHayvan.Irk = irk.SelectedItem.ToString();
            mevcutHayvan.DogumTarihi = dtarih.Value;
            mevcutHayvan.AnaKupeNo = anakupeno.Text;
            mevcutHayvan.AsiBilgileri = asilar;
            mevcutHayvan.GuncelDurum = durum;
            mevcutHayvan.Tarih = tarih.Value;

            // Listeye geri yaz
            Form1.hayvanListesi[index] = mevcutHayvan;

            // Form2'yi güncellemek için yeniden yükle
            foreach (Form f in Application.OpenForms)
            {
                if (f is Form2 form2)
                {
                    form2.GuncelleListe();
                    break;
                }
            }

            this.Close();
            
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            this.Close();
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

    }
}
