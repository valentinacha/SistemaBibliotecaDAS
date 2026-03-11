using System;
using System.Windows.Forms;
using SistemaBiblioteca.Services;
using SistemaBiblioteca.Models;
using System.Security.Cryptography;

namespace SistemaBiblioteca.Forms
{
    public partial class FormLibros : Form
    {
        BibliotecaManager manager = new BibliotecaManager();

        public FormLibros()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Libro libro = new Libro(
                int.Parse(txtId.Text),
                txtTitulo.Text,
                txtAutor.Text,
                int.Parse(txtAnio.Text)
            );

            manager.AgregarLibro(libro); 

            tablaLibros.DataSource = null;
            tablaLibros.DataSource = manager.libros;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            manager.EliminarLibro(id);

            tablaLibros.DataSource = null;
            tablaLibros.DataSource = manager.libros;
    }
}  