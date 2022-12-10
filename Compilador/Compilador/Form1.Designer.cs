namespace Compilador
{
    partial class Compilador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compilador));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novoctrlnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirctrloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarctrlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarctrlvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recortarctrlxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compilarF7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipeF1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox4 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoctrlnToolStripMenuItem,
            this.abrirctrloToolStripMenuItem,
            this.salvarctrlsToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.colarctrlvToolStripMenuItem,
            this.recortarctrlxToolStripMenuItem,
            this.compilarF7ToolStripMenuItem,
            this.equipeF1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(894, 70);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novoctrlnToolStripMenuItem
            // 
            this.novoctrlnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("novoctrlnToolStripMenuItem.Image")));
            this.novoctrlnToolStripMenuItem.Name = "novoctrlnToolStripMenuItem";
            this.novoctrlnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novoctrlnToolStripMenuItem.Size = new System.Drawing.Size(86, 66);
            this.novoctrlnToolStripMenuItem.Text = "novo [ctrl-n]";
            this.novoctrlnToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.novoctrlnToolStripMenuItem.Click += new System.EventHandler(this.novoctrlnToolStripMenuItem_Click);
            // 
            // abrirctrloToolStripMenuItem
            // 
            this.abrirctrloToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirctrloToolStripMenuItem.Image")));
            this.abrirctrloToolStripMenuItem.Name = "abrirctrloToolStripMenuItem";
            this.abrirctrloToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirctrloToolStripMenuItem.Size = new System.Drawing.Size(83, 66);
            this.abrirctrloToolStripMenuItem.Text = "abrir [ctrl-o]";
            this.abrirctrloToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.abrirctrloToolStripMenuItem.Click += new System.EventHandler(this.abrirctrloToolStripMenuItem_Click);
            // 
            // salvarctrlsToolStripMenuItem
            // 
            this.salvarctrlsToolStripMenuItem.Checked = true;
            this.salvarctrlsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.salvarctrlsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salvarctrlsToolStripMenuItem.Image")));
            this.salvarctrlsToolStripMenuItem.Name = "salvarctrlsToolStripMenuItem";
            this.salvarctrlsToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.salvarctrlsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarctrlsToolStripMenuItem.Size = new System.Drawing.Size(87, 66);
            this.salvarctrlsToolStripMenuItem.Text = "salvar [ctrl-s]";
            this.salvarctrlsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.salvarctrlsToolStripMenuItem.Click += new System.EventHandler(this.salvarctrlsToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripMenuItem.Image")));
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeyDisplayString = "ctrl-c";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(91, 66);
            this.copiarToolStripMenuItem.Text = "copiar [ctrl-c]";
            this.copiarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // colarctrlvToolStripMenuItem
            // 
            this.colarctrlvToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("colarctrlvToolStripMenuItem.Image")));
            this.colarctrlvToolStripMenuItem.Name = "colarctrlvToolStripMenuItem";
            this.colarctrlvToolStripMenuItem.ShortcutKeyDisplayString = "ctrl-v";
            this.colarctrlvToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.colarctrlvToolStripMenuItem.Size = new System.Drawing.Size(84, 66);
            this.colarctrlvToolStripMenuItem.Text = "colar [ctrl-v]";
            this.colarctrlvToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.colarctrlvToolStripMenuItem.Click += new System.EventHandler(this.colarctrlvToolStripMenuItem_Click);
            // 
            // recortarctrlxToolStripMenuItem
            // 
            this.recortarctrlxToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("recortarctrlxToolStripMenuItem.Image")));
            this.recortarctrlxToolStripMenuItem.Name = "recortarctrlxToolStripMenuItem";
            this.recortarctrlxToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.recortarctrlxToolStripMenuItem.Size = new System.Drawing.Size(99, 66);
            this.recortarctrlxToolStripMenuItem.Text = "recortar [ctrl-x]";
            this.recortarctrlxToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.recortarctrlxToolStripMenuItem.Click += new System.EventHandler(this.recortarctrlxToolStripMenuItem_Click);
            // 
            // compilarF7ToolStripMenuItem
            // 
            this.compilarF7ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("compilarF7ToolStripMenuItem.Image")));
            this.compilarF7ToolStripMenuItem.Name = "compilarF7ToolStripMenuItem";
            this.compilarF7ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.compilarF7ToolStripMenuItem.Size = new System.Drawing.Size(89, 66);
            this.compilarF7ToolStripMenuItem.Text = "compilar [F7]";
            this.compilarF7ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.compilarF7ToolStripMenuItem.Click += new System.EventHandler(this.compilarF7ToolStripMenuItem_Click);
            // 
            // equipeF1ToolStripMenuItem
            // 
            this.equipeF1ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("equipeF1ToolStripMenuItem.Image")));
            this.equipeF1ToolStripMenuItem.Name = "equipeF1ToolStripMenuItem";
            this.equipeF1ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.equipeF1ToolStripMenuItem.Size = new System.Drawing.Size(78, 66);
            this.equipeF1ToolStripMenuItem.Text = "equipe [F1]";
            this.equipeF1ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.equipeF1ToolStripMenuItem.Click += new System.EventHandler(this.equipeF1ToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(27, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.textBox1.Size = new System.Drawing.Size(866, 279);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "";
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(-1, -1);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(894, 170);
            this.textBox2.TabIndex = 2;
            this.textBox2.WordWrap = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(0, 536);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(894, 25);
            this.textBox3.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Location = new System.Drawing.Point(0, 73);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox4);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Size = new System.Drawing.Size(894, 457);
            this.splitContainer1.SplitterDistance = 284;
            this.splitContainer1.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(3, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(46, 262);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "";
            // 
            // Compilador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(894, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(910, 600);
            this.Name = "Compilador";
            this.Text = "Compilador";
            this.Load += new System.EventHandler(this.Compilador_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem novoctrlnToolStripMenuItem;
        private ToolStripMenuItem abrirctrloToolStripMenuItem;
        private ToolStripMenuItem salvarctrlsToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem colarctrlvToolStripMenuItem;
        private ToolStripMenuItem recortarctrlxToolStripMenuItem;
        private ToolStripMenuItem compilarF7ToolStripMenuItem;
        private ToolStripMenuItem equipeF1ToolStripMenuItem;
        private RichTextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private SplitContainer splitContainer1;
        private RichTextBox textBox4;
    }
}