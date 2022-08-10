using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public abstract class ConnectionSQL
    {

        protected SqlConnection getConnection()
        {
            return new SqlConnection("Server=(local); DataBase=Bike_Store; integrated security=true");
        }

    }
}
