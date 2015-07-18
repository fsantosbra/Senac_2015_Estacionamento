using prjEstacionamento.Sources.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjEstacionamento.Sources.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            if (!txtLogin.Text.Equals("mestre"))
            {
                usuario = usuario.retornaUsuario(txtLogin.Text);
                if (Convert.ToString(usuario.Id) == String.Empty)
                {
                    MessageBox.Show("Usuário ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLogin.Focus();
                    return;
                }

                MD5 md5Hash = MD5.Create();
                if (!VerifyMd5Hash(md5Hash, txtSenha.Text, usuario.senha))
                {
                    MessageBox.Show("Usuário ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLogin.Focus();
                    return;
                }
            }
            else
            {
                usuario.Id = -1;
                usuario.idgrupo = -1;
            }
            txtLogin.Focus();

            Menu menu = new Menu();
            menu.login = this;
            menu.idUsuario = usuario.Id;
            GrupoPermissao permissao = new GrupoPermissao();
            menu.permissoes = permissao.ListarGrupoPermissao(usuario.idgrupo);
            menu.Show();
            this.Visible = false;
        }

        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public void limpaCampos()
        {
            txtLogin.Text = String.Empty;
            txtSenha.Text = String.Empty;
        }
    }
}
