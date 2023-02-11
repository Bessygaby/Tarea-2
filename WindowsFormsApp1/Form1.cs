using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            double grade1 = Convert.ToDouble(txtGrade1.Text);
            double grade2 = Convert.ToDouble(txtGrade2.Text);
            double grade3 = Convert.ToDouble(txtGrade3.Text);
            double grade4 = Convert.ToDouble(txtGrade4.Text);

            double average = await CalculateAverageAsync(grade1, grade2, grade3, grade4);
            lblResult.Text = "Promedio Final: " + average.ToString("F");
        }


        private async System.Threading.Tasks.Task<double> CalculateAverageAsync(double grade1, double grade2, double grade3, double grade4)
        {
            return await System.Threading.Tasks.Task.Run(() => (grade1 + grade2 + grade3 + grade4) / 4);
        }
    }
}
