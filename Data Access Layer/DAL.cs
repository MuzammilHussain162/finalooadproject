using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public class DAL
    {
        public static string ServerIP = @"MUZAMMILHUSSAIN\SQLEXPRESS";
        public static string DatabaseName = "ooad_project";
        public static string DatabaseUserID = "dmk";
        public static string DatabasePassword = "dmk123";
        private static Hashtable SqlparamCache = Hashtable.Synchronized(new Hashtable());
        private SqlConnection Connection = new SqlConnection();
        private SqlCommand DbCommand = new SqlCommand();
        private SqlDataAdapter DtAdapter = new SqlDataAdapter();
        private DataSet SqlDataSet = new DataSet();
        private DataTable SqlTable = new DataTable();

        public void UnLoadSpParameters()
        {
            DbCommand.Parameters.Clear();
        }

        public void LoadSpParameters(string SpName, params object[] ParaValues)
        {
            SqlParameter[] TheParameters = (SqlParameter[])SqlparamCache[SpName];
            DbCommand.Parameters.Clear();
            if (TheParameters == null)
            {
                DbCommand.CommandType = CommandType.StoredProcedure;
                DbCommand.CommandText = SpName;
                SqlCommandBuilder.DeriveParameters(DbCommand);
                TheParameters = new SqlParameter[DbCommand.Parameters.Count];

                DbCommand.Parameters.CopyTo(TheParameters, 0);
                SqlparamCache[SpName] = TheParameters;
            }
            else
            {
                short i;
                SqlParameter SqPr;
                DbCommand.CommandType = CommandType.StoredProcedure;
                DbCommand.CommandText = SpName;
                for (i = 0; i < TheParameters.Length; i++)
                {
                    SqPr = (SqlParameter)((ICloneable)(TheParameters[i])).Clone();
                    DbCommand.Parameters.Add(SqPr);
                }
            }
            MoveSqlParameters(ParaValues);
        }

        private void MoveSqlParameters(object[] Paras)
        {
            short ic;
            SqlParameter sqlPara;
            if (Paras.Length >= 0)
            {
                for (ic = 0; ic < Paras.Length; ic++)
                {
                    sqlPara = DbCommand.Parameters[ic + 1];
                    string s = sqlPara.ParameterName;
                    sqlPara.Value = Paras[ic];
                }
            }
        }

        public SqlParameter Parameters(int P)
        {
            return DbCommand.Parameters[P];
        }

        public bool OpenConnection()
        {
            DbCommand = new SqlCommand();
            try
            {
                if (Connection.State == ConnectionState.Open) return true;
                Connection = new SqlConnection();
                Connection.ConnectionString = $"Data Source={ServerIP}; Initial Catalog={DatabaseName}; User ID={DatabaseUserID}; Password={DatabasePassword};";
                Connection.Open();
                if (Connection.State == ConnectionState.Open)
                {
                    DbCommand.Connection = Connection;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ee)
            {
                throw new Exception("Database:OpenConnection:" + ee.Message);
            }
        }
        public DataTable GetWorkers()
        {
            DataTable workersTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetWorkers", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(workersTable);
                }
            }

            return workersTable;
        }

        public void CloseConnection()
        {
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
                DbCommand.Dispose();
                DtAdapter.Dispose();
                SqlDataSet.Dispose();
                SqlTable.Dispose();
            }
        }

        public SqlDataReader GetDataReader()
        {
            return DbCommand.ExecuteReader();
        }

        public int ExecuteQuery()
        {
            return DbCommand.ExecuteNonQuery();
        }
        public bool VerifyCurrentPassword(string managername, string currentPassword)
        {
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                string query = "SELECT COUNT(1) FROM MANAGER WHERE manager_name = @managername AND manager_password = @CurrentPassword";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@manager_name", managername);
                    cmd.Parameters.AddWithValue("@manager_password", currentPassword);

                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count == 1;
                }
            }
        }
            public bool UpdateManagerPassword(string managername, string currentPassword, string newPassword)
        {
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateManagerPassword", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Managername", managername);
                    cmd.Parameters.AddWithValue("@CurrentPassword", currentPassword);
                    cmd.Parameters.AddWithValue("@NewPassword", newPassword);

                    conn.Open();
                    int success = (int)cmd.ExecuteScalar();
                    return success == 1;
                }
            }
        }

        public object ExecuteValue()
        {
            return DbCommand.ExecuteScalar();
        }

        public bool ValidateUser(string userType, string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("ValidateUser", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserType", userType);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    conn.Open();
                    int result = (int)cmd.ExecuteScalar();
                    return result > 0;
                }
            }
       }
        public bool RegisterWorker(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("RegisterWorker", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
        public bool RegisterManager(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("RegisterManager", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
        public bool CreateTask(int taskId, string taskDescription, string taskDetails, decimal dollarReward)
        {
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("CreateTask", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TaskId", taskId);
                    cmd.Parameters.AddWithValue("@TaskDescription", taskDescription);
                    cmd.Parameters.AddWithValue("@TaskDetails", taskDetails);
                    cmd.Parameters.AddWithValue("@DollarReward", dollarReward);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
        public string DeleteWorker(int workerID)
        {
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteWorker", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@WorkerID", workerID);

                    conn.Open();
                    var result = cmd.ExecuteScalar().ToString();
                    conn.Close();

                    return result;
                }
            }
        }

        public DataTable GetTasks()
        {
            DataTable tasksTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetTasks", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(tasksTable);
                }
            }

            return tasksTable;
        }
        
        public bool DeleteTask(int taskId)
        {
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteTask", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TaskId", taskId);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
            public bool UpdateTaskDescription(int taskId, string newTaskDescription)
        {
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateTaskDescription", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TaskId", taskId);
                    cmd.Parameters.AddWithValue("@NewTaskDescription", newTaskDescription);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
        public bool UpdatePassword(string tableName, string username, string newPassword)
        {
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("UpdatePassword", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TableName", tableName);
                    cmd.Parameters.AddWithValue("@Username", username);
                    // cmd.Parameters.AddWithValue("@CurrentPassword", currentPassword);
                    cmd.Parameters.AddWithValue("@NewPassword", newPassword);

                    conn.Open();
                    int result = (int)cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

            public object ExecuteValue(string SQLStatement)
        {
            DbCommand.CommandType = CommandType.Text;
            DbCommand.CommandText = SQLStatement;
            return DbCommand.ExecuteScalar();
        }

        public string ReturnValue(string _PName)
        {
            DbCommand.ExecuteNonQuery();
            return DbCommand.Parameters[_PName].Value.ToString();
        }

        public DataTable GetDataTable()
        {
            DtAdapter.SelectCommand = DbCommand;
            DtAdapter.Fill(SqlTable);
            return SqlTable;
        }

        public SqlConnection ConnectionObject
        {
            get { return this.Connection; }
        }

        public static string CreateConnectionString()
        {
            string con = "";
            return con;
        }
    }
}
