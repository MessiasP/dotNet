using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroProjeto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FormFundo_Load(object sender, EventArgs e)
        {

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if ( TxtSenha.Text == "" || TxtUsuario.Text == "" )
            {
                MessageBox.Show("Campo Invalido", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtUsuario.Focus();
            }
        }
    }
}
