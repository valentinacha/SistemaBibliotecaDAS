using System;
using System.Windows.Forms;
using SistemaBiblioteca.Services;
using SistemaBiblioteca.Models;

namespace SistemaBiblioteca.Forms
{
    public partial class FormPrestamos : Form
    {
        BibliotecaManager manager = new BibliotecaManager();

        public FormPrestamos() 
        {
            InitializeComponent();
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            Libro libro = manager.libros.Find(1 => 1.Id == int.Parse(txtIdLibro.Text));
            Usuario usuario = manager.usuarios.Find(u => u.Id == int.Parse(txtIdUsuario.Text));

            Prestamo prestamo = new Prestamo( 
                int.Parse(txtId.Text),
                libro,
                usuario,
                DateTime.Now
            );

            manager.RegistrarPrestamo(prestamo);

            tablaPrestamos.DataSource = null;
            tablaPrestamos.DataSource = manager.prestamos;
        }
    }