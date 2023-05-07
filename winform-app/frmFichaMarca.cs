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
    public partial class frmFichaMarca : Form
    {
        Marca marcaAux = new Marca();
        private int modo;

        public frmFichaMarca(Marca marca, int mode = 0) // MODO=1 para VER, MODO=0 para Editar, MODO=2 para NUEVO
        {
            InitializeComponent();
            this.marcaAux = marca;
            this.modo = mode;

            if (modo == 1) //MODO NUEVO
            {
                txbDescripcionMarca.Text = "";
            }
            if (modo == 0 || modo == 1)  // = 0 MODO EDITAR
            {
                txbDescripcionMarca.Text = marcaAux.descripcion;
            }

            if (modo == 1) //MODO VER (sin editar)
            {
                txbDescripcionMarca.Enabled = false;
                btnGuardaMarca.Visible = false;
            }
        }


        private void frmFichaProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardaMarca_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Desea guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                Marca marcaModificada = new Marca();

                marcaModificada.descripcion = txbDescripcionMarca.Text;

                MarcaNegocio negocio = new MarcaNegocio();
                int resultado = 0;

                if (modo == 0)
                {
                    marcaModificada.id = marcaAux.id; // Se matiene el mismo ID
                    resultado = negocio.editar(marcaModificada);
                }
                if (modo == 2)
                {
                    resultado = negocio.agregar(marcaModificada);
                }



                // Verificar si se actualizo el registro
                if (resultado > 0)
                {
                    MessageBox.Show("La marca se actualizó correctamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMarcas marcas = (frmMarcas)Application.OpenForms["frmMarcas"];
                    if (marcas != null)
                    {
                        marcas.ActualizarListaMarcas();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar la marca.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalirEditorMarca_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
