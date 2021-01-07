using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace var_mısın_yok_musun
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        public int teklif { get; set; }
        public int teklif_Sayisi { get; set; }
        public int kutunuzdaki_para { get; set; }
       
        private void Form3_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            if (teklif_Sayisi == 2) button2.Text = "Kutuma Git";//eğer teklif değeri ikiyse yani 2 kutu kaldıysa yokum butonunu kutuma git diye değiştiriyo
            label2.Text = teklif + " TL";
           
        }
        Form5 frm = new Form5();
        
        private void button1_Click(object sender, EventArgs e)//varım butonu
        {
            
            frm.kazandiginizpara = teklif;
            this.Hide();
            frm.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)//yokum butonu
        {
            if (teklif_Sayisi==2)
            {
                
                frm.kazandiginizpara = kutunuzdaki_para;
                this.Hide();
                frm.ShowDialog();
            }
            else this.Hide();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//form3 ün closed kısmına yani sağ üstteki X butonuna işlem atıyo.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
