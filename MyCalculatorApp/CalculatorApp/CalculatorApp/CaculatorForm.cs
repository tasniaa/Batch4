using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CaculatorForm : Form
    {
        DataTable table = new DataTable();
        public CaculatorForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double FirstNumber = Convert.ToDouble(firstNumerTextBox.Text);
            double SecondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double Result = (FirstNumber + SecondNumber);
            resultTextBox.Text = Convert.ToString(Result);
            FirstNumber = Result;
     
           
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            double FirstNumber = Convert.ToDouble(firstNumerTextBox.Text);
            double SecondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double Result = (FirstNumber - SecondNumber);
            resultTextBox.Text = Convert.ToString(Result);
            FirstNumber = Result;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            double FirstNumber = Convert.ToDouble(firstNumerTextBox.Text);
            double SecondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double Result = (FirstNumber * SecondNumber);
            resultTextBox.Text = Convert.ToString(Result);
            FirstNumber = Result;
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            double FirstNumber = Convert.ToDouble(firstNumerTextBox.Text);
            double SecondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double Result = (FirstNumber / SecondNumber);
            resultTextBox.Text = Convert.ToString(Result);
            FirstNumber = Result;
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNumerTextBox.Clear();
            secondNumberTextBox.Clear();
            resultTextBox.Clear();
            
        }
    }
}
