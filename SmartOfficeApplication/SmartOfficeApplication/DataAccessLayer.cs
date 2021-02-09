using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartOfficeApplication
{
    class DataAccessLayer
    {
        private SqlConnection sqlConnection;
        private string connectionString = "Server=localhost;Database=Smart Office 2.0;User Id = user2.0; Password = losen";

        public SqlConnection SqlConnection { get => SqlConnection; set => SqlConnection = value; }

        /*****************.
            *  Function             getBuildings
            *   Description         Method that, if successful, returns an sqlDataReader with all associated information from database
            *    Parameters
            *     Returns           SqlDataReader
            ***********/

        public SqlDataReader GetBuildings()
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM BUILDING", sqlConnection);
                using (sqlCommand)
                {
                    try
                    {
                        sqlConnection.Open();
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        return dataReader;
                    } catch (SqlException e) {

                        throw e;

                    } catch (Exception e)
                    {
                        throw e;
                    }
                }


            }

        }
        /*****************.
            *  Function             checkIfBuildingExists
            *   Description         Method that returns true if a building with the specified address already exists in the database.
            *    Parameters         string address
            *     Returns           bool
            ***********/

        public bool checkIfBuildingExists(string address)
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Building WHERE address = '" + address + "'", sqlConnection))
                {
                    try
                    {
                        sqlConnection.Open();
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        return dataReader.HasRows;
                    }
                    catch (SqlException e)
                    {
                        throw e;

                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
            }
        }
                    


        /*****************.
            *  Function             addBuilding
            *   Description         Method that, if successful, adds a building in the database.
            *    Parameters         string address
            *     Returns           
            ***********/
        public void AddBuilding(string address)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO Building VALUES(@address)", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@address", address);

                    try
                    {
                        sqlConnection.Open();
                        //int result = - kan användas senare för error handling
                        sqlCommand.ExecuteNonQuery();

                    }
                    catch (SqlException e)
                    {

                        throw e;

                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }

            }

        }
        /*****************.
        *  Function             removeBuilding
        *   Description         Method that, if successful, removes a building from the database and the offices that belong to it.
        *    Parameters         string address
        *     Returns           
        ***********/

        public void RemoveBuilding(string address)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("DELETE FROM Building WHERE address = '" + address + "'", sqlConnection))
                {
                    try
                    {
                        sqlConnection.Open();
                        //int result = - kan användas senare för error handling
                        sqlCommand.ExecuteNonQuery();

                    }
                    catch (SqlException e)
                    {

                        throw e;

                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
                using (SqlCommand sqlCommand = new SqlCommand("DELETE FROM Office WHERE buildingAddress = '" + address + "'", sqlConnection))
                {
                    try
                    {
                        sqlConnection.Open();
                        //int result = - kan användas senare för error handling
                        sqlCommand.ExecuteNonQuery();

                    }
                    catch (SqlException e)
                    {

                        throw e;

                    }
                    catch (Exception e)
                    {
                        throw e;
                    }

                }

            }
        }
            /*****************.
              *  Function             editBuilding
              *   Description         Method that, if successful, edits a building from the database.
              *    Parameters         string address
              *     Returns           
              ***********/

            public void EditBuilding(string oldAddress, string newAddress)
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("UPDATE Building SET address = '" + newAddress + "' WHERE address = '" + oldAddress + "'", sqlConnection))
                    {
                        try
                        {
                            sqlConnection.Open();
                            //int result = - kan användas senare för error handling
                            sqlCommand.ExecuteNonQuery();

                        }
                        catch (SqlException e)
                        {

                            throw e;

                        }
                        catch (Exception e)
                        {
                            throw e;
                        }
                    }

                }

            }
            /*****************.
            *  Function             findOffice
            *   Description         Method that, if successful, returns an sqlDataReader with all associated information from database
            *    Parameters         string officeNumber, string buildingAddress
            *     Returns           SqlDataReader
            ***********/

            public SqlDataReader FindOffice(string officeNumber, string buildingAddress)
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Office WHERE buildingAddress = '" + buildingAddress + "' AND officeNumber = '" + officeNumber + "'", sqlConnection);
                    using (sqlCommand) 
                    {
                        try
                        {
                            sqlConnection.Open();

                            SqlDataReader dataReader = sqlCommand.ExecuteReader();
                            return dataReader;


                        }
                        catch (SqlException e)
                        {

                            throw e;

                        }
                        catch (Exception e)
                        {
                            throw e;
                        }
                    }


                }

            }
            /*****************.
                *  Function             GetOffices
                *   Description         Method that, if successful, returns an sqlDataReader with all associated information from database
                *    Parameters         string buildingAddress
                *     Returns           SqlDataReader
             ***********/
            public SqlDataReader GetOffices(string buildingAddress)
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Office WHERE buildingAddress = '" + buildingAddress + "'", sqlConnection);
                    using (sqlCommand) 
                    {
                        try
                        {
                            sqlConnection.Open();
                            SqlDataReader dataReader = sqlCommand.ExecuteReader();
                            return dataReader;


                        }
                        catch (SqlException e)
                        {

                            throw e;

                        }
                        catch (Exception e)
                        {
                            throw e;
                        }
                    }


                }

            }

            /*****************.
                *  Function             AddOffice
                *   Description         Method that, if successful, adds an office in the database.
                *    Parameters         string officeNumber, string buildingAddress, int temperatureSetting, string ventilationSetting
                *     Returns           
                ***********/
            public void AddOffice(string buildingAddress, int temperatureSetting, string ventilationSetting)
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO Office VALUES(@buildingAddress, @temperatureSetting, @ventilationSetting)", sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@buildingAddress", buildingAddress);
                        sqlCommand.Parameters.AddWithValue("@temperatureSetting", temperatureSetting);
                        sqlCommand.Parameters.AddWithValue("@ventilationSetting", ventilationSetting);

                        try
                        {
                            sqlConnection.Open();
                            //int result = - kan användas senare för error handling
                            sqlCommand.ExecuteNonQuery();

                        }
                        catch (SqlException e)
                        {

                            throw e;

                        }
                        catch (Exception e)
                        {
                            throw e;
                        }
                    }

                }

            }
            /*****************.
            *  Function             RemoveOffice
            *   Description         Method that, if successful, removes an office from the database.
            *    Parameters         string officeNumber, string buildingAddress
            *     Returns           
            ***********/

            public void RemoveOffice(string officeNumber, string buildingAddress)
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("DELETE FROM Office WHERE buildingAddress = '" + buildingAddress + "' AND officeNumber = '" + officeNumber + "'", sqlConnection))
                    {
                        try
                        {
                            sqlConnection.Open();
                            //int result = - kan användas senare för error handling
                            sqlCommand.ExecuteNonQuery();

                        }
                        catch (SqlException e)
                        {

                            throw e;

                        }
                        catch (Exception e)
                        {
                            throw e;
                        }
                    }

                }

            }
            /*****************.
              *  Function             editOffice
              *   Description         Method that, if successful, edits an office from the database.
              *    Parameters         string officeNumber, string buildingAddress, string ventilationSetting, int temperatureSetting
              *     Returns           
              ***********/

            public void EditOffice(string officeNumber, string buildingAddress, string ventilationSetting, int temperatureSetting)
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("UPDATE Office SET ventilationSetting = '" + ventilationSetting + "', temperatureSetting = " + temperatureSetting + " WHERE officeNumber = '" + officeNumber + "' AND buildingAddress = '" + buildingAddress + "'", sqlConnection))
                    {
                        try
                        {
                            sqlConnection.Open();
                            //int result = - kan användas senare för error handling
                            sqlCommand.ExecuteNonQuery();

                        }
                        catch (SqlException e)
                        {
                            throw e;
                        }
                        catch (Exception e)
                        {
                            throw e;
                        }
                    }

                }

            }
        }
    }



