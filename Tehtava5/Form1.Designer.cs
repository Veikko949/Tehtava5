namespace Tehtava5
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AnnaLuku_label = new System.Windows.Forms.Label();
            this.Vastaus_label = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Numero_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AnnaLuku_label
            // 
            this.AnnaLuku_label.AutoSize = true;
            this.AnnaLuku_label.Location = new System.Drawing.Point(15, 13);
            this.AnnaLuku_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AnnaLuku_label.Name = "AnnaLuku_label";
            this.AnnaLuku_label.Size = new System.Drawing.Size(254, 25);
            this.AnnaLuku_label.TabIndex = 1;
            this.AnnaLuku_label.Text = "Anna Luku (-999 lopetus)";
            // 
            // Vastaus_label
            // 
            this.Vastaus_label.AutoSize = true;
            this.Vastaus_label.Location = new System.Drawing.Point(15, 47);
            this.Vastaus_label.Name = "Vastaus_label";
            this.Vastaus_label.Size = new System.Drawing.Size(70, 25);
            this.Vastaus_label.TabIndex = 2;
            this.Vastaus_label.Text = "label2";
            this.Vastaus_label.Visible = false;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Numero_textBox
            // 
            this.Numero_textBox.Location = new System.Drawing.Point(292, 10);
            this.Numero_textBox.Name = "Numero_textBox";
            this.Numero_textBox.Size = new System.Drawing.Size(232, 31);
            this.Numero_textBox.TabIndex = 4;
            this.Numero_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero_textBox_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 87);
            this.Controls.Add(this.Numero_textBox);
            this.Controls.Add(this.Vastaus_label);
            this.Controls.Add(this.AnnaLuku_label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Lukujen ärjestys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label AnnaLuku_label;
        private System.Windows.Forms.Label Vastaus_label;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox Numero_textBox;
    }
}

