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
    public partial class Form1 : Form
    {
        public string ad, cinsiyet;//dışandan ulaşıbilmesi için başına public konmuştur.
        Form2 frm2 = new Form2();
        Form3 frm3 = new Form3();
        Random sayi = new Random();
        public int random, seninkutun = 0, actiginkutu, kutuno=0, teklif = 24, teklifpara,kutun;
        int[] sayilar = { 5, 10,20,25,50,100,200,250,500,750,1000,2500,5000,7500,10000,20000,25000,50000,75000,100000,200000,250000,500000,1000000 };
        public double toplampara=2247910;
        int[] kutular = new int[24];
        public Form1()
        {
            InitializeComponent();
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            for (int i = 0; i <= 23; i++)
            {
                /*
                 burdaki forun içinde kutular dizinine sayıları random atıyo.
                 yani atıyorum kutular[0]=sayilar[17] gibi para atama işlemleri.
             
               */
                tekrar:
                random = sayi.Next(0, 24);
                if (sayilar[random] == 0)
                {
                    goto tekrar;
                }
                else
                {
                    kutular[i] = sayilar[random];
                    sayilar[random] = 0;

                }
            }
            if (cinsiyet == "erkek") label2.Text = "Hoşgeldiniz " + ad + " Bey" + " Kutunuzu Seçiniz.";//form4 den gelen verileri kullanma.
            else label2.Text = "Hoşgeldiniz " + ad + " Hanım" + " Kutunuzu Seçiniz."; 
        }
        public void hesapla()
        {
            frm2.para = actiginkutu;//form2 ye yolladığın para miktarı
            frm2.kutu = kutuno;//form2 ye yolladığın kutu no
            frm2.ShowDialog();//form2 yi aç
            switch (actiginkutu)//kutunda çıkan paraya göre 
            {
                case 5: button25.Visible = false; toplampara = toplampara - 5; break;//eğer açtığın para 5 lirayla buton25 i gizle.
                case 10: button26.Visible = false; toplampara = toplampara - 10; break;
                case 20: button27.Visible = false; toplampara = toplampara - 20; break;
                case 25: button28.Visible = false; toplampara = toplampara - 25; break;
                case 50: button29.Visible = false; toplampara = toplampara - 50; break;
                case 100: button30.Visible = false; toplampara = toplampara - 100; break;
                case 200: button31.Visible = false; toplampara = toplampara - 200; break;
                case 250: button32.Visible = false; toplampara = toplampara - 250; break;
                case 500: button33.Visible = false; toplampara = toplampara - 500; break;
                case 750: button34.Visible = false; toplampara = toplampara - 750; break;
                case 1000: button35.Visible = false; toplampara = toplampara - 1000; break;
                case 2500: button36.Visible = false; toplampara = toplampara - 2500; break;
                case 5000: button48.Visible = false; toplampara = toplampara - 5000; break;
                case 7500: button47.Visible = false; toplampara = toplampara - 7500; break;
                case 10000: button46.Visible = false; toplampara = toplampara - 10000; break;
                case 20000: button45.Visible = false; toplampara = toplampara - 20000; break;
                case 25000: button44.Visible = false; toplampara = toplampara - 25000; break;
                case 50000: button43.Visible = false; toplampara = toplampara - 50000; break;
                case 75000: button42.Visible = false; toplampara = toplampara - 75000; break;
                case 100000: button41.Visible = false; toplampara = toplampara - 100000; break;
                case 200000: button40.Visible = false; toplampara = toplampara - 200000; break;
                case 250000: button39.Visible = false; toplampara = toplampara - 250000; break;
                case 500000: button38.Visible = false; toplampara = toplampara - 500000; break;
                case 1000000: button37.Visible = false; toplampara = toplampara - 1000000; break;
            }
            teklif--;//teklif değişkeni 1 azalıyo herseferinde 
            if (teklif == 19 || teklif == 14 || teklif == 9 || teklif == 5 || teklif == 2)//teklif değerleri burdaki değerlere eşitse teklif sunuyo
            {
                teklifpara = Convert.ToInt32(toplampara) / (teklif * 3);
                frm3.teklif = teklifpara;//form3 deki teklif değişkenine teklifpara değişkenini gönderiyo.
                 if (teklif == 2)//eğer teklif ikiyse yani iki kutu kaldıysa 
                {
                    frm3.teklif_Sayisi = teklif;//form3 e 2 kutu kaldı diye haber yolluyo 
                    frm3.kutunuzdaki_para = kutular[kutun];//kutumuzdaki parayı yolluyo

                }
                frm3.ShowDialog();
            }

        }//burası metot


        private void button1_Click(object sender, EventArgs e)
        {
            if (seninkutun==0)//kutu seçimini belirler.
            {
                button50.Text = button1.Text;//buton50 nin textini 1 yapar 
                button50.Visible = true;//buton 50 yi göster
                button1.Visible = false;//buton 1 i gizle
                seninkutun = 1; kutun = 0;//burdaki kutun değişkeni seçtiğin kutunun dizi numarası yani 1 numaralı kutunun dizi 0 olduğu için 0 yazdım.
            }
            else
            {
                button1.Visible = false; //eğer kutu seçilmişse buton1 i gizle
                actiginkutu = kutular[0];//değişken eşitleme
                kutuno = 1;
                hesapla();//metoda git
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (seninkutun == 0)
            {
                button50.Text = button2.Text;
                button50.Visible = true;
                button2.Visible = false;
                seninkutun = 1; kutun = 1;
            }
            else
            {
                button2.Visible = false;
                actiginkutu = kutular[1];
                kutuno = 2;
                hesapla();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (seninkutun == 0)
            {
                button50.Text = button3.Text;
                button50.Visible = true;
                button3.Visible = false;
                seninkutun = 1; kutun = 2;
            }
            else
            {
                
                button3.Visible = false;
                actiginkutu = kutular[2];
                kutuno = 3;
                hesapla();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (seninkutun == 0)
            {
                button50.Text = button4.Text;
                button50.Visible = true;
                button4.Visible = false;
                seninkutun = 1; kutun = 3;
            }
            else
            {
                
                button4.Visible = false;
                actiginkutu = kutular[3];
                kutuno = 4;
                hesapla();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (seninkutun == 0)
            {
                button50.Text = button5.Text;
                button50.Visible = true;
                button5.Visible = false;
                seninkutun = 1; kutun = 4;
            }
            else
            {
                
                button5.Visible = false;
                actiginkutu = kutular[4];
                kutuno = 5;
                hesapla();
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (seninkutun == 0)
            {
                button50.Text = button6.Text;
                button50.Visible = true;
                button6.Visible = false;
                seninkutun = 1; kutun = 5;
            }
            else
            {
                button6.Visible = false;
                actiginkutu = kutular[5];
                kutuno = 6;
                hesapla();

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (seninkutun == 0)
            {
                button50.Text = button7.Text;
                button50.Visible = true;
                button7.Visible = false;
                seninkutun = 1; kutun = 6;
            }
            else
            {
                
                button7.Visible = false;
                actiginkutu = kutular[6];
                kutuno = 7;
                hesapla();

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (seninkutun == 0)
            {
                button50.Text = button8.Text;
                button50.Visible = true;
                button8.Visible = false;
                seninkutun = 1; kutun = 7;
            }
            else
            {
                
                button8.Visible = false;
                actiginkutu = kutular[7];
                kutuno = 8;
                hesapla();

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (seninkutun == 0)
            {
                button50.Text = button9.Text;
                button50.Visible = true;
                button9.Visible = false;
                seninkutun = 1; kutun = 8;
            }
            else
            {
                
                button9.Visible = false;
                actiginkutu = kutular[8];
                kutuno = 9;
                hesapla();

            }
        }

        
 private void button10_Click(object sender, EventArgs e)
        {
            if (seninkutun == 0)
            {
                button50.Text = button10.Text;
                button50.Visible = true;
                button10.Visible = false;
                seninkutun = 1; kutun = 9;
            }
            else
            {
                
                button10.Visible = false;
                actiginkutu = kutular[9];
                kutuno = 10;
                hesapla();

            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (seninkutun == 0)
            {
                button50.Text = button12.Text;
                button50.Visible = true;
                button12.Visible = false;
                seninkutun = 1; kutun = 11;
            }
            else
            {

                button12.Visible = false;
                actiginkutu = kutular[11];
                kutuno = 12;
                hesapla();

            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (seninkutun == 0)
            {
                button50.Text = button11.Text;
                button50.Visible = true;
                button11.Visible = false;
                seninkutun = 1; kutun = 10;
            }
            else
            {
                
               
                button11.Visible = false;
                actiginkutu = kutular[10];
                kutuno = 11;
                hesapla();

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (seninkutun == 0)
            {
                button50.Text = button13.Text;
                button50.Visible = true;
                button13.Visible = false;
                seninkutun = 1; kutun = 12;
            }
            else
            {
               
                button13.Visible = false;
                actiginkutu = kutular[12];
                kutuno = 13;
                hesapla();

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (seninkutun == 0)
            {
                button50.Text = button14.Text;
                button50.Visible = true;
                button14.Visible = false;
                seninkutun = 1; kutun = 13;
            }
            else
            {
                
                button14.Visible = false;
                actiginkutu = kutular[13];
                kutuno = 14;
                hesapla();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (seninkutun == 0)
            {
                button50.Text = button15.Text;
                button50.Visible = true;
                button15.Visible = false;
                seninkutun = 1; kutun = 14;
            }
            else
            {
                
                button15.Visible = false;
                actiginkutu = kutular[14];
                kutuno = 15;
                hesapla();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (seninkutun == 0)
            {
                button50.Text = button16.Text;
                button50.Visible = true;
                button16.Visible = false;
                seninkutun = 1; kutun = 15;
            }
            else
            {
                
                button16.Visible = false;
                actiginkutu = kutular[15];
                kutuno = 16;
                hesapla();

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (seninkutun == 0)
            {
                button50.Text = button17.Text;
                button50.Visible = true;
                button17.Visible = false;
                seninkutun = 1; kutun = 16;
            }
            else
            {
                
                button17.Visible = false;
                actiginkutu = kutular[16];
                kutuno = 17;
                hesapla();

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (seninkutun == 0)
            {
                button50.Text = button18.Text;
                button50.Visible = true;
                button18.Visible = false;
                seninkutun = 1; kutun = 17;
            }
            else
            {
               
                button18.Visible = false;
                actiginkutu = kutular[17];
                kutuno = 18;
                hesapla();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (seninkutun == 0)
            {
                button50.Text = button19.Text;
                button50.Visible = true;
                button19.Visible = false;
                seninkutun = 1; kutun = 18;
            }
            else
            {
                
                button19.Visible = false;
                actiginkutu = kutular[18];
                kutuno = 19;
                hesapla();

            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (seninkutun == 0)
            {
                button50.Text = button20.Text;
                button50.Visible = true;
                button20.Visible = false;
                seninkutun = 1; kutun = 19;
            }
            else
            {
                
                button20.Visible = false;
                actiginkutu = kutular[19];
                kutuno = 20;
                hesapla();

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (seninkutun == 0)
            {
                button50.Text = button21.Text;
                button50.Visible = true;
                button21.Visible = false;
                seninkutun = 1; kutun = 20;
            }
            else
            {
                
                button21.Visible = false;
                actiginkutu = kutular[20];
                kutuno = 21;
                hesapla();
            }

        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (seninkutun == 0)
            {
                button50.Text = button22.Text;
                button50.Visible = true;
                button22.Visible = false;
                seninkutun = 1; kutun = 21;
            }
            else
            {
                
                button22.Visible = false;
                actiginkutu = kutular[21];
                kutuno = 22;
                hesapla();

            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (seninkutun == 0)
            {
                button50.Text = button23.Text;
                button50.Visible = true;
                button23.Visible = false;
                seninkutun = 1; kutun = 22;
            }
            else
            {
                
                button23.Visible = false;
                actiginkutu = kutular[22];
                kutuno = 23;
                hesapla();

            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (seninkutun == 0)
            {
                button50.Text = button24.Text;
                button50.Visible = true;
                button24.Visible = false;
                seninkutun = 1; kutun = 23;
            }
            else
            {
               
                button24.Visible = false;
                actiginkutu = kutular[23];
                kutuno = 24;
                hesapla();

            }
        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button49_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
