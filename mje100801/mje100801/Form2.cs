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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "비프킹")
            {
                textBox1.Text = "14900";
            }
            else
            {
                if(comboBox1.Text == "갈릭버터")
                {
                    textBox1.Text = "30000";
                }
                else
                {
                    if(comboBox1.Text == "치즈불고기")
                    {
                        textBox1.Text = "23500";
                    }
                    else
                    {
                        //넣을게 없어서
                        //필요없음
                        textBox1.Text = "21000";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pr = 0; //가격
            int ge = 0; //수량
            int mo = 0; //지불금액

            if (comboBox1.Text == "")
            {
                MessageBox.Show("피자를 선택하세요");
                return;
            }
            if (comboBox2.Text == "")
            {
                MessageBox.Show("수량을 선택하세요");
                return;
            }
            pr = int.Parse(textBox1.Text);
            ge = int.Parse(comboBox2.Text);

            mo = pr * ge;
            textBox2.Text = mo.ToString();
        }
    }
}
