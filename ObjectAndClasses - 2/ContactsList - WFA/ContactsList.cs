using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsList___WFA
{
    public partial class ContactsList : Form
    {
        public ContactsList()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ContactsList_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string command = txtService.Text;
            if(command == "")
            {
                MessageBox.Show("Please, select service!");
            }

            switch (command)
            {
                case "1":
                    lblResult.Visible = true;
                    txtName.Visible = true;
                    txtPhonebook.Visible = true;
                    txtEmail.Visible = true;
                    btnResult.Visible = true;
                    lblResult.Text = "Add contact data";
                    btnResult.Text = "Add";
                    break;
            }
        }
        private void btnResult_Click(object sender, EventArgs e)
        {
            List<Contact> contacts = new List<Contact>();
            string name = txtName.Text;
            string phoneNumber = txtPhonebook.Text;
            string email = txtEmail.Text;

            if(name == "" || phoneNumber == "" || email == "")
            {
                MessageBox.Show("Invalid data!");
            }
            else
            {
                contacts.Add(new Contact { Name = name, PhoneNumber = phoneNumber, Email = email });
                MessageBox.Show("Contact was added successfully!");
            }
        }
    }
}
