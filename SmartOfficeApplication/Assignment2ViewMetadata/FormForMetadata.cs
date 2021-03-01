using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            try
            {
                InitializeComponent();
                UpdateComboBoxWithTables();
                UpdateColumnList();
            }catch(ArgumentException)
            {
                labelFeedback.Text = "Please check your VPN connection.";
            }
            
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            UpdateComboBoxWithTables();
        }

        private void UpdateComboBoxWithTables()
        {
            try
            {
                DataTable tableNames = data.GetTablesOfInterest();
                comboBoxTables.DataSource = tableNames;
                comboBoxTables.DisplayMember = "tableName";
                comboBoxTables.ValueMember = "tableName";

            }catch(ArgumentException)
            {
                labelFeedback.Text = "Please check your VPN connection.";
            }
            
        }
        private void UpdateColumnList()
        {
            labelFeedback.Text = "";
            //Declaring a default selectedTableName string.
            string selectedTableName = "";
            //Gets selected Table name from the combobox.
            try
            {
                selectedTableName = comboBoxTables.SelectedValue.ToString();
                updateAmountOfRowsLabel();
            }
            catch (NullReferenceException)
            {
                labelFeedback.Text = "Please check your VPN connection";
            }
            catch (ArgumentException)
            {
                labelFeedback.Text = "Please check your VPN connection";
            }


            try
            {
                    //Gets a dataset with columns for the given tableName.
                    if (!selectedTableName.Equals(""))
                {
                    DataTable columnList = data.GetColumnsForTable(selectedTableName);
                    listBoxColumns.DataSource = columnList;
                    listBoxColumns.DisplayMember = "name";
                    listBoxColumns.ValueMember = "name";
                }
            
                else {
                    //TO-DO - improve error handling.
                    Console.WriteLine("No selected table name.");
                }
            }
            catch (NullReferenceException)
            {
                labelFeedback.Text = "Please check your VPN connection";
            }
            catch (ArgumentException)
            {
                labelFeedback.Text = "Please check your VPN connection";
            }
        }

        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateColumnList();
        }
        private void updateAmountOfRowsLabel()
        {
            try
            {
                string selectedTableName = comboBoxTables.SelectedValue.ToString();
                int rowCount = data.GetRowCountForTable(selectedTableName);
                labelAmountOfRows.Text = "This table has " + rowCount + " rows";

            } catch(SqlException exe)
            {
                labelFeedback.Text = "Please check your VPN connection";
            }
            
        }
    }
}
