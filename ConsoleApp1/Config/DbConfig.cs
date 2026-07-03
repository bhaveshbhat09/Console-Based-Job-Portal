using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Config
{
    public static class DbConfig
    {
        public static readonly string ConnectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=JobPortalDb;Integrated Security=True;TrustServerCertificate=True";
    }

}
