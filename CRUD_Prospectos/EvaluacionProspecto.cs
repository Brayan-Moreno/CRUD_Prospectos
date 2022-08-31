using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Prospectos
{
    public partial class EvaluacionProspecto : Form
    {
        Conexion con = new Conexion();
        public EvaluacionProspecto()
        {
            InitializeComponent();
            LlenarDataProsp();
        }
        private void LlenarDataProsp()
        {
            DataTable tablapos = new DataTable();
            SqlCommand comd = new SqlCommand("Select ID, Nombre, Apellido1 as 'Apellido Paterno', Apellido2 as 'Apellido Materno', Estado from Clientes", con.Conectar());
            SqlDataReader resultado = comd.ExecuteReader();

            if (resultado.HasRows) tablapos.Load(resultado);

            resultado.Close();
            con.Desconectar();
            gvDatosProsp.DataSource = tablapos;
        }

        private void EvaluacionProspecto_Load(object sender, EventArgs e)
        {

        }

        private void gvDatosProsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select * from Clientes where ID = @id", con.Conectar());
            comando.Parameters.AddWithValue("@id", gvDatosProsp.CurrentRow.Cells[0].Value.ToString());
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
                txtObserv.Text = registro["Comment"].ToString();
            }
            con.Desconectar();
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            string actualizar = "update Clientes set Comment = @comment, Estado = 'AUTORIZADO' where ID=@id";
            SqlCommand cmd1 = new SqlCommand(actualizar, con.Conectar());
            cmd1.Parameters.AddWithValue("@comment", txtObserv.Text);
            cmd1.Parameters.AddWithValue("@id", gvDatosProsp.CurrentRow.Cells[0].Value.ToString());
            cmd1.ExecuteNonQuery();
            con.Desconectar();
            MessageBox.Show("Se ha registrado correctamente");
            LlenarDataProsp();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            string actualizar = "update Clientes set Comment = @comment, Estado = 'RECHAZADO' where ID=@id";
            SqlCommand cmd1 = new SqlCommand(actualizar, con.Conectar());
            cmd1.Parameters.AddWithValue("@comment", txtObserv.Text);
            cmd1.Parameters.AddWithValue("@id", gvDatosProsp.CurrentRow.Cells[0].Value.ToString());
            cmd1.ExecuteNonQuery();
            con.Desconectar();
            MessageBox.Show("Se ha registrado correctamente");
            LlenarDataProsp();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
