﻿namespace CSharp_SQL_App {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonPrikazOpstina = new System.Windows.Forms.Button();
            this.buttonPrikazUgovora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPrikazOpstina
            // 
            this.buttonPrikazOpstina.Location = new System.Drawing.Point(96, 62);
            this.buttonPrikazOpstina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrikazOpstina.Name = "buttonPrikazOpstina";
            this.buttonPrikazOpstina.Size = new System.Drawing.Size(207, 77);
            this.buttonPrikazOpstina.TabIndex = 0;
            this.buttonPrikazOpstina.Text = "Prikaz Opština";
            this.buttonPrikazOpstina.UseVisualStyleBackColor = true;
            this.buttonPrikazOpstina.Click += new System.EventHandler(this.buttonPrikazOpstina_Click);
            // 
            // buttonPrikazUgovora
            // 
            this.buttonPrikazUgovora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrikazUgovora.Location = new System.Drawing.Point(497, 62);
            this.buttonPrikazUgovora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrikazUgovora.Name = "buttonPrikazUgovora";
            this.buttonPrikazUgovora.Size = new System.Drawing.Size(207, 77);
            this.buttonPrikazUgovora.TabIndex = 1;
            this.buttonPrikazUgovora.Text = "Prikaz Ugovora";
            this.buttonPrikazUgovora.UseVisualStyleBackColor = true;
            this.buttonPrikazUgovora.Click += new System.EventHandler(this.buttonPrikazUgovora_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPrikazUgovora);
            this.Controls.Add(this.buttonPrikazOpstina);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Glavni meni";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPrikazOpstina;
        private System.Windows.Forms.Button buttonPrikazUgovora;
    }
}