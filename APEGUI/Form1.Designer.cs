namespace APEGUI {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.texToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.untilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Open_Script_File = new System.Windows.Forms.Button();
            this.Save_Script_File = new System.Windows.Forms.Button();
            this.Package_archive = new System.Windows.Forms.Button();
            this.AllTextAdd = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.pakToolStripMenuItem,
            this.texToolStripMenuItem,
            this.fntToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 194);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assertToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(149, 38);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // assertToolStripMenuItem
            // 
            this.assertToolStripMenuItem.Name = "assertToolStripMenuItem";
            this.assertToolStripMenuItem.Size = new System.Drawing.Size(213, 44);
            this.assertToolStripMenuItem.Text = "Assert";
            this.assertToolStripMenuItem.Click += new System.EventHandler(this.assertToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(149, 38);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // pakToolStripMenuItem
            // 
            this.pakToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractToolStripMenuItem,
            this.repackToolStripMenuItem});
            this.pakToolStripMenuItem.Name = "pakToolStripMenuItem";
            this.pakToolStripMenuItem.Size = new System.Drawing.Size(149, 38);
            this.pakToolStripMenuItem.Text = "Pak";
            // 
            // extractToolStripMenuItem
            // 
            this.extractToolStripMenuItem.Name = "extractToolStripMenuItem";
            this.extractToolStripMenuItem.Size = new System.Drawing.Size(224, 44);
            this.extractToolStripMenuItem.Text = "Extract";
            this.extractToolStripMenuItem.Click += new System.EventHandler(this.extractToolStripMenuItem_Click);
            // 
            // repackToolStripMenuItem
            // 
            this.repackToolStripMenuItem.Name = "repackToolStripMenuItem";
            this.repackToolStripMenuItem.Size = new System.Drawing.Size(224, 44);
            this.repackToolStripMenuItem.Text = "Repack";
            this.repackToolStripMenuItem.Click += new System.EventHandler(this.repackToolStripMenuItem_Click);
            // 
            // texToolStripMenuItem
            // 
            this.texToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decodeToolStripMenuItem,
            this.encodeToolStripMenuItem,
            this.untilerToolStripMenuItem,
            this.retilerToolStripMenuItem});
            this.texToolStripMenuItem.Name = "texToolStripMenuItem";
            this.texToolStripMenuItem.Size = new System.Drawing.Size(149, 38);
            this.texToolStripMenuItem.Text = "Tex";
            // 
            // decodeToolStripMenuItem
            // 
            this.decodeToolStripMenuItem.Name = "decodeToolStripMenuItem";
            this.decodeToolStripMenuItem.Size = new System.Drawing.Size(231, 44);
            this.decodeToolStripMenuItem.Text = "Decode";
            this.decodeToolStripMenuItem.Click += new System.EventHandler(this.decodeToolStripMenuItem_Click);
            // 
            // encodeToolStripMenuItem
            // 
            this.encodeToolStripMenuItem.Name = "encodeToolStripMenuItem";
            this.encodeToolStripMenuItem.Size = new System.Drawing.Size(231, 44);
            this.encodeToolStripMenuItem.Text = "Encode";
            this.encodeToolStripMenuItem.Click += new System.EventHandler(this.encodeToolStripMenuItem_Click);
            // 
            // untilerToolStripMenuItem
            // 
            this.untilerToolStripMenuItem.Name = "untilerToolStripMenuItem";
            this.untilerToolStripMenuItem.Size = new System.Drawing.Size(231, 44);
            this.untilerToolStripMenuItem.Text = "Untiler";
            this.untilerToolStripMenuItem.Click += new System.EventHandler(this.untilerToolStripMenuItem_Click);
            // 
            // retilerToolStripMenuItem
            // 
            this.retilerToolStripMenuItem.Name = "retilerToolStripMenuItem";
            this.retilerToolStripMenuItem.Size = new System.Drawing.Size(231, 44);
            this.retilerToolStripMenuItem.Text = "Retiler";
            this.retilerToolStripMenuItem.Click += new System.EventHandler(this.retilerToolStripMenuItem_Click);
            // 
            // fntToolStripMenuItem
            // 
            this.fntToolStripMenuItem.Name = "fntToolStripMenuItem";
            this.fntToolStripMenuItem.Size = new System.Drawing.Size(149, 38);
            this.fntToolStripMenuItem.Text = "Fnt";
            this.fntToolStripMenuItem.Click += new System.EventHandler(this.fntToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(24, 23);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1120, 654);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(24, 712);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1317, 31);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Open_Script_File
            // 
            this.Open_Script_File.Location = new System.Drawing.Point(1173, 23);
            this.Open_Script_File.Name = "Open_Script_File";
            this.Open_Script_File.Size = new System.Drawing.Size(142, 50);
            this.Open_Script_File.TabIndex = 3;
            this.Open_Script_File.Text = "OpenScript";
            this.Open_Script_File.UseVisualStyleBackColor = true;
            this.Open_Script_File.Click += new System.EventHandler(this.Open_Script_File_Click);
            // 
            // Save_Script_File
            // 
            this.Save_Script_File.Location = new System.Drawing.Point(1173, 92);
            this.Save_Script_File.Name = "Save_Script_File";
            this.Save_Script_File.Size = new System.Drawing.Size(142, 50);
            this.Save_Script_File.TabIndex = 4;
            this.Save_Script_File.Text = "SaveScript";
            this.Save_Script_File.UseVisualStyleBackColor = true;
            this.Save_Script_File.Click += new System.EventHandler(this.Save_Script_File_Click);
            // 
            // Package_archive
            // 
            this.Package_archive.Location = new System.Drawing.Point(1173, 159);
            this.Package_archive.Name = "Package_archive";
            this.Package_archive.Size = new System.Drawing.Size(142, 45);
            this.Package_archive.TabIndex = 5;
            this.Package_archive.Text = "Package";
            this.Package_archive.UseVisualStyleBackColor = true;
            this.Package_archive.Click += new System.EventHandler(this.Package_archive_Click);
            // 
            // AllTextAdd
            // 
            this.AllTextAdd.Location = new System.Drawing.Point(1173, 234);
            this.AllTextAdd.Name = "AllTextAdd";
            this.AllTextAdd.Size = new System.Drawing.Size(115, 53);
            this.AllTextAdd.TabIndex = 6;
            this.AllTextAdd.Text = "AllText";
            this.AllTextAdd.UseVisualStyleBackColor = true;
            this.AllTextAdd.Click += new System.EventHandler(this.AllTextAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 777);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.AllTextAdd);
            this.Controls.Add(this.Package_archive);
            this.Controls.Add(this.Save_Script_File);
            this.Controls.Add(this.Open_Script_File);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "APEGUI";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repackToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem fntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem texToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem untilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retilerToolStripMenuItem;
        private System.Windows.Forms.Button Open_Script_File;
        private System.Windows.Forms.Button Save_Script_File;
        private System.Windows.Forms.Button Package_archive;
        private System.Windows.Forms.Button AllTextAdd;
    }
}

