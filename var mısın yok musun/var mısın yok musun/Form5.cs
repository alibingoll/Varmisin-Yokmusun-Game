using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;//media ekleme

namespace var_mısın_yok_musun
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public int kazandiginizpara=0;
        private void button1_Click(object sender, EventArgs e)//tekrar oyna butonu
        {
            Form4 frm4 = new Form4();
            this.Hide();
            frm4.ShowDialog();
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label4.Text=kazandiginizpara+" TL";//form3 den gelen parayı atıyo
           /* SoundPlayer ses = new SoundPlayer();//ses dosyası nesnesi
            string path = "C:\\Users\\Ali\\Desktop\\varmısın yokmusun foto\\ses\\alkis.wav";//ses dosyası yolu
            ses.SoundLocation = path;
            ses.Play();*/
        }

        private void button2_Click(object sender, EventArgs e)//çıkış butonu
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
