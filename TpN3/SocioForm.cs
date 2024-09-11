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

namespace TpN3
{
    public partial class SocioForm : Form
    {
        private string connectionString = "Data Source = localhost;" + "Initial Catalog = Persona;" +
                                     "Integrated Security = True; ";
        public SocioForm()
        {
            InitializeComponent();
            CargarSocios();
        }

        private void CargarSocios()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Socio";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dgvSocios.DataSource = dataTable;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Socio (Nombre, Apellido, Email, Id_Pais, Id_Provincia) VALUES (@nombre, @apellido, @email, @id_pais, @id_provincia)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", txtNombreSocio.Text);
                command.Parameters.AddWithValue("@apellido", txtApellidoSocio.Text);
                command.Parameters.AddWithValue("@email", txtEmailSocio.Text);
                command.Parameters.AddWithValue("@id_pais", Convert.ToInt32(txtIDPais.Text));
                command.Parameters.AddWithValue("@id_provincia", Convert.ToInt32(txtIDProvincia.Text));

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Socio agregado exitosamente");
                    CargarSocios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Socio WHERE Id_Socio = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", Convert.ToInt32(txtIDSocio.Text));

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Socio eliminado exitosamente");
                    CargarSocios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Socio SET Nombre = @nombre, Apellido = @apellido, Email = @email, Id_Pais = @id_pais, Id_Provincia = @id_provincia WHERE Id_Socio = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", txtNombreSocio.Text);
                command.Parameters.AddWithValue("@apellido", txtApellidoSocio.Text);
                command.Parameters.AddWithValue("@email", txtEmailSocio.Text);
                command.Parameters.AddWithValue("@id_pais", Convert.ToInt32(txtIDPais.Text));
                command.Parameters.AddWithValue("@id_provincia", Convert.ToInt32(txtIDProvincia.Text));
                command.Parameters.AddWithValue("@id", Convert.ToInt32(txtIDSocio.Text));

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Socio modificado exitosamente");
                    CargarSocios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
    }
}
