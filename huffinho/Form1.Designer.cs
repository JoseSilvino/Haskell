using System.Windows.Forms;
using System.Collections.Generic;
namespace huffinho
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
            this.Compress = new System.Windows.Forms.Button();
            this.Decompress = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Compress
            // 
            this.Compress.Location = new System.Drawing.Point(100, 100);
            this.Compress.Name = "Compress";
            this.Compress.Size = new System.Drawing.Size(80, 25);
            this.Compress.TabIndex = 0;
            this.Compress.Text = "Comprimir";
            this.Compress.Click += new System.EventHandler(this.Compress_Click);
            // 
            // Decompress
            // 
            this.Decompress.Location = new System.Drawing.Point(200, 100);
            this.Decompress.Name = "Decompress";
            this.Decompress.Size = new System.Drawing.Size(80, 25);
            this.Decompress.TabIndex = 1;
            this.Decompress.Text = "Descomprimir";
            this.Decompress.Click += new System.EventHandler(this.Decompress_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(300, 300);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(80, 25);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Sair";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.Compress);
            this.Controls.Add(this.Decompress);
            this.Controls.Add(this.Exit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }
        Button Compress;
        Button Decompress;
        Button Exit;
        #endregion
    }
}

