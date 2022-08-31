using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace CRUD_Prospectos
{
    public partial class RegistroProspecto : Form
    {

        Documentos objDoc = new Documentos();
        public RegistroProspecto()
        {
            InitializeComponent();
        }

        private void RegistroProspecto_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarProsp_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            string insertar = "insert into Clientes (Nombre,Apellido1,Apellido2,Calle,Numero,Colonia,CodigoPostal,Telefono,RFC,Estado) values" +
                "(@Nombre,@Apellido1,@Apellido2,@Calle,@Numero,@Colonia,@CodigoPostal,@Telefono,@RFC,@Estado)";
            SqlCommand cmd1 = new SqlCommand(insertar, con.Conectar());
            cmd1.Parameters.AddWithValue("@Nombre", txtNomProsp.Text);
            cmd1.Parameters.AddWithValue("@Apellido1", txtApeMProsp.Text);
            cmd1.Parameters.AddWithValue("@Apellido2", txtApePaProsp.Text);
            cmd1.Parameters.AddWithValue("@Calle", txtCalle.Text);
            cmd1.Parameters.AddWithValue("@Numero", txtNumero.Text);
            cmd1.Parameters.AddWithValue("@Colonia", txtColonia.Text);
            cmd1.Parameters.AddWithValue("@CodigoPostal", txtCodPost.Text);
            cmd1.Parameters.AddWithValue("@Telefono", txtTel.Text);
            cmd1.Parameters.AddWithValue("@RFC", txtRFC.Text);
            cmd1.Parameters.AddWithValue("@Estado","ENVIADO");
            cmd1.ExecuteNonQuery();
            con.Desconectar();
            MessageBox.Show("Se ha registrado correctamente");
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Documentos";
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if(openFileDialog1.ShowDialog()==DialogResult.OK)
                txtRuta.Text = openFileDialog1.FileName;
        }

        private void btnGuardarDoc_Click(object sender, EventArgs e)
        {
            byte[] archivo = null;
            Stream MyStream = openFileDialog1.OpenFile();
            MemoryStream obj = new MemoryStream();
            MyStream.CopyTo(obj);
            archivo= obj.ToArray();

            objDoc.Nombre1=txtNomDoc.Text;
            objDoc.Documento = archivo;
            objDoc.Extension = openFileDialog1.SafeFileName;
            MessageBox.Show(objDoc.AgregarDocumento());
            txtRuta.Clear();
            txtNomDoc.Clear();
        }

        private void btnCancelDoc_Click(object sender, EventArgs e)
        {
            txtRuta.Clear();
            txtNomDoc.Clear();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtNomProsp.Clear();
            txtApeMProsp.Clear();
            txtApePaProsp.Clear();
            txtCalle.Clear();
            txtCodPost.Clear();
            txtColonia.Clear();
            txtNumero.Clear();
            txtRFC.Clear();
            txtTel.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            string message = "Si sale del programa perderá cualquier requistro no guardado, ¿desea continuar?";
            string caption = "Advertencia";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Menu m = new Menu();
                this.Close();
                m.Show();
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            this.Close();
            m.Show();
        }
    }
}
