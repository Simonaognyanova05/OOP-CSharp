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
        private List<Contact> contacts = new List<Contact>();
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
                case "2":
                    lblResult.Visible = true;
                    txtName.Visible = true;
                    btnResult.Visible = true;
                    txtEmail.Visible = false;
                    txtPhonebook.Visible = false;
                    lblResult.Text = "Search contact";
                    btnResult.Text = "Search";
                    break;
                case "3":
                    lblResult.Visible = true;
                    txtName.Visible = true;
                    btnResult.Visible = true;
                    txtEmail.Visible = false;
                    txtPhonebook.Visible = false;
                    lblResult.Text = "Delete contact";
                    btnResult.Text = "Delete";
                    break;
            }
        }

        private List<Contact> Add(List<Contact> contacts)
        {
            string name = txtName.Text;
            string phoneNumber = txtPhonebook.Text;
            string email = txtEmail.Text;

            if (name == "" || phoneNumber == "" || email == "")
            {
                MessageBox.Show("Invalid data!");
            }
            else
            {
                contacts.Add(new Contact { Name = name, PhoneNumber = phoneNumber, Email = email });
                MessageBox.Show("Contact was added successfully!");
            }

            return contacts;
        }

        private void Search(List<Contact> contacts)
        {
            string searched = txtName.Text;
            var result = contacts.FindAll(x => x.Name.Contains(searched) 
            || x.PhoneNumber.Contains(searched)
            || x.Email.Contains(searched));

            lstContacts.Items.Clear();
            if(result.Count > 0)
            {
                foreach (var contact in result)
                {
                    lstContacts.Items.Add(contact);
                }
            }
            else
            {
                lstContacts.Items.Add("This contact does not exist!");
            }
        }

        private void Delete(List<Contact> contacts)
        {
            string forDelete = txtName.Text;
            var result = contacts.Find(x => x.PhoneNumber.Contains(forDelete));
            if(result != null)
            {
                contacts.Remove(result);
                MessageBox.Show("Contact was deleted successfully!");
            }
            else
            {
                MessageBox.Show("Contact does not exists!");
            }
        }
        private void btnResult_Click(object sender, EventArgs e)
        {
            string command = txtService.Text;

            switch (command)
            {
                case "1":
                    Add(contacts);
                    break;
                case "2":
                    Search(contacts);
                    break;
                case "3":
                    Delete(contacts);
                    break;
            }
           
        }
    }
}
