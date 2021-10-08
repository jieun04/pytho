using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mje100801
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ke = 0; // 키
            double mom = 0; //몸무게
            double po = 0; //표준몸무게
            double be = 0; //비만도
            
            ke = double.Parse(textBox1.Text);
            mom = double.Parse(textBox2.Text);

            if (ke < 150)
            {
                po = ke - 100;
                textBox3.Text = po.ToString();
            }
            else
            {
                if(ke < 160)
                {
                    po = (ke - 150) / 2 + 50;
                    textBox3.Text = po.ToString();
                }
                else
                {
                    po = (ke - 100) * 0.9;
                    textBox3.Text = po.ToString();
                }
            }
            be = (mom - po) * 100 / po; 
            if (be <= 10)
            {
                textBox4.Text = be.ToString();
                textBox5.Text = "정상";
            }
            else
            {
                if(be <= 20)
                {
                    textBox4.Text = be.ToString();
                    textBox5.Text = "과체중";
                }
                else
                {
                    textBox4.Text = be.ToString();
                    textBox5.Text = "비만"; 
                }
            }
        }
    }
}
