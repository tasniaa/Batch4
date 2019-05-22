using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

           string firstName = firstNameTextBox.Text;
           string lastName = lastNameTextBox.Text;
           string fathersName = fatherNameTextBox.Text;
           string mothersName = motherNameTextBox.Text;    
            string address = addressTextBox.Text;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tShow All information \n\n"+ "\nFirst Name : "+ firstNameTextBox.Text+"\nlastNameTextBox Name : "+lastNameTextBox.Text+ "\nFather's Name : "+fatherNameTextBox.Text+"\nMather's Name : "+ motherNameTextBox.Text+ "\naddress: " + addressTextBox.Text);
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tFullName : " + firstNameTextBox.Text + " " + lastNameTextBox.Text);
        }

        private void ParentNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tParent Name " + "\nFather's Name : " + fatherNameTextBox.Text + "\nMather's Name: " + motherNameTextBox.Text);
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tFull Address : "+ addressTextBox.Text);
        }
    }
}
