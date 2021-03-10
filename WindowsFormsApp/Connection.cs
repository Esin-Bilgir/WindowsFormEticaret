using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    class Connection
    {
       
        public SqlConnection MyConnection()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString =  @"Server=LAPTOP-JST62TQS\SQLEXPRESS; Database= Filmler; Trusted_Connection=True";

            if (cnn.State != System.Data.ConnectionState.Open)
            {

                try
                {
                    cnn.Open();
                }
                catch 
                {
                   
                }
            }

            return cnn;
        }

        internal void ExecuteNonQuerty()
        {
            throw new NotImplementedException();
        }
    }
}
