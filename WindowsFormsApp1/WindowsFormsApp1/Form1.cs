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
        const int size = 10;
        int[] number = new int[size];
        const int size2 = 12;
        int[] number2 = new int[size2];
        int index = 0;
       


        public Form1()
        {
            InitializeComponent();
        }
        private string Show()
        {


            string message = "";
            for (int index = 0; index < size; index++)
            {
                if (number[index] != 0)
                    message = message + ("Element of index " + index + " is " + number[index].ToString() + "\n");


            }
            return message;
        }
        private void uniqueButton_Click(object sender, EventArgs e)
        {




            string message = "";
            message = "Array with Unique list  : ";
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size;)
                {
                    if (number[j] == number[i])
                    {
                        for (int k = j; k < size; k++)
                        {
                            number[k] = number[k -1];
                        }
                        i--;
                    }
                    else
                        j++;
                }
            }

            for (int i = 0; i < size; i++)
            {
                message = message + number[i];
            }

            showRichTextBox.Text = message.ToString();
            }
        

        private void addButton_Click(object sender, EventArgs e)
        {
            index++;
            number[index] = Convert.ToInt32(numberTextBox.Text);
            showRichTextBox.Text = Show();
        }
    }
}
