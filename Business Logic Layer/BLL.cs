using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;
using System.IO;



namespace Business_Logic_Layer
{
    public class BLL
    {
        private readonly DAL dataAccess;
        private string settingsFilePath = "connectionSettings.txt";
        private string serverName;
        private string databaseName;
        private string userName;
        private string password;

        public BLL()
        {
            dataAccess = new DAL();
            LoadConnectionSettingsFromFile(); // Load connection settings from file
            ConnectToDatabase();
        }
        public bool CreateTask(int taskId, string taskDescription, string taskDetails, decimal dollarReward)
        {
            if (string.IsNullOrEmpty(taskDescription) || string.IsNullOrEmpty(taskDetails))
            {
                throw new ArgumentException("Task description and task details are required.");
            }

            return dataAccess.CreateTask(taskId, taskDescription, taskDetails, dollarReward);
        }
        public bool DeleteTask(int taskId)
        {
            if (taskId <= 0)
            {
                throw new ArgumentException("Task ID must be greater than zero.");
            }

            return dataAccess.DeleteTask(taskId);
        }
        public DataTable GetWorkers()
        {
            return dataAccess.GetWorkers();
        }
        public DataTable GetTasks()
        {
            return dataAccess.GetTasks();
        }

        public bool UpdateTaskDescription(int taskId, string newTaskDescription)
        {
            if (string.IsNullOrEmpty(newTaskDescription))
            {
                throw new ArgumentException("New task description is required.");
            }

            return dataAccess.UpdateTaskDescription(taskId, newTaskDescription);
        }
        public bool RegisterManager(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Username and password are required.");
            }

            return dataAccess.RegisterManager(username, password);
        }

        public bool Login(string userType, string username, string password)
        {
            if (string.IsNullOrEmpty(userType) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("User type, username, and password are required.");
            }

            return dataAccess. ValidateUser(userType, username, password);
        }
        public bool RegisterWorker(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Username and password are required.");
            }

            return dataAccess.RegisterWorker(username, password);
        }
        public DataTable GetAllTasks()
        {
            return dataAccess.GetAllTasks();
        }

        public bool MarkTaskComplete(string taskId)
        {
            return dataAccess.MarkTaskComplete(taskId);
        }




        /// //////////////////////////////////////
        private void LoadConnectionSettingsFromFile()
        {
            if (File.Exists(settingsFilePath))
            {
                // Read connection settings from the settings file
                string[] lines = File.ReadAllLines(settingsFilePath);
                if (lines.Length >= 4)
                {
                    serverName = lines[0];
                    databaseName = lines[1];
                    userName = lines[2];
                    password = lines[3];
                }
            }
        }
        private void ConnectToDatabase()
        {
            // Construct the connection string
            string connectionString = $"Data Source={serverName};Initial Catalog={databaseName};User ID={userName};Password={password}";

            try
            {
                // Connect to the database using DAL
                dataAccess.Connect(connectionString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting to the database: {ex.Message}");
                throw; // Rethrow the exception for handling in the presentation layer
            }
        }

        //public void SaveConnectionSettings(string server, string database, string user, string pass)
        //{
        //    // Save connection settings internally in the BLL
        //    serverName = server;
        //    databaseName = database;
        //    userName = user;
        //    password = pass;

        //    // Save connection settings to file
        //    SaveConnectionSettingsToFile();

        //    // Reconnect to the database with new settings
        //    ConnectToDatabase();
        //}
        public void RemoteConnection(string serverip, string servername, string username, string password)
        {
            string connectionString = $"Data Source={serverip};Initial Catalog={servername};User ID={username};Password={password}";

            try
            {
                // Connect to remote database using DAL
                dataAccess.Connect(connectionString);

                // Additional tasks can be performed after successful connection
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting to remote database: {ex.Message}");
                throw; // Rethrow the exception for handling in the presentation layer
            }
        }

        public void LocalConnection(string serverip, string servername, string username, string password)
        {
            string connectionString = $"Data Source={serverip};Initial Catalog={servername};Integrated Security=True";

            try
            {
                // Connect to local database using DAL
                dataAccess.Connect(connectionString);

                // Additional tasks can be performed after successful connection
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting to local database: {ex.Message}");
                throw; // Rethrow the exception for handling in the presentation layer
            }
        }

        public void SaveConnectionSettings(string server, string database, string user, string pass)
        {
            // Save connection settings internally in the BLL
            serverName = server;
            databaseName = database;
            userName = user;
            password = pass;

            // Save connection settings to file
            SaveConnectionSettingsToFile();

            // Reconnect to the database with new settings
            ConnectToDatabase();
        }

        public Tuple<string, string, string, string> LoadConnectionSettings()
        {
            // Load connection settings from internal variables
            return Tuple.Create(serverName, databaseName, userName, password);
        }

        private void SaveConnectionSettingsToFile()
        {
            // Create or overwrite the settings file with the connection settings
            using (StreamWriter writer = new StreamWriter(settingsFilePath))
            {
                writer.WriteLine(serverName);
                writer.WriteLine(databaseName);
                writer.WriteLine(userName);
                writer.WriteLine(password);
            }
        }

        /// ////////////////////////////////////////////////////////////////////////////
        public string DeleteWorker(int workerID)
        {
           
            return dataAccess.DeleteWorker(workerID);
        }
        public bool UpdateManagerPassword(string managername,string Currentpassword, string newPassword)
        {
            return dataAccess.UpdateManagerPassword(managername, Currentpassword, newPassword);
        }

        public bool VerifyCurrentPassword(string managername, string currentPassword)
        {
            return dataAccess.VerifyCurrentPassword(managername, currentPassword);
        }
        public bool UpdatePassword(string tableName, string username, string newPassword, string confirmPassword)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                throw new ArgumentException("All fields are required.");
            }

            if (newPassword != confirmPassword)
            {
                throw new ArgumentException("New password and confirm password do not match.");
            }

            return dataAccess.UpdatePassword(tableName, username, newPassword);
        }
    }        

    
}
