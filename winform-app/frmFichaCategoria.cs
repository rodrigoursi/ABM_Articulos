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
    public partial class frmFichaCategoria : Form
    {
        Categoria categoriaAux = new Categoria();
        private int modo;

        public frmFichaCategoria(Categoria categoria, int mode = 0) // MODO=1 para VER, MODO=0 para Editar, MODO=2 para NUEVO
        {
            InitializeComponent();
            this.categoriaAux = categoria;
            this.modo = mode;

            if (modo == 1) //MODO NUEVO
            {
                txbDescripcionCategoria.Text = "";
            }
            if (modo == 0 || modo == 1)  // = 0 MODO EDITAR
            {
                txbDescripcionCategoria.Text = categoriaAux.descripcion;
            }

            if (modo == 1) //MODO VER (sin editar)
            {
                txbDescripcionCategoria.Enabled = false;
                btnGuardaCateogiroa.Visible = false;
            }
        }


        private void frmFichaProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardaCateogiroa_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Desea guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                Categoria categoriaModificada = new Categoria();

                categoriaModificada.descripcion = txbDescripcionCategoria.Text;

                CategoriasNegocio negocio = new CategoriasNegocio();
                int resultado = 0;

                if (modo == 0)
                {
                    categoriaModificada.id = categoriaAux.id; // Se matiene el mismo ID
                    resultado = negocio.editar(categoriaModificada);
                }
                if (modo == 2)
                {
                    resultado = negocio.agregar(categoriaModificada);
                }



                // Verificar si se actualizo el registro
                if (resultado > 0)
                {
                    MessageBox.Show("La categoria se actualizó correctamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmCategorias categorias = (frmCategorias)Application.OpenForms["frmCategorias"];
                    if (categorias != null)
                    {
                        categorias.ActualizarListaCategorias();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar la categoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalirEditorCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
