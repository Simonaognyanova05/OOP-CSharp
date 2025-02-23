using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    public partial class frmFaces : Form
    {
        public frmFaces()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<Face> faces = new List<Face>();
            string names = txtFaces.Text;
            faces.Add(new Face { Names = names });

            foreach(Face face in faces)
            {
                lstFaces.Items.Add(face);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstFaces.Items.Remove(lstFaces.SelectedItem);
        }
    }
}
