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

namespace SmartOfficeApplication
{
    public partial class Form1 : Form
    {
        private DataAccessLayer dataAccessLayer = new DataAccessLayer();

        public void updateBuildingList() //Update listBoxBuildings with all buildings in the database.
        {
            listBoxBuildings.Items.Clear();
            SqlDataReader buildingReader = dataAccessLayer.GetBuildings(); //Fetch data and hold it in buildingList.
            while (buildingReader.Read())
            {
                listBoxBuildings.Items.Add(buildingReader.GetString(0));
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonAddBuilding_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPageBuilding_Click(object sender, EventArgs e)
        {

        }


        private void radioButtonAddBuilding_CheckedChanged_1(object sender, EventArgs e) 
        {

        }

        private void radioButtonEditBuilding_CheckedChanged(object sender, EventArgs e) 
        {

        }

        /*****************.
           *  Button             addBuilding
           *   Description        button that, if successful, adds a building in the database by checking if the radiobutton radioButtonAddBuilding has been 
                                   selected and then if the textbox has any content. It also checks the database if the address already exists before adding
                                   it to the database. Though if radiobutton radioButtonEditBuilding has been selected the address can be altered using the
                                   combination of combobox(for the old address) and textbox(to insert new address).
           ***********/
        private void buttonAddBuilding_Click(object sender, EventArgs e) //Knappen
        {
            labelFeedbackForBuildings.ResetText(); //return the label to default 
            string newAddress = textBoxAddress.Text; //retrieves text from textbox

           if (radioButtonAddBuilding.Checked == true)
            {
                if (newAddress.Equals(""))
                {
                    //Error message if the textbox is empty
                    labelFeedbackForBuildings.Text = "To add a new building, please insert address.";
                }
                
                //if(address !=  )
                dataAccessLayer.AddBuilding(newAddress);
                labelFeedbackForBuildings.Text = "The building with address'" + newAddress + "' has been successfully added to database.";
            }

           if (radioButtonEditBuilding.Checked == true)
            {
                string oldAddress = comboBoxOldAddress.SelectedItem.ToString();

                //Kolla om den nya addressen redan existerar
                //felmeddelande om comboboxen inte har några alternativ

                dataAccessLayer.EditBuilding(oldAddress, newAddress);
                labelFeedbackForBuildings.Text = "The building with address'" + oldAddress + "' has been successfully changed into '" + newAddress + "' within the database.";

            }

            else
            {
                labelFeedbackForBuildings.Text = "To add a new building, please press the radiobutton add building."; //fixa så edit är med
            }

        }
          private void comboBoxAddressDelete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void buttonDeleteBuilding_Click(object sender, EventArgs e)
        {

            labelFeedbackForBuildings.ResetText();
            if (radioButtonAddBuilding.Checked == true)
            {
                string address = comboBoxAddressDelete.SelectedItem.ToString();
                dataAccessLayer.RemoveBuilding(address);

            }
            labelFeedbackForBuildings.Text = "Building has been removed!";
        }

        private void radioButtonAddBuilding_CheckedChanged_2(object sender, EventArgs e)
        {
           
        }

        private void radioButtonEditBuilding_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonViewOffices_Click(object sender, EventArgs e)
        {
            
            try
            {
                string selectedAddress = comboBoxAddressViewOffices.SelectedValue.ToString();
                SqlDataReader offices = dataAccessLayer.GetOffices(selectedAddress);
                DataTable officeTable = new DataTable();
                officeTable.Load(offices);
                dataGridViewOffices.DataSource = officeTable;
            }
            catch (NullReferenceException exception)
            {
                labelFeedbackForOfficesTab.Text = "Please select a valid address to display its offices. If there are no addresses please create one.";
            }
        }

        private void trackBarTemperature_Scroll(object sender, EventArgs e)
        {
            labelSelectedTemperature.Text = trackBarTemperature.Value + " °C";
        }
    }
}
