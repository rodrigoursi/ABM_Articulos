using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class frmMarcas : Form
    {
        private List<Marca> listaMarcas;

        public frmMarcas()
        {
            InitializeComponent();
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            dgvMarcas.DataSource = negocio.listar();
        }

        public void ActualizarListaMarcas()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            listaMarcas = negocio.listar();
            dgvMarcas.DataSource = listaMarcas;
        }

        private void dgvCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Marca marca = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            frmFichaMarca fichaMarca = new frmFichaMarca(marca, 1);  //MODO = 1 para VER
            fichaMarca.ShowDialog();

        }

        private void btnBackOfCatalogo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMarcas.SelectedRows.Count > 0)
                {
                    DialogResult respuesta = MessageBox.Show("estas seguro que deseas eliminar la marca", "Eliminada", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.No) return;
                    DataGridViewRow row = dgvMarcas.SelectedRows[0];
                    string valor = row.Cells["id"].Value.ToString();
                    MarcaNegocio Negocio = new MarcaNegocio();
                    string mensaje = "La marca no pudo ser eliminada.";
                    if (Negocio.eliminar(int.Parse(valor)) > 0)
                    {
                        mensaje = "Marca eliminada exitosamente.";
                    }
                    MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarListaMarcas();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevaMarca_Click(object sender, EventArgs e)
        {
            Marca marca = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            frmFichaMarca fichaMarca = new frmFichaMarca(marca, 2); //MODO = 0 para Editar
            fichaMarca.ShowDialog();

        }

        private void btnEditarMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.SelectedCells.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para editar");
                return;
            }
            Marca marca = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            frmFichaMarca fichaMarca = new frmFichaMarca(marca, 0); //MODO = 0 para Editar
            fichaMarca.ShowDialog();
        }
    }
}
