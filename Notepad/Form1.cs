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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Sem Título - Notepad";
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
