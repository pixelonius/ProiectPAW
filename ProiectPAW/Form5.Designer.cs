namespace ProiectPAW
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.tbFurnizor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCantitate = new System.Windows.Forms.TextBox();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salvareFisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citireFisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desereializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFurnizor
            // 
            this.tbFurnizor.Location = new System.Drawing.Point(111, 38);
            this.tbFurnizor.Multiline = true;
            this.tbFurnizor.Name = "tbFurnizor";
            this.tbFurnizor.ReadOnly = true;
            this.tbFurnizor.Size = new System.Drawing.Size(265, 22);
            this.tbFurnizor.TabIndex = 0;
            this.tbFurnizor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Furnizor: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Produse: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Denumire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantitate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(608, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pret";
            // 
            // tbCantitate
            // 
            this.tbCantitate.Location = new System.Drawing.Point(300, 178);
            this.tbCantitate.Multiline = true;
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.ReadOnly = true;
            this.tbCantitate.Size = new System.Drawing.Size(100, 26);
            this.tbCantitate.TabIndex = 7;
            this.tbCantitate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(576, 178);
            this.tbPret.Multiline = true;
            this.tbPret.Name = "tbPret";
            this.tbPret.ReadOnly = true;
            this.tbPret.Size = new System.Drawing.Size(100, 26);
            this.tbPret.TabIndex = 8;
            this.tbPret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(37, 192);
            this.tbDenumire.Multiline = true;
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.ReadOnly = true;
            this.tbDenumire.Size = new System.Drawing.Size(100, 22);
            this.tbDenumire.TabIndex = 9;
            this.tbDenumire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareFisierTextToolStripMenuItem,
            this.citireFisierTextToolStripMenuItem,
            this.serializareToolStripMenuItem,
            this.desereializareToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 92);
            // 
            // salvareFisierTextToolStripMenuItem
            // 
            this.salvareFisierTextToolStripMenuItem.Name = "salvareFisierTextToolStripMenuItem";
            this.salvareFisierTextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvareFisierTextToolStripMenuItem.Text = "Salvare fisier text";
            this.salvareFisierTextToolStripMenuItem.Click += new System.EventHandler(this.salvareFisierTextToolStripMenuItem_Click);
            // 
            // citireFisierTextToolStripMenuItem
            // 
            this.citireFisierTextToolStripMenuItem.Name = "citireFisierTextToolStripMenuItem";
            this.citireFisierTextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.citireFisierTextToolStripMenuItem.Text = "Citire fisier text";
            this.citireFisierTextToolStripMenuItem.Click += new System.EventHandler(this.citireFisierTextToolStripMenuItem_Click);
            // 
            // serializareToolStripMenuItem
            // 
            this.serializareToolStripMenuItem.Name = "serializareToolStripMenuItem";
            this.serializareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serializareToolStripMenuItem.Text = "Serializare";
            // 
            // desereializareToolStripMenuItem
            // 
            this.desereializareToolStripMenuItem.Name = "desereializareToolStripMenuItem";
            this.desereializareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.desereializareToolStripMenuItem.Text = "Desereializare";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.tbCantitate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFurnizor);
            this.Name = "Form5";
            this.Text = "Form5";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFurnizor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCantitate;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvareFisierTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citireFisierTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desereializareToolStripMenuItem;
    }
}