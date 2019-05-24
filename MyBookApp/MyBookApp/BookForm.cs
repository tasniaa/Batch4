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
        int index = 1;
        int price;





        private void SaveButton_Click(object sender, EventArgs e)
        {
            const int size = 100;
            string[] CustomerName = new string[size];
            int[] ContactNo = new int[size];
            string[] Address = new string[size];
            string[] Order = new string[size];
            int [] Quantity = new int [size];
            int[] Total = new int[size];



            CustomerName[index] = nameTextBox.Text;
            ContactNo[index] = Convert.ToInt32(contactTextBox.Text);
            Address[index] = addressTextBox.Text;
            Order[index] = orderComboBox.Text;
            Quantity[index] = Convert.ToInt32(quantityTextBox.Text);


            if (Order[index].Equals("Math"))
            {
                price = 120;

            }
            else if (Order[index].Equals("English"))
            {
                price = 100;

            }
            else if (Order[index].Equals("Bangla"))
            {
                price = 90;

            }
            else if (Order[index].Equals("Art"))
            {
                price = 80;

            }
            Total[index] = Convert.ToInt32(Quantity[index]) * price;

            saveRichTextBox.SelectedText = ("\n\tCustomer Number " + index + ". Order Information : \n\n");
            saveRichTextBox.SelectedText = (" Name :   " + CustomerName[index] + "\n");
            saveRichTextBox.SelectedText = (" Contact No :   " + ContactNo[index] + "\n");
            saveRichTextBox.SelectedText = (" Address :   " + Address[index] + "\n");
            saveRichTextBox.SelectedText = (" Order :   " + Order[index] + "\n");
            saveRichTextBox.SelectedText = (" Quantity :   " + Quantity[index] + "\n");
            saveRichTextBox.SelectedText = (" Total Price :   " + Total[index] + " Tk.\n");
            index++;

            nameTextBox.Clear();
            contactTextBox.Clear();
            addressTextBox.Clear();
            orderComboBox.ResetText();
            quantityTextBox.Clear(); ;
        }

    }
}

       

