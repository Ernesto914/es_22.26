﻿namespace es_22._26
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_CONVERTI = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_RESET = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btn_CONVERTI
            // 
            this.btn_CONVERTI.Location = new System.Drawing.Point(118, 12);
            this.btn_CONVERTI.Name = "btn_CONVERTI";
            this.btn_CONVERTI.Size = new System.Drawing.Size(75, 20);
            this.btn_CONVERTI.TabIndex = 1;
            this.btn_CONVERTI.Text = "Converti";
            this.btn_CONVERTI.UseVisualStyleBackColor = true;
            this.btn_CONVERTI.Click += new System.EventHandler(this.btn_CONVERTI_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(100, 95);
            this.listBox1.TabIndex = 2;
            // 
            // btn_RESET
            // 
            this.btn_RESET.Location = new System.Drawing.Point(118, 38);
            this.btn_RESET.Name = "btn_RESET";
            this.btn_RESET.Size = new System.Drawing.Size(75, 20);
            this.btn_RESET.TabIndex = 3;
            this.btn_RESET.Text = "Reset";
            this.btn_RESET.UseVisualStyleBackColor = true;
            this.btn_RESET.Click += new System.EventHandler(this.btn_RESET_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_CONVERTI;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 144);
            this.Controls.Add(this.btn_RESET);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_CONVERTI);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_CONVERTI;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_RESET;
    }
}

