using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App;
using dominio;
using negocio;

namespace winform_app
{
    public partial class frmPrincipal : Form
    {
        //private List<Pokemon> listaPokemon;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCataologo_Click(object sender, EventArgs e)
        {
            frmCatalogo catalogo = new frmCatalogo();
            catalogo.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatalogo catalogo = new frmCatalogo();
            catalogo.ShowDialog();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarcas marcas = new frmMarcas();
            marcas.ShowDialog();
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias categorias = new frmCategorias();
            categorias.ShowDialog();
        }


        //private void frmPokemons_Load(object sender, EventArgs e)
        //{
        //    PokemonNegocio negocio = new PokemonNegocio();
        //    listaPokemon = negocio.listar();
        //    dgvPokemons.DataSource = listaPokemon;
        //    dgvPokemons.Columns["UrlImagen"].Visible = false;
        //    cargarImagen(listaPokemon[0].UrlImagen);
        //}

        //private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        //{
        //    Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
        //    cargarImagen(seleccionado.UrlImagen);

        //}

        //private void cargarImagen(string imagen)
        //{
        //    try
        //    {
        //        pbxPokemon.Load(imagen);
        //    }
        //    catch (Exception ex)
        //    {
        //        pbxPokemon.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
        //    }
        //}


    }
}
