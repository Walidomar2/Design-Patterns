using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public interface ILogger
    {
        void Log(string message);
    }

    // Logger class implementing ILogger interface
    public class Logger_better : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging: {message}");
        }
    }

    // UserService class with ILogger dependency injection
    public class UserService_better
    {
        private readonly ILogger _logger;

        // Constructor injection of ILogger
        public UserService_better(ILogger logger)
        {
            _logger = logger;
        }

        public void RegisterUser(string username)
        {
            // Business logic for user registration

            // Logging using injected logger
            _logger.Log($"User '{username}' registered.");
        }
    }
}
