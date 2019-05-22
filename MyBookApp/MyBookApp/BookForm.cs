using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBookApp
{
    public partial class BookForm : Form
    {
       
        public BookForm()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(  "                                           "+customerinformation.Text+ "\n");
            listBox1.Items.Add("Customer Name : "+nameTextBox.Text);
            listBox1.Items.Add("Contact No : "+contactTextBox.Text);
            listBox1.Items.Add("Address : " + addressTextBox.Text);
            listBox1.Items.Add("Order : "+orderComboBox.Text);
            listBox1.Items.Add("Quantity : " + quantityTextBox.Text);

            //MessageBox.Show("Customer Name: "+ nameTextBox.Text+ "\nContact No: " + contactTextBox.Text+"\nAddress: " + addressTextBox.Text+"\nOrder: " +orderComboBox.Text+"\nQuantity: "+ quantityTextBox.Text);
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
      

        }
    }
}
