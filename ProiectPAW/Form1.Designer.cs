namespace ProiectPAW
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
            this.components = new System.ComponentModel.Container();
            this.tbNumeFurnizor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLocalitateFurnizor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTaraFurnizor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNumeFurnizor
            // 
            this.tbNumeFurnizor.Location = new System.Drawing.Point(129, 40);
            this.tbNumeFurnizor.Name = "tbNumeFurnizor";
            this.tbNumeFurnizor.Size = new System.Drawing.Size(100, 22);
            this.tbNumeFurnizor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume furnizor:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbLocalitateFurnizor
            // 
            this.tbLocalitateFurnizor.Location = new System.Drawing.Point(129, 102);
            this.tbLocalitateFurnizor.Name = "tbLocalitateFurnizor";
            this.tbLocalitateFurnizor.Size = new System.Drawing.Size(100, 22);
            this.tbLocalitateFurnizor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Localitate furnizor:";
            // 
            // tbTaraFurnizor
            // 
            this.tbTaraFurnizor.Location = new System.Drawing.Point(129, 172);
            this.tbTaraFurnizor.Name = "tbTaraFurnizor";
            this.tbTaraFurnizor.Size = new System.Drawing.Size(100, 22);
            this.tbTaraFurnizor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tara furnizor:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salveaza furnizor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTaraFurnizor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLocalitateFurnizor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNumeFurnizor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumeFurnizor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLocalitateFurnizor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTaraFurnizor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

