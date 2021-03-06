﻿namespace WiremockUI
{
    partial class FormImageFile
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
            this.txtPath = new WiremockUI.SimpleEditor();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.imgFile = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFile)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.SystemColors.Control;
            this.txtPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPath.EnableFormatters = false;
            this.txtPath.EnableHistory = false;
            this.txtPath.EnableOptions = false;
            this.txtPath.EnableSearch = false;
            this.txtPath.Location = new System.Drawing.Point(0, 0);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(284, 20);
            this.txtPath.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnOpen);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 34);
            this.panel3.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(189, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 6);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(171, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Abrir em um visualizador externo";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // imgFile
            // 
            this.imgFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgFile.Location = new System.Drawing.Point(0, 20);
            this.imgFile.Name = "imgFile";
            this.imgFile.Size = new System.Drawing.Size(284, 207);
            this.imgFile.TabIndex = 5;
            this.imgFile.TabStop = false;
            // 
            // FormImageFile
            // 
            this.AcceptButton = this.btnOpen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.imgFile);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormImageFile";
            this.Text = "...";
            this.Load += new System.EventHandler(this.FormImageFile_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SimpleEditor txtPath;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox imgFile;
        private System.Windows.Forms.Button btnClose;
    }
}