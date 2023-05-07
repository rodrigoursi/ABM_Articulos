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
    public partial class frmCategorias : Form
    {
        private List<Categoria> listaCategorias;
        public frmCategorias()
        {
            InitializeComponent();
        }

        public void frmCategorias_Load(object sender, EventArgs e)
        {
            CategoriasNegocio negocio = new CategoriasNegocio();
            dgvCategorias.DataSource = negocio.listar();
        }

        private void dgvCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Categoria categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            frmFichaCategoria fichaCategoria = new frmFichaCategoria(categoria, 1);  //MODO = 1 para VER
            fichaCategoria.ShowDialog();

        }

        private void btnBackOfCatalogo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ActualizarListaCategorias()
        {
            CategoriasNegocio negocio = new CategoriasNegocio();
            listaCategorias = negocio.listar();
            dgvCategorias.DataSource = listaCategorias;
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedCells.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para editar");
                return;
            }
            Categoria categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            frmFichaCategoria fichaCategoria = new frmFichaCategoria(categoria, 0); //MODO = 0 para Editar
            fichaCategoria.ShowDialog();
        }

        private void btnNuevoCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            frmFichaCategoria fichaCategoria = new frmFichaCategoria(categoria, 2); //MODO = 2 para NUEVO
            fichaCategoria.ShowDialog();
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategorias.SelectedRows.Count > 0)
                {
                    DialogResult respuesta = MessageBox.Show("estas seguro que deseas eliminar la categoria", "Eliminada", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.No) return;
                    DataGridViewRow row = dgvCategorias.SelectedRows[0];
                    string valor = row.Cells["id"].Value.ToString();
                    CategoriasNegocio Negocio = new CategoriasNegocio();
                    string mensaje = "La categoria no pudo ser eliminada.";
                    if (Negocio.eliminar(int.Parse(valor)) > 0)
                    {
                        mensaje = "Categoria eliminada exitosamente.";
                    }
                    MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarListaCategorias();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
