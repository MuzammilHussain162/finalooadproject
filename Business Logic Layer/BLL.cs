using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;




namespace Business_Logic_Layer
{
    public class BLL
    {
        private readonly DAL dataAccess;
        

        public BLL()
        {
            dataAccess = new DAL();
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
        public string DeleteWorker(int workerID)
        {
           
            return dataAccess.DeleteWorker(workerID);
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
