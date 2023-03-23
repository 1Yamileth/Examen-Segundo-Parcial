using BD;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Usuario_textBox.Focus();
        }

        private void Mostrar_button_Click(object sender, EventArgs e)
        {
            if (Contra_textBox.PasswordChar=='*')
            {
                Contra_textBox.PasswordChar = '\0';
            }
            else
            {
                Contra_textBox.PasswordChar = '*';
            }

        }

        private void Ingresar_button_Click(object sender, EventArgs e)
        {
            if (Usuario_textBox.Text==string.Empty)
            {
                errorProvider1.SetError(Usuario_textBox," INGRESE UN USUARIO VALIDO");
                Usuario_textBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (Contra_textBox.Text == string.Empty)
            {
                errorProvider1.SetError(Usuario_textBox, " INGRESE UNA CONTRASEÑA VALIDA");
                Contra_textBox.Focus();
                return;
            }

            Login login = new Login(Usuario_textBox.Text, Contra_textBox.Text);
            Usuario user= new Usuario();
            UsuarioBD usuarioBD = new UsuarioBD();

            user = usuarioBD.Autenticar(login);
            if (user != null)
            {
                    if (user.EstaActivo)
                    {
                        
                       MenuForm menuFormulario = new MenuForm();
                        Hide();
                        menuFormulario.Show();
                    }
                    else
                    {
                        MessageBox.Show("USUARIO INACTIVO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            else
            { 
                    MessageBox.Show("DATOS DE USUARIO INCORRECTOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
        }
    }
}
