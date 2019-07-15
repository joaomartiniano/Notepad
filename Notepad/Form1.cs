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
        /// Abrir um novo ficheiro.
        /// </summary>
        private void MenuFormAbrir_Click(object sender, EventArgs e)
        {
            // Título
            openFileDialog1.Title = "Abrir";
            // Permitir selecionar apenas um ficheiro
            openFileDialog1.Multiselect = false;
            // Tipos de ficheiros que podem ser abertos
            openFileDialog1.Filter = "Ficheiros de texto (*.txt)|*.txt|Todos os ficheiros (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;

            // Verificar que o nome e a localização especificadas pelo utilizador existem
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.FileName = string.Empty;

            // Mostrar o OpenFileDialog e verificar o resultado da operação
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Armazenar o nome e a localização do novo ficheiro
                nomeFicheiro = Path.GetFileName(openFileDialog1.FileName);
                localFicheiro = Path.GetDirectoryName(openFileDialog1.FileName);

                // Mudar o título da janela para o nome do ficheiro
                this.Text = nomeFicheiro + " - Notepad";

                // Abrir o ficheiro e colocar o conteúdo na caixa de texto
                Texto.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.UTF8);
            }
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
