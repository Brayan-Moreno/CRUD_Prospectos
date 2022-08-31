using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Prospectos
{
    public partial class ListadoProspectos : Form
    {
        Documentos objDoc = new Documentos();
        Conexion con = new Conexion();
        public ListadoProspectos()
        {
            InitializeComponent();
            LlenarDataDoc();
            LlenarDataProsp();
        }

        private void ListadoProspectos_Load(object sender, EventArgs e)
        {

        }

        private void LlenarDataDoc() 
        {
            gvDoc.DataSource = objDoc.MostrarDocumentos();
        }

        private void LlenarDataProsp() 
        {
            DataTable tablapos = new DataTable();
            SqlCommand comd = new SqlCommand("Select ID, Nombre, Apellido1 as 'Apellido Paterno', Apellido2 as 'Apellido Materno', Estado from Clientes", con.Conectar());
            SqlDataReader resultado = comd.ExecuteReader();

            if (resultado.HasRows) tablapos.Load(resultado);

            resultado.Close();
            con.Desconectar();
            gvProspectos.DataSource = tablapos;
        }
        private void btnOpenDoc_Click(object sender, EventArgs e)
        {
            if (gvDoc.SelectedRows.Count > 0) 
            {
                int id = Convert.ToInt32(gvDoc.CurrentRow.Cells[0].Value.ToString());
                objDoc.ID1 = id;
                var lista = new List<Documentos>();
                lista = objDoc.filtroDocumentos();

                foreach (Documentos item in lista) 
                {
                    string direccion = AppDomain.CurrentDomain.BaseDirectory;
                    string carpeta = direccion + "/temp/";
                    string ubicacioncompleta = carpeta + item.Extension;

                    if (!Directory.Exists(carpeta)) 
                    {
                        Directory.CreateDirectory(carpeta);
                    }
                    if (File.Exists(ubicacioncompleta)) 
                    {
                        File.Delete(ubicacioncompleta);
                    }

                    File.WriteAllBytes(ubicacioncompleta, item.Documento);
                    Process.Start(ubicacioncompleta);
                }
            }
        }

        private void gvProspectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select * from Clientes where ID = @id", con.Conectar());
            comando.Parameters.AddWithValue("@id", gvProspectos.CurrentRow.Cells[0].Value.ToString());
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read()) 
            {
                txtNomProsp.Text = registro["Nombre"].ToString();
                txtApePaProsp.Text = registro["Apellido1"].ToString();
                txtApeMProsp.Text = registro["Apellido2"].ToString();
                txtCalle.Text = registro["Calle"].ToString();
                txtCodPost.Text = registro["CodigoPostal"].ToString();
                txtColonia.Text = registro["Colonia"].ToString();
                txtNumero.Text = registro["Numero"].ToString();
                txtTel.Text = registro["Telefono"].ToString();
                txtRFC.Text = registro["RFC"].ToString();
                txtObs.Text = registro["Comment"].ToString();
            }
            con.Desconectar();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Close();
            menu.Show();
        }
    }
}
