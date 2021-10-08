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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hotel = 0; //호텔비
            int lisu = 0; //숙박기간
            int mo = 0; //계산

            if(comboBox1.Text == "")
            {
                MessageBox.Show("숙박기간을 선택하세요");
                return;
            }
            if(radioButton1.Checked == true)
            {
                //롯데호텔이 선택되어 있는경우
                hotel = 500000;
            }
            else
            {
                if(radioButton2.Checked == true)
                {
                    hotel = 450000;
                }
                else
                {
                    if(radioButton3.Checked == true)
                    {
                        hotel = 200000;
                    }
                    else
                    {
                        if(radioButton4.Checked == true)
                        {
                            hotel = 350000;
                        }
                        else
                        {
                            hotel = 50000;
                        }
                    }
                }
            }
            if (comboBox1.Text == "1박2일")
            {
                lisu = 1;
            }
            else
            {
                if(comboBox1.Text == "2박3일")
                {
                    lisu = 2;
                }
                else
                {
                    if (comboBox1.Text == "3박4일")
                    {
                        lisu = 3;
                    }
                    else
                    {
                        lisu = 4;
                    }
                }
            }
            mo = hotel * lisu;
            textBox1.Text = mo.ToString();
        }
    }
}
