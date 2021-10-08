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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pr = 0; //가격
            double ge = 0; //수량
            double to = 0; //주문금액

            if(radioButton1.Checked == true)
            {
                //짜장면이 선택되어 있는 경우
                pr = 4000;
            }
            else
            {
                if(radioButton2.Checked == true) 
                {
                    pr = 5000;
                }
                else
                {
                    if (radioButton3.Checked == true)
                    {
                        pr = 15000;
                    }
                    else
                    {
                        pr = 7000;
                    }
                }
            }
             if(textBox1.Text == "")
            {
                MessageBox.Show("수량을 선택하세요");
                return;
            }
            ge = double.Parse(textBox1.Text);

            if (ge >= 4)
            {
                to = pr * ge;
                to = to * 0.9;
            }
            else
            {
                to = pr * ge;

            }
            textBox2.Text = to.ToString();
        }
    }
}
