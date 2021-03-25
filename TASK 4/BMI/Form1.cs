using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class BMIFrm : Form
    {
        public BMIFrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void InchesBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FeetLabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double BMI, weight, feet, inches, height;
            string results = ""; //results of the attempt to calculate BMI 
            bool isValid = true; //IS THE FORM VALID?
            if (!double.TryParse(WeightBox.Text, out weight))
            {
                results += "\nPlease enter your weight in number format.";
                isValid = false;
            }
            if (!double.TryParse(FeetBox.Text, out feet))
            {
                results += "\nPlease enter your feet in number format.";
                isValid = false;
            }
            if (!double.TryParse(InchesBox.Text, out inches))
            {
                results += "\nPlease enter your inches in number format.";
                isValid = false;
            }
            //is the form valid?
            if (isValid)
            {
                height = feet * 12 + inches;
                //calculate bmi
                BMI = weight / Math.Pow(height, 2) * 703;
                //show the BMI
                //MessageBox.Show("Your calculated BMI is " + Math.Round(BMI,2));
                BMIlbl.Text = Math.Round(BMI, 2).ToString();
            }
            else
            {
                MessageBox.Show("There was a problem with your form\n" + results);
            }

        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            WeightBox.Text = "";
            FeetBox.Text = "";
            InchesBox.Text = "";
            BMIlbl.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
