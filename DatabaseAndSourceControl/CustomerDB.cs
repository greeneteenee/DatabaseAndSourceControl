using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAndSourceControl
{
    static class CustomerDB
    {
        public static List<string> GetAllNames()
        {
            string connection = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=CustomerDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                //TODO: Finish database code...
            }
            throw new NotImplementedException();
        }
    }
}
