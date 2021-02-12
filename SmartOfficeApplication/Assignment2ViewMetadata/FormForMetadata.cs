using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2ViewMetadata
{
    public partial class FormForMetadata : Form
    {
        DataAccessLayerForMetaData data = new DataAccessLayerForMetaData();
        public FormForMetadata()
        {
            InitializeComponent();
            UpdateComboBoxWithTables();
            UpdateColumnList();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            UpdateComboBoxWithTables();
        }

        private void UpdateComboBoxWithTables()
        {
            DataTable tableNames = data.GetTablesOfInterest();
            comboBoxTables.DataSource = tableNames;
            comboBoxTables.DisplayMember = "tableName";
            comboBoxTables.ValueMember = "tableName";
        }
        private void UpdateColumnList()
        {
            string selectedTableName = "";
            //Gets selected Table name from the combobox.
            try
            {

                string tableName = comboBoxTables.SelectedValue.ToString();
                UpdateColumnList(tableName);
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine("was null");
            }

            //Gets a dataset with columns for the given tableName.
            if (!selectedTableName.Equals(""))
            {
                DataTable columnList = data.GetColumnsForTable(selectedTableName);
                listBoxColumns.DataSource = columnList;
                listBoxColumns.DisplayMember = "name";
                listBoxColumns.ValueMember = "name";
            }
            
            else {
                Console.WriteLine("No selected table name.");
            }
        }

        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateColumnList();
        }
        private void updateAmountOfRowsLabel()
        {
            string selectedTableName = comboBoxTables.SelectedValue.ToString();
            int rowCount = data.GetRowCountForTable(selectedTableName);
            labelAmountOfRows.Text = "This table has " + rowCount + " rows";
        }
    }
}
