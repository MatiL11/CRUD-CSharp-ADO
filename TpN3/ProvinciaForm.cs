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
    public partial class ProvinciaForm : Form
    {

        private string connectionString = "Data Source = localhost;" + "Initial Catalog = Persona;" +
                                     "Integrated Security = True; ";
        public ProvinciaForm()
        {
            InitializeComponent();
            CargarProvincias();
        }

        private void CargarProvincias()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Provincia";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dgvProvincias.DataSource = dataTable;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Provincia (Nombre, Id_Pais) VALUES (@nombre, @id_pais)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", txtNombreProvincia.Text);
                command.Parameters.AddWithValue("@id_pais", Convert.ToInt32(txtIDPais.Text));

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Provincia agregada exitosamente");
                    CargarProvincias();
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
                try
                {
                    string query = "DELETE FROM Provincia WHERE Id_Provincia = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", Convert.ToInt32(txtIDProvincia.Text));
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Provincia eliminada exitosamente");
                    CargarProvincias();
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
                string query = "UPDATE Provincia SET Nombre = @nombre, Id_Pais = @id_pais WHERE Id_Provincia = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", txtNombreProvincia.Text);
                command.Parameters.AddWithValue("@id_pais", Convert.ToInt32(txtIDPais.Text));
                command.Parameters.AddWithValue("@id", Convert.ToInt32(txtIDProvincia.Text));

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Provincia modificada exitosamente");
                    CargarProvincias();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
    }
}
