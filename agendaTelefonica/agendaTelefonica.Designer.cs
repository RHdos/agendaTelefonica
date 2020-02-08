namespace agendaTelefonica
{
    partial class agendaTelefonica
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adicionarContatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adicionarContatoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarContatoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarContatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarContatoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 26);
            // 
            // adicionarContatoToolStripMenuItem
            // 
            this.adicionarContatoToolStripMenuItem.Name = "adicionarContatoToolStripMenuItem";
            this.adicionarContatoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.adicionarContatoToolStripMenuItem.Text = "Adicionar Contato";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarContatoToolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(563, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adicionarContatoToolStripMenuItem1
            // 
            this.adicionarContatoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarContatoToolStripMenuItem2,
            this.buscarContatoToolStripMenuItem});
            this.adicionarContatoToolStripMenuItem1.Name = "adicionarContatoToolStripMenuItem1";
            this.adicionarContatoToolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            this.adicionarContatoToolStripMenuItem1.Text = "Contatos";
            // 
            // adicionarContatoToolStripMenuItem2
            // 
            this.adicionarContatoToolStripMenuItem2.Name = "adicionarContatoToolStripMenuItem2";
            this.adicionarContatoToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.adicionarContatoToolStripMenuItem2.Text = "Adicionar Contato";
            this.adicionarContatoToolStripMenuItem2.Click += new System.EventHandler(this.adicionarContatoToolStripMenuItem2_Click);
            // 
            // buscarContatoToolStripMenuItem
            // 
            this.buscarContatoToolStripMenuItem.Name = "buscarContatoToolStripMenuItem";
            this.buscarContatoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buscarContatoToolStripMenuItem.Text = "Buscar Contato";
            this.buscarContatoToolStripMenuItem.Click += new System.EventHandler(this.buscarContatoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // agendaTelefonica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 281);
            this.Controls.Add(this.menuStrip1);
            this.Name = "agendaTelefonica";
            this.Text = "Agenda Telefonica";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adicionarContatoToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adicionarContatoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adicionarContatoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem buscarContatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

