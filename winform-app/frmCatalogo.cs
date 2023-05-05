using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
        private void dgvArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void txbTextoBuscarProducto_Click(object sender, EventArgs e)
        {
            string consultaAux = "";

            switch (cmbBuscarPor.Text)
            {
                case "Codigo":
                    consultaAux = "Codigo";
                    break;
                case "Nombre":
                    consultaAux = "Nombre";
                    break;
                case "Descripcion":
                    consultaAux = "A.Descripcion";
                    break;
                case "Marca":
                    consultaAux = "M.Descripcion";
                    break;
                case "Categoria":
                    consultaAux = "C.Descripcion";
                    break;
                default:
                    consultaAux = "";
                    break;
            }

            string buscarPor = " WHERE " + consultaAux + " LIKE '%" + txbDatoBuscarProducto.Text + "%';";
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.listar(buscarPor);
            dgvArticulos.DataSource = listaArticulos;
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.SelectedRows.Count > 0)
                {
                    DialogResult respuesta = MessageBox.Show("estas seguro que deseas eliminar el articulo", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.No) return;
                    DataGridViewRow row = dgvArticulos.SelectedRows[0];
                    string valor = row.Cells["id"].Value.ToString();
                    ArticuloNegocio Negocio = new ArticuloNegocio();
                    string mensaje = "El producto no pudo ser eliminado.";
                    if (Negocio.eliminar(int.Parse(valor)) > 0)
                    {
                        mensaje = "Producto eliminado exitosamente.";
                    }
                    MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarListaArticulos();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            AgregarArticulo AgregarProducto = new AgregarArticulo();
            AgregarProducto.ShowDialog();
        }
        
    }
}
