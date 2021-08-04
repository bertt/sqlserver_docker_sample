using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DbController : ControllerBase
    {

        private readonly ILogger<DbController> _logger;

        public DbController(ILogger<DbController> logger)
        {
            _logger = logger;
        }

        public string TestConnection()
        {
            var connectstring = new ConfigurationBuilder().AddJsonFile("appsettings.json").AddEnvironmentVariables().Build()["connect_db"];
            var connection = new SqlConnection();
            connection.ConnectionString = connectstring;
            try{
                connection.Open();
                connection.Close();
            }
            catch (Exception e )
            {
                return "error" + e.Message;
            }
            return "connection succeeded";
        }

    }
}
