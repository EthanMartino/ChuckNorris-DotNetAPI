﻿namespace ChuckNorrisWinForm
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
            this.jokeBtn = new System.Windows.Forms.Button();
            this.jokeLbl = new System.Windows.Forms.Label();
            this.categoriesCbx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // jokeBtn
            // 
            this.jokeBtn.Location = new System.Drawing.Point(335, 181);
            this.jokeBtn.Name = "jokeBtn";
            this.jokeBtn.Size = new System.Drawing.Size(113, 42);
            this.jokeBtn.TabIndex = 0;
            this.jokeBtn.Text = "Get Joke";
            this.jokeBtn.UseVisualStyleBackColor = true;
            this.jokeBtn.Click += new System.EventHandler(this.jokeBtn_ClickAsync);
            // 
            // jokeLbl
            // 
            this.jokeLbl.AutoSize = true;
            this.jokeLbl.Location = new System.Drawing.Point(207, 56);
            this.jokeLbl.Name = "jokeLbl";
            this.jokeLbl.Size = new System.Drawing.Size(0, 13);
            this.jokeLbl.TabIndex = 1;
            // 
            // categoriesCbx
            // 
            this.categoriesCbx.FormattingEnabled = true;
            this.categoriesCbx.Location = new System.Drawing.Point(27, 51);
            this.categoriesCbx.Name = "categoriesCbx";
            this.categoriesCbx.Size = new System.Drawing.Size(121, 21);
            this.categoriesCbx.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 286);
            this.Controls.Add(this.categoriesCbx);
            this.Controls.Add(this.jokeLbl);
            this.Controls.Add(this.jokeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jokeBtn;
        private System.Windows.Forms.Label jokeLbl;
        private System.Windows.Forms.ComboBox categoriesCbx;
    }
}

