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
    public partial class frmFichaProducto : Form
    {
        private List<ImagenProductos> listaImagenes;

        private Articulo productoAux;
        public frmFichaProducto(Articulo producto)
        {
            this.productoAux = producto;
            InitializeComponent();
            txbNombreProducto.Text = producto.nombre;
            txbCodigoProducto.Text = producto.codigo;
            cmbMarcaProducto.Text = producto.marca.descripcion;
            cmbCategoriaProducto.Text = producto.categoria.descripcion;
            txbDescripcionProducto.Text = producto.descripcion;

        }

        private void frmFichaProducto_Load(object sender, EventArgs e)
        {
            try
            {   
                ImagenNegocio negocio = new ImagenNegocio();
                listaImagenes = negocio.listar();

                for (int i = 0; i < listaImagenes.Count; i++)
                {
                    if (listaImagenes[i].IdArticulo == productoAux.id)
                    {
                        label1.Text = (String)listaImagenes[i].ImagenUrl;
                        textBox1.Text = (String)listaImagenes[i].ImagenUrl;
                        pcbImagenProducto.Load((String)listaImagenes[i].ImagenUrl);
                        break;

                    }

                }
            }
            catch (Exception ex)
            {
                //pcbImagenProducto.Load("https://gesisarg.com/sistema-gestion/res/archivos/imagen_articulo_por_defecto.jpg");
                MessageBox.Show(ex.Message);
                //throw ex;
            }

        }
    }
}
