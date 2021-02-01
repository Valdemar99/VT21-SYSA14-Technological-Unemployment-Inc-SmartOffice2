﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartOfficeApplication
{
    public partial class Form1 : Form
    {
        private DataAccessLayer dataAccessLayer;

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
                                   it to the database.
           ***********/
        private void buttonAddBuilding_Click(object sender, EventArgs e) //Knappen
        {
            labelFeedbackForBuildings.ResetText(); //return the label to default 

           if (radioButtonAddBuilding.Checked == true)
            {
                string address = textBoxAddress.Text; 

                if (address.Equals(""))
                {
                    //Error message if the textbox is empty
                    labelFeedbackForBuildings.Text = "To add a new building, please insert address.";
                }
                
                //if(address !=  )
                dataAccessLayer.AddBuilding(address);
                labelFeedbackForBuildings.Text = "The building with address'" + address + "' has been successfully added to database.";
            }

           if (radioButtonEditBuilding.Checked == true)
            {

            }

           else
            {
                labelFeedbackForBuildings.Text = "To add a new building, please press the radiobutton add building.";
            }

        }

        private void buttonDeleteBuilding_Click(object sender, EventArgs e)
        {


        }
    }
}
