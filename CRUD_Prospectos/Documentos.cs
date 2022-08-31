using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Prospectos
{
    internal class Documentos
    {
        private int ID;
        private string nombre;
        private byte[] documento;
        private string extension;

        Conexion con = new Conexion();
        public int ID1 { get => ID; set => ID = value; }
        public string Nombre1 { get => nombre; set => nombre = value; }
        public byte[] Documento { get => documento; set => documento = value; }
        public string Extension { get => extension; set => extension = value; }


        public string AgregarDocumento() 
        {
            SqlCommand comando = new SqlCommand("insert into Expediente values (@nombre,@documento,@extension)", con.Conectar());
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@documento", documento);
            comando.Parameters.AddWithValue("@extension", extension);
            comando.ExecuteNonQuery();
            con.Desconectar();
            return "Agregado con éxito";
        }

        public DataTable MostrarDocumentos() 
        {
            DataTable tabla = new DataTable();
            SqlCommand comd = new SqlCommand("select id as ID,nombre as Nombre from Expediente", con.Conectar());
            SqlDataReader resultado = comd.ExecuteReader();

            if (resultado.HasRows) 
            {
                tabla.Load(resultado);
            }
            resultado.Close();
            con.Desconectar();
            return tabla;

        }

        public DataTable DocumentoPorID() 
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("select * from Expediente where ID = @id", con.Conectar());
            comando.CommandType= CommandType.Text;
            comando.Parameters.AddWithValue("@id", ID);
            SqlDataReader lector = comando.ExecuteReader();
            tabla.Load(lector);
            lector.Close();
            con.Desconectar();
            return tabla;
        }

        public List<Documentos> filtroDocumentos() 
        {
            var tabla = DocumentoPorID();
            var infoDocumento = new List<Documentos>();
            foreach (DataRow item in tabla.Rows) 
            {
                infoDocumento.Add(new Documentos
                {
                    ID = Convert.ToInt32(item[0]),
                    Nombre1 = item[1].ToString(),
                    Documento = (byte[])item[2],
                    Extension = item[3].ToString()
                });
            }
            return infoDocumento;
        }
   }
}
