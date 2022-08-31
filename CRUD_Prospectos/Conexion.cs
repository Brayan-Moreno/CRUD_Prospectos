using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CRUD_Prospectos
{
    class Conexion
    {
        SqlConnection con;

        public Conexion() 
        {
            con = new SqlConnection("Server=DESKTOP-KKI5840\\SQLEXPRESS;Database=Prospectos;integrated security=true");
        }

        public SqlConnection Conectar() 
        {
            con.Open();
            return con;
        }

        public SqlConnection Desconectar() 
        {
            con.Close();
            return con;
        }
    }


}
