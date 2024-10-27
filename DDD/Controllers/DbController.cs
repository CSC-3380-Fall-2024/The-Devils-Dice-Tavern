using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DbConnection {
    class DbController : Controller {

        /*Fields*/

        //Handles Connection to Database
        private MySqlConnector connection;

        //Status of connection to validate CRUD commands
        private Boolean isConnected;
        
        //Query to interact with tables
        private string query;

        /*Getters and Setters*/
        public MySqlConnector Connection {
            get { return connection; }
            set { connection = value; }
        }

        public Boolean isConnected {
            get { return isConnected; }
            set { isConnected = new MySqlConnection(value); }
        }


    }
}