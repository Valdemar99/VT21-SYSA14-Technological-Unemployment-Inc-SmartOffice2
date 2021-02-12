﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2ViewMetadata
{
    class DataAccessLayerForMetaData
    {
        private static string serverName = "uwdb18.srv.lu.se";
        private static string instanceName = "icssql001";
        private static string databaseName = "SYSA14_PK_ProgAssignment2";
        private static string userName = "sysa14reader";
        private static string userPassword = "INFreader1";
        private static string connectionString = "Server=" + serverName + "\\" + instanceName + ";Database=" + databaseName + ";User Id = " + userName + "; Password = " + userPassword;

        public DataTable GetTablesOfInterest()
        {
            DataTable officeTable = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM TablesOfInterest", sqlConnection))
                {
                    try
                    {
                        sqlConnection.Open();
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            officeTable.Load(dataReader);
                            return officeTable;
                        }
                    }
                    catch (SqlException)
                    {
                        Console.WriteLine("Exception!");
                    }
                }
            }
            return officeTable;
        }
        public DataTable GetAllColumns(string tableName)
        {
            /*
            // SELECT *
            //         FROM sys.columns c
            //WHERE c.object_id = (
            //    SELECT o.object_id
            //    FROM sys.objects o
            //    WHERE o.name = 'tableName')
             */
            String query = "SELECT name FROM sys.columns c " +
                "WHERE c.object_id = (SELECT o.object_id FROM sys.objects o WHERE o.name = '" + tableName + "')";
            DataTable columnTable = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    try
                    {
                        sqlConnection.Open();
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            columnTable.Load(dataReader);                      
                            return columnTable;
                        }
                    }
                    catch (SqlException)
                    {
                        Console.WriteLine("Exception!");
                    }
                }
            }
            return columnTable;
        }

        public DataTable GetAllTables()
        {
            //            SELECT c.name, o.name
            //         FROM sys.columns c
            //WHERE c.object_id = (
            //    SELECT o.object_id
            //    FROM sys.objects o)
	
            String query = "SELECT * FROM sys.columns c " +
                "WHERE c.object_id = (SELECT o.object_id FROM sys.objects o)";
            DataTable tableTable = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    try
                    {
                        sqlConnection.Open();
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            tableTable.Load(dataReader);
                            return tableTable;
                        }
                    }
                    catch (SqlException)
                    {
                        Console.WriteLine("Exception!");
                    }
                }
            }
            return tableTable;
        }
    }
}