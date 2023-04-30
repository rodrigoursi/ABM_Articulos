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
                // Cargar la imagen en un objeto Image
                string url = "https://www.example.com/image.jpg";
                System.Drawing.Image image = null;
                using (var client = new System.Net.WebClient())
                {
                    using (var stream = new System.IO.MemoryStream(client.DownloadData(url)))
                    {
                        image = Image.FromStream(stream);
                    }
                }

                

                ImagenNegocio negocio = new ImagenNegocio();
                listaImagenes = negocio.listar();
                //MessageBox.Show(listaImagenes.Count.ToString());
                //pcbImagenProducto.Load((String)listaImagenes[1].ImagenUrl);
                for (int i = 0; i < listaImagenes.Count; i++)
                {
                    //MessageBox.Show((string)listaImagenes[i].IdArticulo.ToString());
                    //MessageBox.Show((String)productoAux.id.ToString());
                    if (listaImagenes[i].IdArticulo == productoAux.id)
                    {
                        label1.Text = (String)listaImagenes[i].ImagenUrl;
                        textBox1.Text = (String)listaImagenes[i].ImagenUrl;
                        pcbImagenProducto.Image = Image;// Load("https://intercompras.com/product_thumb_keepratio_2.php?img=images/product/SONY_KDL-55W950A.jpg&w=650&h=450");//(String)listaImagenes[i].ImagenUrl);
                        //MessageBox.Show("econtr[o");
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
