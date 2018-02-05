using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LakeOfSorrowProduction
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pathTextBox.Text = openFileDialog1.FileName; //Торвальдс покарает меня и за это за одно
        }

        private void rButton_Click(object sender, EventArgs e) //Настало время говнокодить :E)))
        {
            double[] xses = new double[4];
            double[] yses = new double[4];
            try
            {
                xses[0] = Double.Parse(tbx1.Text);
                xses[1] = Double.Parse(tbx2.Text);
                xses[2] = Double.Parse(tbx3.Text);
                xses[3] = Double.Parse(tbx4.Text);
                //================================
                yses[0] = Double.Parse(tby1.Text);
                yses[1] = Double.Parse(tby2.Text);
                yses[2] = Double.Parse(tby3.Text);
                yses[3] = Double.Parse(tby4.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка в значениях " + ex.Message);
            }
            try
            {
                Rectangle rectangle = new Rectangle(xses, yses);
                AnswerLabel.Text = (rectangle.Diagonal()).ToString();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Ошибка аргументов " + ex.Message);
            }
        }

        private void doItButton_Click(object sender, EventArgs e)
        {
            try
            {
                StringFormatter stringFormatter = new StringFormatter();
                pAnswerLabel.Text = stringFormatter.ShortFileString(pathTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void doIt2Button_Click(object sender, EventArgs e)
        {
            int[] workArr = { 1, 2, 4444, 333, 5457, -10, -140, -4545, -777, 0, 55 };
            ArrayProcessor arrayProcessor = new ArrayProcessor();
            int[] resultArr = arrayProcessor.SortAndFilter(workArr);
            resultArLabel.Text = (string.Join(" ", resultArr.Select(x => x.ToString())));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
