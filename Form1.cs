using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) =>
            // TODO: This line of code loads data into the 'contactDBDataSet.People' table. You can move, or remove it, as needed.
            peopleTableAdapter.Fill(contactDBDataSet.People);

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact List 1.0.\nWritten by: Sabath Rodriguez", "About");
        }

        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peopleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contactDBDataSet);

        }

        private void peopleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel11_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
