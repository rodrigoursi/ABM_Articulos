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
        private int indiceImagenActual;

        private List<ImagenProductos> imagenesEnCache = new List<ImagenProductos>();

        private Articulo productoAux;
        private int modo;


        public frmFichaProducto(Articulo producto, int mode = 0) // MODO=1 para VER, MODO=0 para Editar, MODO=2 para NUEVO
        {
            InitializeComponent();
            this.productoAux = producto;
            this.modo = mode;


            // Cargar Marcas en el ComboBox
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            List<Marca> marcas = marcaNegocio.listar();
            cmbMarcaProducto.DataSource = marcas;
            cmbMarcaProducto.DisplayMember = "descripcion";
            cmbMarcaProducto.ValueMember = "id";

            // Cargar  categorias en el ComboBox
            CategoriasNegocio categoriaNegocio = new CategoriasNegocio();
            List<Categoria> categorias = categoriaNegocio.listar();
            cmbCategoriaProducto.DataSource = categorias;
            cmbCategoriaProducto.DisplayMember = "descripcion";
            cmbCategoriaProducto.ValueMember = "id";


            if (modo == 2) //MODO NUEVO
            {
                txbNombreProducto.Text = "";
                txbCodigoProducto.Text = "";
                txbPrecioProducto.Text = "";
                cmbMarcaProducto.Text = "";
                cmbCategoriaProducto.Text = "";
                txbDescripcionProducto.Text = "";

                btnAgregarImagenProducto.Visible = true;
                btnEliminarImagenProducto.Visible = true;

            }
            if (modo == 0 || modo == 1)  // = 0 MODO EDITAR
            {
                txbNombreProducto.Text = productoAux.nombre;
                txbCodigoProducto.Text = productoAux.codigo;
                txbPrecioProducto.Text = productoAux.precio.ToString();

                // Seleccionar la marca del artículo
                //MessageBox.Show("Esto tiene articulo.marca.id" + articulo.marca.id + " y Esto tiene articulo.marca.desc " + articulo.marca.descripcion);
                cmbMarcaProducto.SelectedValue = productoAux.marca.id;

                // Seleccionar la categoría del artículo
                cmbCategoriaProducto.SelectedValue = productoAux.categoria.id;

                txbDescripcionProducto.Text = productoAux.descripcion;


                if (modo == 1) //MODO VER (sin editar)
                {
                    txbNombreProducto.Enabled = false;
                    txbCodigoProducto.Enabled = false;
                    txbPrecioProducto.Enabled = false;
                    cmbMarcaProducto.Enabled = false;
                    cmbCategoriaProducto.Enabled = false;
                    txbDescripcionProducto.Enabled = false;
                    btnGuardar.Visible = false;
                }

                if (modo == 0)
                {
                    btnAgregarImagenProducto.Visible = true;
                    btnEliminarImagenProducto.Visible = true;
                }
            }
        }

        private void frmFichaProducto_Load(object sender, EventArgs e)
        {
            try
            {
                ImagenNegocio negocio = new ImagenNegocio();
                listaImagenes = negocio.listar(productoAux.id);

                indiceImagenActual = 0;

                pcbImagenProducto.Load((String)listaImagenes[indiceImagenActual].ImagenUrl);

            }
            catch (Exception ex)
            {
                pcbImagenProducto.Load("https://gesisarg.com/sistema-gestion/res/archivos/imagen_articulo_por_defecto.jpg");
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Desea guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                Articulo articuloModificado = new Articulo();


                articuloModificado.codigo = txbCodigoProducto.Text;
                articuloModificado.nombre = txbNombreProducto.Text;
                articuloModificado.descripcion = txbDescripcionProducto.Text;
                articuloModificado.precio = decimal.Parse(txbPrecioProducto.Text);

                //foreach (ImagenProductos i in listaImagenes)
                //{
                //    ImagenNegocio negocio1 = new ImagenNegocio();
                //    ImagenProductos imagen = new ImagenProductos();

                //    imagen.IdArticulo = imagenesEnCache[i].IdArticulo;
                //    imagen.ImagenUrl = imagenesEnCache[1].ImagenUrl;

                //    negocio1.agregar(imagen.IdArticulo, imagen.ImagenUrl);

                //}

                // Validar Marca y Categoria
                if (cmbMarcaProducto.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione una marca válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                articuloModificado.marca = (Marca)cmbMarcaProducto.SelectedItem;

                if (cmbCategoriaProducto.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione una categoría válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                articuloModificado.categoria = (Categoria)cmbCategoriaProducto.SelectedItem;

                ArticuloNegocio negocio = new ArticuloNegocio();
                int resultado = 0;

                if (modo == 0)
                {
                    articuloModificado.id = productoAux.id; // Se matiene el mismo ID
                    resultado = negocio.editar(articuloModificado);
                }
                if (modo == 2)
                {
                    resultado = negocio.agregar(articuloModificado);
                }



                // Verificar si se actualizo el registro
                if (resultado > 0)
                {
                    MessageBox.Show("El articulo se actualizó correctamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmCatalogo catalogo = (frmCatalogo)Application.OpenForms["frmCatalogo"];
                    if (catalogo != null)
                    {
                        catalogo.ActualizarListaArticulos();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el artículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImageLeft_Click(object sender, EventArgs e)
        {
            try
            {
                if ((indiceImagenActual + 1) > 1)
                {
                    indiceImagenActual--;
                    pcbImagenProducto.Load((String)listaImagenes[indiceImagenActual].ImagenUrl);
                    btnImageRight.Enabled = true;
                }
                else
                {
                    btnImageLeft.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                pcbImagenProducto.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSEaYTaC-q-QWUu2g7QgVvRKkJkqXjXtjBU2w&usqp=CAU");
            }
        }

        private void btnImageRight_Click(object sender, EventArgs e)
        {
            try
            {
                if ((indiceImagenActual + 1) < listaImagenes.Count)
                {
                    indiceImagenActual++;
                    pcbImagenProducto.Load((String)listaImagenes[indiceImagenActual].ImagenUrl);
                    btnImageLeft.Enabled = true;
                }
                else
                {
                    btnImageRight.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                pcbImagenProducto.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSEaYTaC-q-QWUu2g7QgVvRKkJkqXjXtjBU2w&usqp=CAU");
            }
        }

        private void btnBackOfCatalogo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarImagenProducto_Click(object sender, EventArgs e)
        {
            lblAgregarImagenProduccto.Visible = true;
            txbAgregarImagenProducto.Visible = true;
            btnConfirmarAgregarImagenProducto.Visible = true;
        }

        private void btnEliminarImagenProducto_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult respuesta = MessageBox.Show("estas seguro que deseas eliminar la imagen", "Eliminada", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.No) return;

                string valor = pcbImagenProducto.ImageLocation.ToString();

                ImagenNegocio Negocio = new ImagenNegocio();
                if (Negocio.eliminar(valor) < 1)
                {
                    string mensaje = "La imagen no pudo ser eliminada.";
                    MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnConfirmarAgregarImagenProducto_Click(object sender, EventArgs e)
        {
            ImagenProductos imagenAux = new ImagenProductos();


            imagenAux.ImagenUrl = txbAgregarImagenProducto.Text;
            imagenAux.IdArticulo = productoAux.id;

            pcbImagenProducto.Load((String)imagenAux.ImagenUrl);

            imagenesEnCache.Add(imagenAux);

            txbAgregarImagenProducto.Text = "";
        }
    }
}
