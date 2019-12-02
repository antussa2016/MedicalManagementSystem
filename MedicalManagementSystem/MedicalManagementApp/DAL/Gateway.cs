﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalManagementApp.DAL
{
    class Gateway
    {
        string connectionString = @"Data Source=ANTU\SQLEXPRESS; Initial Catalog=MedicalManagentDb;Integrated Security=true;";

        public SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }
        public SqlDataReader Reader { get; set; }
        public string Query { get; set; }

        public Gateway()
        {
            Connection = new SqlConnection(connectionString);

        }

    }
}
