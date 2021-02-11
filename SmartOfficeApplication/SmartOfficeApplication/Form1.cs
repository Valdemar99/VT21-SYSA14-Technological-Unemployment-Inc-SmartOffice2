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
        private ErrorHandler errorHandler = new ErrorHandler();

        public void UpdateBuildingData() //Updates all comboboxes and lists with buildings.
        {
            comboBoxOfficeAddress.Items.Clear();
            comboBoxOfficeAddressDelete.Items.Clear();
            comboBoxAddressViewOffices.Items.Clear();
            comboBoxOldAddress.Items.Clear();
            comboBoxAddressDelete.Items.Clear();

            listBoxBuildings.Items.Clear();

            SqlDataReader buildingReader = dataAccessLayer.GetBuildings(); //Fetch data and hold it in buildingList.
            while (buildingReader.Read())
            {
                comboBoxOfficeAddress.Items.Add(buildingReader.GetString(0));
                comboBoxOfficeAddressDelete.Items.Add(buildingReader.GetString(0));
                comboBoxAddressViewOffices.Items.Add(buildingReader.GetString(0));
                comboBoxOldAddress.Items.Add(buildingReader.GetString(0));
                comboBoxAddressDelete.Items.Add(buildingReader.GetString(0));
                listBoxBuildings.Items.Add(buildingReader.GetString(0));
            }
            buildingReader.Close();
            dataAccessLayer.CloseConnection();
        }

        public Form1()
        {
            InitializeComponent();
            fillVentilationSettingComboBox();
            UpdateBuildingData();
        }
        

        /*****************.
           *  Button             addBuilding
           *   Description        button that, if successful, adds a building in the database by checking if the radiobutton radioButtonAddBuilding has been 
                                   selected and then if the textbox has any content. It also checks the database if the address already exists before adding
                                   it to the database. Though if radiobutton radioButtonEditBuilding has been selected the address can be altered using the
                                   combination of combobox(for the old address) and textbox(to insert new address).
           ***********/
        private void buttonAddBuilding_Click(object sender, EventArgs e) 
        {
             //return the label to default 
            labelFeedbackForDeletingBuilding.ResetText();

            string newAddress = textBoxAddress.Text; //retrieves text from textbox

           if (radioButtonAddBuilding.Checked == true)
            {
                if (newAddress.Equals(""))//Error message if the textbox is empty
                {
                    labelFeedbackForBuildings.Text = "To add a new building, please insert address.";
                }

                else
                {
                    if (dataAccessLayer.checkIfBuildingExists(newAddress) == true) // If the address already exists it sends an error message
                    {
                        labelFeedbackForBuildings.Text = "This building with inserted address already exists in our database.";
                    }
                    if (dataAccessLayer.checkIfBuildingExists(newAddress) != true) //Checks if the address doesn't exist in the database, if so, adds a new building
                    {
                        dataAccessLayer.AddBuilding(newAddress);
                        labelFeedbackForBuildings.Text = "The building with address'" + newAddress + "'\nhas been successfully added to database.";
                        UpdateBuildingData();
                    }
                    
                }
            }

           if (radioButtonEditBuilding.Checked == true) //If edit building is chosen
            {
                try
                {
                    string oldAddress = comboBoxOldAddress.SelectedItem.ToString();
                    //Checks if the old address doesn't exist in the database, if so, change to address in new address textbox
                    if (dataAccessLayer.checkIfBuildingExists(oldAddress) == true)
                    {
                        if (newAddress.Equals(""))//Error message if the textbox is empty
                        {
                            labelFeedbackForBuildings.Text = "To edit a new building, please insert the new address.";
                        }
                        else
                        { //Checks if the new address doesn't exist in the database, if so, edits the old address to the new one 

                            if (dataAccessLayer.checkIfBuildingExists(newAddress) == true) // If the new address already exists it sends an error message
                            {
                                labelFeedbackForBuildings.Text = "This building with inserted new address already exists\n in our database. Please try another another address.";
                            }

                            if(dataAccessLayer.checkIfBuildingExists(newAddress) != true)
                            {
                                dataAccessLayer.EditBuilding(oldAddress, newAddress);
                                labelFeedbackForBuildings.Text = "The building with address'" + oldAddress + "' has been successfully \nchanged into '" + newAddress + "' within the database.";
                                UpdateBuildingData();

                            }

                        }


                    }

                } catch(NullReferenceException ex)
                {
                    labelFeedbackForBuildings.Text = "Please choose address to edit";

                }
            }
        }
          private void comboBoxAddressDelete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /*****************.
                  *  Button             deleteBuilding
                  *   Description        button that, if successful, deletes chosen building from the database. 
                  *                      This is enabled through alternatives in combobox
                  ***********/

        private void buttonDeleteBuilding_Click(object sender, EventArgs e)
        {

            labelFeedbackForBuildings.ResetText();
            labelFeedbackForDeletingBuilding.ResetText();

            string address = comboBoxAddressDelete.SelectedItem.ToString();
            dataAccessLayer.RemoveBuilding(address);
            dataAccessLayer.CloseConnection();

            labelFeedbackForDeletingBuilding.Text = "Building has been removed!";
            UpdateBuildingData();
        }
        /*****************.
                         *  Button             viewOffices
                         *   Description        Displays all offices on a selected address. If no address is selected,
                         *                      an error message is displayed in a text label at the bottom of the frame.
            ***********/
        private void buttonViewOffices_Click(object sender, EventArgs e)
        {
            labelFeedbackForOffices.ResetText();
            labelFeedbackLabelForDeletingOffice.ResetText();
            try
            {
                string selectedAddress = comboBoxAddressViewOffices.SelectedItem.ToString();
                SqlDataReader offices = dataAccessLayer.GetOffices(selectedAddress);
                DataTable officeTable = new DataTable();
                officeTable.Load(offices);
                dataGridViewOffices.DataSource = officeTable;
                offices.Close();
                dataAccessLayer.CloseConnection();
            }
            catch (NullReferenceException exception)
            {
                labelFeedbackForViewingOffices.Text = "Please select a valid address to display its offices. " +
                    "\nIf there are no addresses please create one.";

            }
        }

        private void trackBarTemperature_Scroll(object sender, EventArgs e)
        {
            labelSelectedTemperature.Text = trackBarTemperature.Value + " °C";
        }

        /*****************.
                  *  Button             deleteOffice
                  *   Description        button that, if successful, deletes chosen building from the database. This is enabled through alternatives in combobox
                  ***********/
        private void buttonDeleteOffice_Click(object sender, EventArgs e)
        {
            labelFeedbackForOffices.ResetText();
            labelFeedbackForViewingOffices.ResetText();
            
            if (comboBoxOfficeNumberDelete.SelectedIndex != -1)
            {
                string number = comboBoxOfficeNumberDelete.SelectedItem.ToString();
                string address = comboBoxOfficeAddressDelete.SelectedItem.ToString();
                dataAccessLayer.RemoveOffice(number, address);
                UpdateOfficeNumberComboBoxes();
                labelFeedbackLabelForDeletingOffice.Text = "Office deleted.";
                
            }
            else
            {
                if (comboBoxOfficeNumberDelete.Items.Count > 0)
                {
                    labelFeedbackLabelForDeletingOffice.Text = "Please select an office to delete.";
                }
                else
                {
                    labelFeedbackLabelForDeletingOffice.Text = "No offices left to delete.";
                }
            }
        }

   
        private void comboBoxOfficeAddressDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateOfficeNumberComboBoxes();
        }

        private void comboBoxOfficeAddress_SelectedIndexChanged(object sender, EventArgs e) //Updates the office number combobox under the address combobox
        {
            UpdateOfficeNumberComboBoxes();
        }

        private void radioButtonAddOffice_CheckedChanged(object sender, EventArgs e) //Changes the text on the button from "Edit office" to "Add office" or vice versa depending on the selected radio button.
        {
            if(radioButtonAddOffice.Checked)
            {
                buttonAddOffice.Text = "Add office";
                comboBoxOfficeNumber.Enabled = false;
            }
            else
            {
                buttonAddOffice.Text = "Edit office";
                comboBoxOfficeNumber.Enabled = true;
            }
        }

        private void fillVentilationSettingComboBox()
        {
            VentilationSetting vS = new VentilationSetting();
            comboBoxVentilationSetting.DataSource = vS.VentilationSettingList.ToList<string>();
        }
        //Fill an officeNumber ComboBox given a selected building address.
        private void FillOfficeNumberComboBox(string buildingAddress, ComboBox officeNumberComboBox)
        {

            officeNumberComboBox.Items.Clear();
            SqlDataReader officeReader = dataAccessLayer.GetOffices(buildingAddress); //Fetch data and hold it in buildingList.
            while (officeReader.Read())
            {
                officeNumberComboBox.Items.Add(officeReader.GetString(1));
            }
            officeReader.Close();
            dataAccessLayer.CloseConnection();
        }

        //Update all office number comboboxes.
        private void UpdateOfficeNumberComboBoxes()
        {
            if (comboBoxOfficeAddress.SelectedIndex != -1) //If an object in the combobox is selected, the combobox with office numbers is updated.
            {
                string selectedAddress = comboBoxOfficeAddress.SelectedItem.ToString();
                FillOfficeNumberComboBox(selectedAddress, comboBoxOfficeNumber);

            }
            else
            {
                comboBoxOfficeNumber.Items.Clear();
            }
            if (comboBoxOfficeAddressDelete.SelectedIndex != -1) //If an object in the combobox is selected, the combobox with office numbers is updated.
            {
                string selectedAddress = comboBoxOfficeAddressDelete.SelectedItem.ToString();
                FillOfficeNumberComboBox(selectedAddress, comboBoxOfficeNumberDelete);
            }
            else
            {
                comboBoxOfficeNumberDelete.Items.Clear();
            }
            if (comboBoxOfficeNumberDelete.Items.Count > 0)
            {
                comboBoxOfficeNumberDelete.SelectedIndex = 0;
            }
            else
            {
                comboBoxOfficeNumberDelete.Text = "";
            }
            if (comboBoxOfficeNumber.Items.Count > 0)
            {
                comboBoxOfficeNumber.SelectedIndex = 0;
            }
            else
            {
                comboBoxOfficeNumber.Text = "";
            }
        }

        private void radioButtonAddBuilding_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAddBuilding.Checked)
            {
                buttonAddBuilding.Text = "Add building";
                comboBoxOldAddress.Enabled = false;
            }
            else
            {
                buttonAddBuilding.Text = "Edit building";
                comboBoxOldAddress.Enabled = true;
            }
        }

        /*****************.
          *  Button             addOffice
          *   Description        button that, if successful, adds an office in the database by checking if the radiobutton radioButtonAddOffice has been 
                                  selected and then if the textbox has any content. It also automatically allocates an office number.
                                  Though if radiobutton radioButtonEditBuilding has been selected the address can be altered using the
                                  combination of comboboxes for selecting a building address, office number, ventilation setting and temperature setting.
                                  TO-DO: office numbers should be autogenerated from the SQL side of the application.
          ***********/

        private void buttonAddOffice_Click_1(object sender, EventArgs e)
        {
            labelFeedbackForViewingOffices.ResetText();
            labelFeedbackLabelForDeletingOffice.ResetText();

            string buildingAddress = comboBoxOfficeAddress.SelectedItem.ToString(); //retrieves address
            string ventilationSetting = comboBoxVentilationSetting.SelectedItem.ToString(); //retrieves ventilation setting
            int temperatureSetting = trackBarTemperature.Value;

            if (radioButtonAddOffice.Checked == true)
            {
                
                if (buildingAddress.Equals(""))//Error message if the combobox is empty
                {
                    labelFeedbackForOffices.Text = "To add a new office, please insert an address.";
                }
                else if (ventilationSetting.Equals(""))
                {
                    labelFeedbackForOffices.Text = "To add a new office, please choose a ventilation setting.";
                }
                dataAccessLayer.AddOffice(buildingAddress, temperatureSetting, ventilationSetting);
                string officeNumber = dataAccessLayer.GetMostRecentOfficeNumber();
                string feedbackString = "The office with officenumber '" + officeNumber + "'\nand address '" + buildingAddress + "' has been successfully added.";
                labelFeedbackForOffices.Text = feedbackString;
                UpdateOfficeNumberComboBoxes();
            }

            else if (radioButtonEditOffice.Checked == true) //If edit building is chosen
            {
                object officeNumberObject = comboBoxOfficeNumber.SelectedItem;
                if (buildingAddress.Equals(""))//Error message if no address is chosen
                {
                    labelFeedbackForOffices.Text = "To edit this office, please insert an address.";
                }
                else if (ventilationSetting.Equals("")) //Error message if no ventilation setting is chosen
                {
                    labelFeedbackForOffices.Text = "To edit this office, please choose a ventilation setting.";
                }
                else if (officeNumberObject == null) //Error message if no office number is chosen
                {
                    labelFeedbackForOffices.Text = "To edit an office, please choose an office number.";
                }
                else
                {
                    string officeNumberToEdit = officeNumberObject.ToString();
                    dataAccessLayer.EditOffice(officeNumberToEdit, buildingAddress, ventilationSetting, temperatureSetting);
                    labelFeedbackForOffices.Text = "The office with address '" + buildingAddress + "' and office number '" + officeNumberToEdit + "'\nhas been successfully edited.";
                }
            }
            else
            {
                labelFeedbackForOffices.Text = "To add a new office, please press the radiobutton add office."; //fixa så edit är med
            }
        }
    }
}

