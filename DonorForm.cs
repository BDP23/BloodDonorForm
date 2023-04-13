using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodDonorForm
{
    public partial class DonorForm : Form
    {
        public DonorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = tbFirstName.Text;
                string lastName = tbLastName.Text;
                var dateOfBirth = dtpDateofBirth.Value;
                var bloodType = cbBloodGroup.SelectedItem;
                string address = tbAddress.Text;

                var isValid = true;

                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
                {
                    isValid = false;
                    MessageBox.Show("Please enter missing data!");


                }
                if (isValid == true)
                {
                    MessageBox.Show($"FirstName: {firstName}\n\r" +
                       $"LastName: {tbLastName}\n\r" +
                       $"Address: {tbAddress}\n\r" +
                       $"Date of Birth: {dtpDateofBirth}\n\r" +
                       $"Blood Group:  {cbBloodGroup}\n\r" +
                       $"THANK YOU FOR DONATING!!"
                       );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
                
            
               
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_Click(object sender, EventArgs e)
        {

        }

        private void TbFirstName_Click(object sender, EventArgs e)
        {
          
        }
    }
}
