using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tyear1_TextChanged(object sender, EventArgs e)
        {

        }
        //获取数据，计算
        private void button1_Click(object sender, EventArgs e)
        {
            double tou , x;
            double[] a = new double[5];
            
            if(!(tyear1.Text.Trim().Equals("") || tyear2.Text.Trim().Equals("") || tyear3.Text.Trim().Equals("")
                || tyear4.Text.Trim().Equals("") || tyear5.Text.Trim().Equals("") || touru.Text.Trim().Equals("") || textBox1.Text.Trim().Equals("") ) )
            {
                tou = Convert.ToDouble(touru.Text.Trim());
                x = Convert.ToDouble(textBox1.Text.Trim());

                a[0] = Convert.ToDouble(tyear1.Text.Trim());
                a[1] = Convert.ToDouble(tyear2.Text.Trim());
                a[2] = Convert.ToDouble(tyear3.Text.Trim());
                a[3] = Convert.ToDouble(tyear4.Text.Trim());
                a[4] = Convert.ToDouble(tyear5.Text.Trim());
            }
            else
            {
                MessageBox.Show("数据没填完整");
                return;
            }
            double sum = 0;
            for(int i=1;i<6;i++)
            {
                
                double year = 0;
                year = a[i-1] / Math.Pow((1.0+x),i);
                Console.WriteLine("贴现率"+1.0/ Math.Pow((1.0 + x), i));
                Console.WriteLine("贴现值" + a[i - 1] / Math.Pow((1.0 + x), i));
                sum += year;
            }

            t_result.Text = (sum-tou).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
