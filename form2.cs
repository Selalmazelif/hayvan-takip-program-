using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static List<tr> hayvanListesi = new List<tr>();
        private void timer1_Tick(object sender, EventArgs e)
        {
            saat.Text = DateTime.Now.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listele.DataSource = null;
            listele.DataSource = Form1.hayvanListesi;
            MessageBox.Show("Kayıt Sayısı: " + Form1.hayvanListesi.Count);

        }

        public void GuncelleListe()
        {
            listele.DataSource = null;
            listele.DataSource = Form1.hayvanListesi;
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void sil_Click(object sender, EventArgs e)
        {         
            if (listele.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in listele.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        int index = row.Index;
                        Form1.hayvanListesi.RemoveAt(index);
                    }
                }

                GuncelleListe(); // Listeyi yeniden yükle
            }
            else
            {
                MessageBox.Show("Silmek için bir satır seçin.");
            }
        }

        



        private void bilgigirisekrani_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        

        private void duzenle_Click(object sender, EventArgs e)
        {
            if (listele.CurrentRow != null)
            {
                int secilenIndex = listele.CurrentRow.Index;
                tr secilenHayvan = Form1.hayvanListesi[secilenIndex];

                Form3 form3 = new Form3(secilenHayvan, secilenIndex);
                form3.Show();
            }
        }
    }
    

}
