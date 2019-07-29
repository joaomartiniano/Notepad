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

        /// <summary>
        /// Indica se um ficheiro foi modificado desde a última vez que foi gravado.
        /// </summary>
        private bool textoModificado = false;

        /// <summary>
        /// Indica se o ficheiro é um novo ficheiro. Esta variável é necessária quando é aberto um novo ficheiro.
        /// </summary>
        private bool novoFicheiro = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Sem Título - Notepad";

            // Inicializar a opção Word Wrap
            Texto.WordWrap = true;
            // Assinalar na opção do menu Formatar, inserindo um checkmark, que a opção Word Wrap está ativa
            MenuFormWordWrap.Checked = true;
        }

        /// <summary>
        /// Criar um novo ficheiro.
        /// </summary>
        private void MenuFormNovo_Click(object sender, EventArgs e)
        {
            // Se o ficheiro foi modificado e não gravado, informar o utilizador
            if (textoModificado)
            {
                DialogResult resultado = MessageBox.Show("O ficheiro foi modificado. Deseja gravar?", "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Guardar o ficheiro
                    Guardar();
                }
                else if (resultado == DialogResult.Cancel)
                {
                    // Cancelar a operação de criação de novo ficheiro
                    return;
                }
            }

            // Eliminar o conteúdo da caixa de texto
            Texto.Text = string.Empty;

            // Limpar as informações do ficheiro
            textoModificado = false;
            nomeFicheiro = string.Empty;
            localFicheiro = string.Empty;

            // Inicialmente o novo ficheiro não tem nome
            this.Text = "Sem título - Notepad";
        }

        /// <summary>
        /// Abrir um novo ficheiro.
        /// </summary>
        private void MenuFormAbrir_Click(object sender, EventArgs e)
        {
            // Se o ficheiro foi modificado e não gravado, informar o utilizador
            if (textoModificado)
            {
                DialogResult resultado = MessageBox.Show("O ficheiro foi modificado. Deseja gravar?", "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Guardar o ficheiro
                    Guardar();
                }
                else if (resultado == DialogResult.Cancel)
                {
                    // Cancelar a operação de abertura de novo ficheiro
                    return;
                }
            }

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

                // Indicar que o ficheiro ainda não foi modificado
                textoModificado = false;

                // Indicar que foi aberto um novo ficheiro
                novoFicheiro = true;
            }
        }

        /// <summary>
        /// Guardar o ficheiro atual.
        /// </summary>
        private void MenuFormGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        /// <summary>
        /// Guardar o ficheiro atual, especificando um nome e localização.
        /// </summary>
        private void MenuFormGuardarComo_Click(object sender, EventArgs e)
        {
            GuardarComo();
        }

        /// <summary>
        /// Guardar o ficheiro atual.
        /// </summary>
        private void Guardar()
        {
            // Se o ficheiro ainda não foi guardado, executar o método GuardarComo()
            if ((nomeFicheiro == string.Empty) || (localFicheiro == string.Empty))
            {
                GuardarComo();
            }
            else
            {
                // Guardar o ficheiro
                File.WriteAllText(Path.Combine(localFicheiro, nomeFicheiro), Texto.Text, Encoding.UTF8);

                // Mudar o título da janela para o nome do ficheiro
                this.Text = nomeFicheiro + " - Notepad";

                // Indicar que não ocorreu modificação desde a última gravação
                textoModificado = false;
            }
        }

        /// <summary>
        /// Guardar o ficheiro atual especificando um nome e localização.
        /// </summary>
        private void GuardarComo()
        {
            saveFileDialog1.Title = "Guardar como";
            saveFileDialog1.Filter = "Ficheiros de texto (*.txt)|*.txt|Todos os ficheiros (*.*)|*.*";
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.DefaultExt = "txt";

            // Verificar que a localização especificada pelo utilizador existe
            saveFileDialog1.CheckPathExists = true;

            // Ir para a diretoria do ficheiro (se existir uma localização de ficheiro)
            if (localFicheiro != string.Empty)
            {
                saveFileDialog1.InitialDirectory = localFicheiro;
            }

            // Especificar o nome do ficheiro
            saveFileDialog1.FileName = nomeFicheiro;

            // Mostrar o SaveFileDialog e verificar o resultado da operação
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Armazenar o nome e a localização na qual o ficheiro foi gravado
                nomeFicheiro = Path.GetFileName(saveFileDialog1.FileName);
                localFicheiro = Path.GetDirectoryName(saveFileDialog1.FileName);

                // Mudar o título da janela para o nome do ficheiro
                this.Text = nomeFicheiro + " - Notepad";

                // Gravar o conteúdo do ficheiro
                File.WriteAllText(saveFileDialog1.FileName, Texto.Text, Encoding.UTF8);

                // Indicar que não ocorreu modificação desde a última gravação
                textoModificado = false;
            }
        }

        /// <summary>
        /// Terminar a aplicação.
        /// </summary>
        private void MenuFormSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Ligar/desligar word wrap na caixa de texto.
        /// </summary>
        private void MenuFormWordWrap_Click(object sender, EventArgs e)
        {
            // Atribuir à propriedade WordWrap o valor contrário ao que tem neste momento
            Texto.WordWrap = !Texto.WordWrap;

            // Mostrar/esconder uma checkmark consoante o valor da propriedade WordWrap
            MenuFormWordWrap.Checked = Texto.WordWrap;
        }

        /// <summary>
        // Mostrar ao utilizador uma caixa de diálogo para escolher o tipo de letra.
        /// </summary>
        private void MenuFormFonte_Click(object sender, EventArgs e)
        {
            // Inicializar a fonte e a cor do texto
            fontDialog1.Font = Texto.Font;
            fontDialog1.Color = Texto.ForeColor;

            // Permitir que o utilizador selecione a cor do texto
            fontDialog1.ShowColor = true;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                // Modificar a fonte e a cor da caixa de texto
                Texto.Font = fontDialog1.Font;
                Texto.ForeColor = fontDialog1.Color;
            }
        }

        /// <summary>
        /// Mostrar informações acerca desta aplicação.
        /// </summary>
        private void MenuFormAcerca_Click(object sender, EventArgs e)
        {
            FormAcerca frmAcercaNotepad = new FormAcerca();

            frmAcercaNotepad.ShowDialog();
            frmAcercaNotepad.Dispose();
        }

        /// <summary>
        /// Este evento é executado sempre que o texto é modificado no controlo Texto.
        /// </summary>
        private void Texto_TextChanged(object sender, EventArgs e)
        {
            /* Verificar se um ficheiro acabou de ser aberto:
             * neste caso não executar o código que normalmente é executado quando o conteúdo da caixa
             * de texto é modificado
             * */
            if (!novoFicheiro)
            {
                // Mudar o título da janela uma única vez (apenas quando ocorre a modificação pela primeira vez)
                if (!textoModificado)
                {
                    this.Text = "* " + this.Text;
                }

                // Indicar que o ficheiro foi modificado
                textoModificado = true;
            }
            else
            {
                novoFicheiro = false;
            }
        }
    }
}
