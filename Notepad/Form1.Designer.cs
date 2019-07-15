namespace Notepad
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFormNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFormAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFormGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFormGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuFormSair = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFormAcerca = new System.Windows.Forms.ToolStripMenuItem();
            this.Texto = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFormNovo,
            this.MenuFormAbrir,
            this.MenuFormGuardar,
            this.MenuFormGuardarComo,
            this.toolStripMenuItem1,
            this.MenuFormSair});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheiroToolStripMenuItem.Text = "&Ficheiro";
            // 
            // MenuFormNovo
            // 
            this.MenuFormNovo.Name = "MenuFormNovo";
            this.MenuFormNovo.Size = new System.Drawing.Size(180, 22);
            this.MenuFormNovo.Text = "&Novo";
            this.MenuFormNovo.Click += new System.EventHandler(this.MenuFormNovo_Click);
            // 
            // MenuFormAbrir
            // 
            this.MenuFormAbrir.Name = "MenuFormAbrir";
            this.MenuFormAbrir.Size = new System.Drawing.Size(180, 22);
            this.MenuFormAbrir.Text = "&Abrir...";
            // 
            // MenuFormGuardar
            // 
            this.MenuFormGuardar.Name = "MenuFormGuardar";
            this.MenuFormGuardar.Size = new System.Drawing.Size(180, 22);
            this.MenuFormGuardar.Text = "&Guardar";
            // 
            // MenuFormGuardarComo
            // 
            this.MenuFormGuardarComo.Name = "MenuFormGuardarComo";
            this.MenuFormGuardarComo.Size = new System.Drawing.Size(180, 22);
            this.MenuFormGuardarComo.Text = "Guardar &Como...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // MenuFormSair
            // 
            this.MenuFormSair.Name = "MenuFormSair";
            this.MenuFormSair.Size = new System.Drawing.Size(180, 22);
            this.MenuFormSair.Text = "&Sair";
            this.MenuFormSair.Click += new System.EventHandler(this.MenuFormSair_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFormAcerca});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "&Ajuda";
            // 
            // MenuFormAcerca
            // 
            this.MenuFormAcerca.Name = "MenuFormAcerca";
            this.MenuFormAcerca.Size = new System.Drawing.Size(176, 22);
            this.MenuFormAcerca.Text = "&Acerca do Notepad";
            // 
            // Texto
            // 
            this.Texto.AcceptsTab = true;
            this.Texto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Texto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Texto.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto.Location = new System.Drawing.Point(0, 24);
            this.Texto.MaxLength = 65535;
            this.Texto.Multiline = true;
            this.Texto.Name = "Texto";
            this.Texto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Texto.Size = new System.Drawing.Size(584, 187);
            this.Texto.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 211);
            this.Controls.Add(this.Texto);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuFormNovo;
        private System.Windows.Forms.ToolStripMenuItem MenuFormAbrir;
        private System.Windows.Forms.ToolStripMenuItem MenuFormGuardar;
        private System.Windows.Forms.ToolStripMenuItem MenuFormGuardarComo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuFormSair;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuFormAcerca;
        private System.Windows.Forms.TextBox Texto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

