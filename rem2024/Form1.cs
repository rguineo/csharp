using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace rem2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text;
            string passuser = txtPassword.Text;

           if(username == "" || passuser== "")
            {
                MessageBox.Show("Usuario o contraseña estan vacios", "Credenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {

                using (SqlConnection conexion = DBGeneral.ObtenerConexion())
                {
                    SqlCommand consulta = new SqlCommand("SELECT * FROM users WHERE userName = @nombre AND passName=@clave", conexion);
                    consulta.Parameters.AddWithValue("nombre", username);
                    consulta.Parameters.AddWithValue("clave", passuser);
                    SqlDataReader registo = consulta.ExecuteReader();

                    if (registo.Read())
                    {
                        menuPrincipal formMenu = new menuPrincipal();
                        this.Hide();
                        formMenu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrecto", "Credenciales Erroneas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conexion.Close();

                }
            }
        }
    }
}
