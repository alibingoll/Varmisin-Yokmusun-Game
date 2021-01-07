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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "") MessageBox.Show("Adınız veya Soyadınızı girmediniz.","Hata");
          else if (radioButton1.Checked==false && radioButton2.Checked==false) MessageBox.Show("Cinsiyet kısmını boş bırakmayın.","Hata");
            else
            {
                Form1 frm1 = new Form1();
                if (radioButton1.Checked == true) frm1.cinsiyet = "erkek";
                else frm1.cinsiyet = "kız";//forum 1 deki cinsiyete eşitle
                frm1.ad = textBox1.Text;//forum 1 deki ada textboxu eşitle
                this.Hide();
                frm1.ShowDialog();
                
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;//form genişletmeyi kapatır
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
