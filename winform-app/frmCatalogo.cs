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
    public partial class frmCatalogo : Form
    {
        private List<Articulo> listaArticulos;
        public frmCatalogo()
        {
            InitializeComponent();
        }

        private void frmCatalogo_Load(object sender, EventArgs e)
        {
            ActualizarListaArticulos();
        }
        //METODO PUBLICO PARA ACTUALIZAR EL DATAGRIDVIEW
        public void ActualizarListaArticulos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.listar();
            dgvArticulos.DataSource = listaArticulos;
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Articulo producto = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmFichaProducto fichaProducto = new frmFichaProducto(producto);
            fichaProducto.ShowDialog();
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.SelectedCells.Count == 0)
            {
                MessageBox.Show("Seleccione una fila o una celda para editar");
                return;
            }
            Articulo art = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            //MessageBox.Show("Id: " + art.id + " Codigo: " + art.codigo + " Nombre: " + art.nombre + " Descripcion:" + art.descripcion);
            frmEditarProducto editarProducto = new frmEditarProducto(art);
            editarProducto.ShowDialog();
        }
        

    }
}
