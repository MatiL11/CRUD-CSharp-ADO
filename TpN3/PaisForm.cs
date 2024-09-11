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
    public partial class PaisForm : Form
    {
        private string connectionString = "Data Source = localhost;" + "Initial Catalog = Persona;" +
                                    "Integrated Security = True; ";
        public PaisForm()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Pais";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dgvPaises.DataSource = dataTable;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Pais (Nombre) VALUES (@nombre)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", txtNombrePais.Text);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("País agregado exitosamente");
                    CargarDatos();
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
                string query = "DELETE FROM Pais WHERE Id_Pais = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", Convert.ToInt32(txtIDPais.Text));

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("País eliminado exitosamente");
                    CargarDatos();
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
                string query = "UPDATE Pais SET Nombre = @nombre WHERE Id_Pais = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", txtNombrePais.Text);
                command.Parameters.AddWithValue("@id", Convert.ToInt32(txtIDPais.Text));

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("País modificado exitosamente");
                    CargarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
    }
}
