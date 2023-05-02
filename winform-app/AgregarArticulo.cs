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
    public partial class AgregarArticulo : Form
    {
        public AgregarArticulo()
        {
            InitializeComponent();
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Desea guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                Articulo articulo = new Articulo();
                articulo.codigo = txtCodigo.Text;
                articulo.nombre = txtNombre.Text;
                articulo.descripcion = txtDescripcion.Text;
                articulo.precio = decimal.Parse(txtPrecio.Text);
                articulo.marca = (Marca)cmbMarca.SelectedItem;
                articulo.categoria = (Categoria)cmbCategoria.SelectedItem;

                ArticuloNegocio negocio = new ArticuloNegocio();
                int resultado = negocio.agregar(articulo);

                // Verificar si se actualizo el registro
                if (resultado > 0)
                {
                    MessageBox.Show("El articulo se guardo correctamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmCatalogo catalogo = (frmCatalogo)Application.OpenForms["frmCatalogo"];
                    if (catalogo != null)
                    {
                        catalogo.ActualizarListaArticulos();
                    }
                    Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el artículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmEditarProducto_Load(object sender, EventArgs e)
        {
            // Cargar Marcas en el ComboBox
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            List<Marca> marcas = marcaNegocio.listar();
            cmbMarca.DataSource = marcas;
            cmbMarca.DisplayMember = "descripcion";
            cmbMarca.ValueMember = "id";

            // Seleccionar la marca del artículo
            //MessageBox.Show("Esto tiene articulo.marca.id" + articulo.marca.id + " y Esto tiene articulo.marca.desc " + articulo.marca.descripcion);
            //cmbMarca.SelectedValue = articulo.marca.id;

            // Cargar  categorias en el ComboBox
            CategoriasNegocio categoriaNegocio = new CategoriasNegocio();
            List<Categoria> categorias = categoriaNegocio.listar();
            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "descripcion";
            cmbCategoria.ValueMember = "id";

            // Seleccionar la categoría del artículo
            //cmbCategoria.SelectedValue = articulo.categoria.id;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
