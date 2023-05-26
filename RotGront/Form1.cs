using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RotGront
{
    public partial class RotoGrönt : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wowpojken\Documents\dbROG.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
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
            dateTimePicker.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Spara alla värden i fälten
            string id = IdTextBox.Text;
            string name = nameTextBox.Text;
            string quantity = quantityTextBox.Text;
            string description = descriptionTextBox.Text;
            string category = (string)categoryBox.SelectedItem;
            string date = (string)dateTimePicker.Text;

            cm = new SqlCommand("INSERT INTO [Table](id, name, quantity, description, category)VALUES(@id, @name, @quantity, @description, @category)",con);
            cm.Parameters.AddWithValue("@id", IdTextBox.Text);
            cm.Parameters.AddWithValue("@name", nameTextBox.Text);
            cm.Parameters.AddWithValue("@quantity", quantityTextBox.Text);
            cm.Parameters.AddWithValue("@description", descriptionTextBox.Text); 
            cm.Parameters.AddWithValue("@category", categoryBox.Text);
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();

            //Lägg till värden
            inventory.Rows.Add(id, name, quantity, description, category, date);

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

                dateTimePicker.Text = inventory.Rows[dataGridView.CurrentCell.RowIndex].ItemArray[6].ToString();
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
            inventory.Columns.Add("Datum");

            dataGridView.DataSource= inventory;
        }
    }
}
