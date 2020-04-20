﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace TTN_QLBSach
{
    class DBAcess
    {
        private static SqlConnection connection = new SqlConnection();
        private static SqlCommand command = new SqlCommand();
        private static SqlDataAdapter adapter = new SqlDataAdapter();
        public static string strConnString = "data source=DESKTOP-E06EJ47\\SQLEXPRESS01; " + "Integrated Security=SSPI ;" + "database=QuanLyBanSach";

        public void creatConn()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = strConnString;
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int executeQuery(SqlCommand dbCommand)
        {
            try
            {
                if (connection.State == 0)
                {
                    creatConn();
                }
                dbCommand.Connection = connection;
                dbCommand.CommandType = CommandType.Text;
                connection.Close();
                return dbCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable readDatathroughAdapter(string query)
        {
            try
            {
                DataTable tblName = new DataTable();
                if (connection.State == ConnectionState.Closed)
                {
                    creatConn();
                }
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                adapter = new SqlDataAdapter(command);
                adapter.Fill(tblName);
                connection.Close();

                return tblName;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public object ExecuteScala(string query)
        {
            try
            {
                object data;
                connection.Open();
                SqlCommand comand = new SqlCommand(query, connection);
                data = comand.ExecuteScalar();
                connection.Close();
                return data;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
