using System;
using System.Windows.Forms; 
using SistemaBiblioteca.Services;
using SistemaBiblioteca.Models;

namespace SistemaBiblioteca.Forms
{
    public partial class FormUsuarios : Form
    {
        BibliotecaManager manager = new BibliotecaManager();

        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(
                int.Parse(txtId.Text),
                txtNombre.Text,
                txtEmail.Text
            );

            manager.AgregarUsuario(usuario); 

            tablaUsuarios.DataSource = null;
            tablaUsuarios.DataSource = manager.usuarios;
        }
    }
}  