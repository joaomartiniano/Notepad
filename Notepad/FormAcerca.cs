// Copyright(c) João Martiniano. All rights reserved.
// Licensed under the MIT license.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Notepad
{
    public partial class FormAcerca : Form
    {
        public FormAcerca()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fechar esta janela.
        /// </summary>
        private void BtFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
