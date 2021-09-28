using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekran_Görüntüsü_alma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1EkranGoruntusu_Click(object sender, EventArgs e)
        {
            Bitmap resim = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics grafik = Graphics.FromImage(resim);
            grafik.CopyFromScreen(0, 0, 0, 0, new Size(resim.Width, resim.Height));
            pictureBox1.Image = resim;
            MessageBox.Show("Görüntü Alındı..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1Kaydet_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog resim = new SaveFileDialog();
                resim.Filter = "Resim Dosyaları|*.jpg;*.bmp;*.png;*.gif";
                
                if (resim.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(resim.FileName);
                    MessageBox.Show("Görüntü Kaydedildi..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Görüntü Kaydedilmedi..", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Resim Kaydedilmedi..", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button1Sil_Click(object sender, EventArgs e)
        {
            pictureBox1.Image =null;

            MessageBox.Show("Resim Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
