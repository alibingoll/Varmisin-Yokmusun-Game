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
   
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int para { get; set; }
        public int kutu { get; set; }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            switch (kutu)
            {
                case 1: pictureBox1.Image = ımageList1.Images[1]; break;//kutu numarasına göre resim.
                case 2: pictureBox1.Image = ımageList1.Images[2]; break;
                case 3: pictureBox1.Image = ımageList1.Images[3]; break;
                case 4: pictureBox1.Image = ımageList1.Images[4]; break;
                case 5: pictureBox1.Image = ımageList1.Images[5]; break;
                case 6: pictureBox1.Image = ımageList1.Images[6]; break;
                case 7: pictureBox1.Image = ımageList1.Images[7]; break;
                case 8: pictureBox1.Image = ımageList1.Images[8]; break;
                case 9: pictureBox1.Image = ımageList1.Images[9]; break;
                case 10: pictureBox1.Image = ımageList1.Images[10]; break;
                case 11: pictureBox1.Image = ımageList1.Images[11]; break;
                case 12: pictureBox1.Image = ımageList1.Images[12]; break;
                case 13: pictureBox1.Image = ımageList1.Images[13]; break;
                case 14: pictureBox1.Image = ımageList1.Images[14]; break;
                case 15: pictureBox1.Image = ımageList1.Images[15]; break;
                case 16: pictureBox1.Image = ımageList1.Images[16]; break;
                case 17: pictureBox1.Image = ımageList1.Images[17]; break;
                case 18: pictureBox1.Image = ımageList1.Images[18]; break;
                case 19: pictureBox1.Image = ımageList1.Images[19]; break;
                case 20: pictureBox1.Image = ımageList1.Images[20]; break;
                case 21: pictureBox1.Image = ımageList1.Images[21]; break;
                case 22: pictureBox1.Image = ımageList1.Images[22]; break;
                case 23: pictureBox1.Image = ımageList1.Images[23]; break;
                case 24: pictureBox1.Image = ımageList1.Images[24]; break;
                
            }
            switch (para)
            {
                case 5: pictureBox2.Image = ımageList2.Images[1]; break;//paraya göre resim.
                case 10: pictureBox2.Image = ımageList2.Images[2]; break;
                case 20: pictureBox2.Image = ımageList2.Images[3]; break;
                case 25: pictureBox2.Image = ımageList2.Images[4]; break;
                case 50: pictureBox2.Image = ımageList2.Images[5]; break;
                case 100: pictureBox2.Image = ımageList2.Images[6]; break;
                case 200: pictureBox2.Image = ımageList2.Images[7]; break;
                case 250: pictureBox2.Image = ımageList2.Images[8]; break;
                case 500: pictureBox2.Image = ımageList2.Images[9]; break;
                case 750: pictureBox2.Image = ımageList2.Images[10]; break;
                case 1000: pictureBox2.Image = ımageList2.Images[11]; break;
                case 2500: pictureBox2.Image = ımageList2.Images[12]; break;
                case 5000: pictureBox2.Image = ımageList2.Images[13]; break;
                case 7500: pictureBox2.Image = ımageList2.Images[14]; break;
                case 10000: pictureBox2.Image = ımageList2.Images[15]; break;
                case 20000: pictureBox2.Image = ımageList2.Images[16]; break;
                case 25000: pictureBox2.Image = ımageList2.Images[17]; break;
                case 50000: pictureBox2.Image = ımageList2.Images[18]; break;
                case 75000: pictureBox2.Image = ımageList2.Images[19]; break;
                case 100000: pictureBox2.Image = ımageList2.Images[20]; break;
                case 200000: pictureBox2.Image = ımageList2.Images[21]; break;
                case 250000: pictureBox2.Image = ımageList2.Images[22]; break;
                case 500000: pictureBox2.Image = ımageList2.Images[23]; break;
                case 1000000: pictureBox2.Image = ımageList2.Images[24]; break;
            }


        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
