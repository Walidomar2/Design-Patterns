using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
   
// Logger class
public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging: {message}");
        }
    }

    // UserService class
    public class UserService
    {
        private Logger _logger;

        public UserService()
        {
            _logger = new Logger(); // Dependency is directly instantiated
        }

        public void RegisterUser(string username)
        {
            // Business logic for user registration

            // Logging
            _logger.Log($"User '{username}' registered.");
        }
    }
}
