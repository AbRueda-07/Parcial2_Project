using MinecraftManager.Models;
using MinecraftManager.Services;
using MinecraftManager.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2doParcial_Aranza.UI.FormsBloques
{
    public partial class FormBloques : Form
    {

        private readonly BloqueService _bloqueService;
        public FormBloques()
        {
            InitializeComponent();
            _bloqueService = new BloqueService(new DatabaseManager()); // Aquí inicializas el servicio
        }

        private void txtNombreBloque_TextChanged(object sender, EventArgs e)
        {
            btnGuardarBloque.Enabled = !string.IsNullOrWhiteSpace(txtNombreBloque.Text);
        }

        private void txtIdBloqueRegistrado_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbRareza_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
        }


        private void dgvDatosBloque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void FormBloques_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Add("Seleccione un tipo...");
            cmbTipo.Items.AddRange(new string[] { "Mineral", "Madera", "Piedra", "Decoración" });

            cmbRareza.Items.Add("Seleccione una rareza...");
            cmbRareza.Items.AddRange(new string[] { "Común", "Raro", "Épico", "Legendario" });

            cbmSearchTipo.Items.Add("Seleccione un tipo...");
            cbmSearchTipo.Items.AddRange(new string[] { "Mineral", "Madera", "Piedra", "Decoración" });

            cbmSearchRareza.Items.Add("Seleccione un tipo...");
            cbmSearchRareza.Items.AddRange(new string[] { "Común", "Raro", "Épico", "Legendario" });

            cmbTipo.SelectedIndex = 0;
            cmbRareza.SelectedIndex = 0;
            cbmSearchTipo.SelectedIndex = 0;
            cbmSearchRareza.SelectedIndex = 0;

        }

        private void btnGuardarBloque_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreBloque.Text))
                {
                    MessageBox.Show("Por favor ingresa un nombre para el bloque.");
                    return;
                }

                if (cmbTipo.SelectedIndex == 0 || cmbRareza.SelectedIndex == 0)
                {
                    MessageBox.Show("Por favor selecciona un tipo y una rareza válidos.");
                    return;
                }

                var bloque = new Bloque
                {
                    Nombre = txtNombreBloque.Text.Trim(),
                    Tipo = cmbTipo.SelectedItem.ToString(),
                    Rareza = cmbRareza.SelectedItem.ToString()
                };

                _bloqueService.Crear(bloque);
                MessageBox.Show("¡Bloque guardado exitosamente!");

                txtNombreBloque.Clear();
                cmbTipo.SelectedIndex = 0;
                cmbRareza.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar el bloque: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerBloques_Click_1(object sender, EventArgs e)
        {
            try
            {
                var bloques = _bloqueService.ObtenerTodos(); // Lista de Bloque

                dgvDatosBloque.Rows.Clear(); // Limpia las filas actuales

                foreach (var bloque in bloques)
                {
                    dgvDatosBloque.Rows.Add(
                        bloque.Id,
                        bloque.Nombre,
                        bloque.Tipo,
                        bloque.Rareza
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar bloques: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarBloqueID_Click(object sender, EventArgs e)
        {


            try
            {
                string idBloque = txtID.Text.Trim();

                var bloque = _bloqueService.ObtenerPorId(Convert.ToInt32(idBloque));

                dgvDatosBloque.Rows.Clear();

                if (bloque != null)
                {
                    dgvDatosBloque.Rows.Add(
                        bloque.Id,
                        bloque.Nombre,
                        bloque.Tipo,
                        bloque.Rareza
                    );
                }
                else
                {
                    MessageBox.Show("No se encontró ningún bloque con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar bloques: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBuscarT_Click(object sender, EventArgs e)
        {
            try
            {
                string tipoSeleccionado = cbmSearchTipo.SelectedItem?.ToString();

                if (string.IsNullOrWhiteSpace(tipoSeleccionado) || tipoSeleccionado == "Seleccione un tipo...")
                {
                    MessageBox.Show("Por favor selecciona un tipo válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var bloques = _bloqueService.BuscarPorTipo(tipoSeleccionado);

                dgvDatosBloque.Rows.Clear();

                if (bloques != null && bloques.Count > 0)
                {
                    foreach (var bloque in bloques)
                    {
                        dgvDatosBloque.Rows.Add(
                            bloque.Id,
                            bloque.Nombre,
                            bloque.Tipo,
                            bloque.Rareza
                        );
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron bloques de ese tipo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar bloques por tipo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRareza_Click(object sender, EventArgs e)
        {
            try
            {
                string rarezaSeleccionada = cbmSearchRareza.SelectedItem?.ToString();

                if (string.IsNullOrWhiteSpace(rarezaSeleccionada) || rarezaSeleccionada == "Seleccione una rareza...")
                {
                    MessageBox.Show("Por favor selecciona una rareza válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var bloques = _bloqueService.BuscarPorRareza(rarezaSeleccionada);

                dgvDatosBloque.Rows.Clear();

                if (bloques != null && bloques.Count > 0)
                {
                    foreach (var bloque in bloques)
                    {
                        dgvDatosBloque.Rows.Add(
                            bloque.Id,
                            bloque.Nombre,
                            bloque.Tipo,
                            bloque.Rareza
                        );
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron bloques con esa rareza.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar bloques por rareza: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarBloque_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdBloqueRegistrado.Text))
                {
                    MessageBox.Show("Por favor, busca y selecciona un bloque primero antes de actualizar su información.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombreBloque.Text))
                {
                    MessageBox.Show("Por favor ingresa un nombre para el bloque.");
                    return;
                }

                if (cmbTipo.SelectedIndex == 0 && cmbRareza.SelectedIndex == 0)
                {
                    MessageBox.Show("Por favor selecciona un tipo o una rareza para actualizar.");
                    return;
                }

                int idBloque = Convert.ToInt32(txtIdBloqueRegistrado.Text.Trim());
                var bloqueExistente = _bloqueService.ObtenerPorId(idBloque);

                if (bloqueExistente == null)
                {
                    MessageBox.Show("No se encontró el bloque a actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!string.IsNullOrWhiteSpace(txtNombreBloque.Text))
                {
                    bloqueExistente.Nombre = txtNombreBloque.Text.Trim();
                }

                if (cmbTipo.SelectedIndex != 0)
                {
                    bloqueExistente.Tipo = cmbTipo.SelectedItem.ToString();
                }

                if (cmbRareza.SelectedIndex != 0)
                {
                    bloqueExistente.Rareza = cmbRareza.SelectedItem.ToString();
                }

                _bloqueService.Actualizar(bloqueExistente);

                MessageBox.Show("¡Bloque actualizado exitosamente!");

                txtNombreBloque.Clear();
                cmbTipo.SelectedIndex = 0;
                cmbRareza.SelectedIndex = 0;
                txtIdBloqueRegistrado.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al actualizar el bloque: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEliminarBloque_Click(object sender, EventArgs e)
        {
            try
            {
                string IdBloque = txtIdBloqueRegistrado.Text.Trim();

                if (string.IsNullOrEmpty(IdBloque))
                {
                    MessageBox.Show("Para eliminar un bloque, primero ingresa el ID del bloque, búscalo y si estás seguro, puedes eliminarlo.", "ID Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(IdBloque, out int id))
                {
                    MessageBox.Show("El ID debe ser un número entero válido.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _bloqueService.Eliminar(id);

                MessageBox.Show("Bloque eliminado correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtIdBloqueRegistrado.Clear();
                dgvDatosBloque.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el bloque:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSalirBloque_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerGrafica_Click(object sender, EventArgs e)
        {
            var formGrafica = new FormEstadisticas();
            formGrafica.ShowDialog();
        }
    }
}
