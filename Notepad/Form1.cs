using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    public partial class Form1 : Form
    {

        /// <summary>
        /// O nome do ficheiro em edição.
        /// </summary>
        private string nomeFicheiro = string.Empty;

        /// <summary>
        /// A localização do ficheiro em edição.
        /// </summary>
        private string localFicheiro = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Sem Título - Notepad";
        }

        /// <summary>
        /// Criar um novo ficheiro.
        /// </summary>
        private void MenuFormNovo_Click(object sender, EventArgs e)
        {
            // Eliminar o conteúdo da caixa de texto
            Texto.Text = string.Empty;

            // Inicialmente o novo ficheiro não tem nome
            this.Text = "Sem título - Notepad";
        }

        /// <summary>
        /// Terminar a aplicação.
        /// </summary>
        private void MenuFormSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
