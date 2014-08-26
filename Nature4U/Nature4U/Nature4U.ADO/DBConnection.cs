using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Nature4U.ADO
{
    class DBConnection
    {
        SqlConnection connection;
        public SqlTransaction transaction;
        string connectionString = string.Empty;
        public DBConnection(string connectionSql)
        {
            connectionString = connectionSql;
            connection = new SqlConnection(connectionString);
        }

        /// <summary>
        /// Populates a DataTable according to a Sql statement.
        /// </summary>
        /// <param name="sql">Sql statement.</param>
        /// <returns>Populated DataTable.</returns>
        public DataTable GetDataTable(string sql, List<SqlParameter> listParameters)
        {

            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.CommandText = sql;
                        command.Transaction = transaction;
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        //command.CommandTimeout = 30;
                       

                        if (listParameters != null)
                        {
                            command.Parameters.AddRange(listParameters.ToArray());
                        }
                        adapter.SelectCommand = command;
                        adapter.Fill(dt);
                        command.Parameters.Clear();
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                    connection.Dispose();
                    adapter.Dispose();
                }
            }
            return dt;
        }

        public DataTable GetDataTable(string sql)
        {
            DataTable myTable = new DataTable();
            SqlDataReader myReader = null;
            using (SqlConnection myConnection = new SqlConnection(this.connectionString))
            {
                try
                {
                    using (SqlCommand myCommand = new SqlCommand(sql, myConnection))
                    {
                        myCommand.CommandType = CommandType.StoredProcedure;
                        myConnection.Open();
                        //myCommand.CommandTimeout = 30;
                        myReader = myCommand.ExecuteReader();
                        myTable.Load(myReader);
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    myConnection.Close();
                    myConnection.Dispose();
                    if (myReader != null)
                    {
                        myReader.Close();
                    }
                }
            }
            return myTable;
        }

        /// <summary>
        /// Executes a Sql statement and returns a scalar value.
        /// </summary>
        /// <param name="sql">Sql statement.</param>
        /// <returns>Scalar value.</returns>
        public object GetScalar(string sql, List<SqlParameter> listParameters)
        {
            object obj;
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        //command.CommandTimeout = 30;
                        command.CommandText = sql;
                        command.Parameters.AddRange(listParameters.ToArray());
                        connection.Open();
                        obj = command.ExecuteScalar();
                        command.Parameters.Clear();
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
            return obj;
        }

        /// <summary>
        /// Executes a Sql statement and returns a scalar value.
        /// </summary>
        /// <param name="sql">Sql statement.</param>
        /// <returns>Scalar value.</returns>
        public object GetScalar(string sql)
        {
            object obj;
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        //command.CommandTimeout = 30;
                        command.CommandText = sql;
                        connection.Open();
                        obj = command.ExecuteScalar();
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
            return obj;
        }

        public int GetExecuteNonQuery(string sql, List<SqlParameter> listParameters)
            {
            int result = 0;
            using (DbConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    using (DbCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        //command.CommandTimeout = 30;
                        command.CommandText = sql;
                        command.Parameters.AddRange(listParameters.ToArray());
                        connection.Open();
                        result = command.ExecuteNonQuery();
                        command.Parameters.Clear();
                    }
                }
                catch(Exception e)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                    connection.Dispose();
                }
            }

            return result;
        }

        public DataSet GetDataSet(string sql, List<SqlParameter> listParameters)
        {

            DataSet ds = new DataSet();
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandTimeout = 3000;
                        command.CommandText = sql;

                        if (listParameters != null)
                        {
                            command.Parameters.AddRange(listParameters.ToArray());
                        }
                        adapter.SelectCommand = command;
                        adapter.Fill(ds);
                        command.Parameters.Clear();
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                    connection.Dispose();
                    adapter.Dispose();
                }
            }
            return ds;
        }
    }
}


