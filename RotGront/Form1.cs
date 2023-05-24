using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotGront
{
    public partial class RotoGrönt : Form
    {

        DataTable inventory = new DataTable();
        public RotoGrönt()
        {
            InitializeComponent();
        }



        private void clearbutton_Click(object sender, EventArgs e)
        {
            IdTextBox.Text = "";
            nameTextBox.Text = "";
            quantityTextBox.Text = "";
            descriptionTextBox.Text = "";
            categoryBox.SelectedIndex = -1;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Spara alla värden i fälten
            string id = IdTextBox.Text;
            string name = nameTextBox.Text;
            string quantity = quantityTextBox.Text;
            string description = descriptionTextBox.Text;
            string category = (string)categoryBox.SelectedItem;

            //Lägg till värden
            inventory.Rows.Add(id, name, quantity, description, category);

            //Rensa fält efter spara
            clearbutton_Click(sender, e);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                inventory.Rows[dataGridView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception err)
            { 
                Console.WriteLine("Error: " + err);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IdTextBox.Text = inventory.Rows[dataGridView.CurrentCell.RowIndex].ItemArray[1].ToString();
                nameTextBox.Text = inventory.Rows[dataGridView.CurrentCell.RowIndex].ItemArray[2].ToString();
                quantityTextBox.Text = inventory.Rows[dataGridView.CurrentCell.RowIndex].ItemArray[3].ToString();
                descriptionTextBox.Text = inventory.Rows[dataGridView.CurrentCell.RowIndex].ItemArray[4].ToString();

                String itemToLookFor = inventory.Rows[dataGridView.CurrentCell.RowIndex].ItemArray[5].ToString();
                categoryBox.SelectedIndex = categoryBox.Items.IndexOf(itemToLookFor);
            }
            catch (Exception err)
            {
                Console.WriteLine("Något gick fel: " + err);
            }
        }

        private void RotoGrönt_Load(object sender, EventArgs e)
        {
            inventory.Columns.Add("ID");
            inventory.Columns.Add("Namn");
            inventory.Columns.Add("Kategori");
            inventory.Columns.Add("Antal");
            inventory.Columns.Add("Beskrivning");

            dataGridView.DataSource= inventory;
        }
    }
}
