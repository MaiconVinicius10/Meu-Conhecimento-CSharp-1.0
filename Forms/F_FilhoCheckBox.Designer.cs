﻿
namespace Meu_Conhecimento_CSharp_1._0.Forms
{
    partial class F_FilhoCheckBox
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
            this.cb_Onibus = new System.Windows.Forms.CheckBox();
            this.cb_Navio = new System.Windows.Forms.CheckBox();
            this.cb_Carro = new System.Windows.Forms.CheckBox();
            this.cb_Avião = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cb_Onibus
            // 
            this.cb_Onibus.AutoSize = true;
            this.cb_Onibus.Location = new System.Drawing.Point(12, 93);
            this.cb_Onibus.Name = "cb_Onibus";
            this.cb_Onibus.Size = new System.Drawing.Size(75, 21);
            this.cb_Onibus.TabIndex = 6;
            this.cb_Onibus.Text = "Ônibus";
            this.cb_Onibus.UseVisualStyleBackColor = true;
            // 
            // cb_Navio
            // 
            this.cb_Navio.AutoSize = true;
            this.cb_Navio.Location = new System.Drawing.Point(12, 66);
            this.cb_Navio.Name = "cb_Navio";
            this.cb_Navio.Size = new System.Drawing.Size(66, 21);
            this.cb_Navio.TabIndex = 5;
            this.cb_Navio.Text = "Navio";
            this.cb_Navio.UseVisualStyleBackColor = true;
            // 
            // cb_Carro
            // 
            this.cb_Carro.AutoSize = true;
            this.cb_Carro.Location = new System.Drawing.Point(12, 12);
            this.cb_Carro.Name = "cb_Carro";
            this.cb_Carro.Size = new System.Drawing.Size(65, 21);
            this.cb_Carro.TabIndex = 3;
            this.cb_Carro.Text = "Carro";
            this.cb_Carro.UseVisualStyleBackColor = true;
            // 
            // cb_Avião
            // 
            this.cb_Avião.AutoSize = true;
            this.cb_Avião.Location = new System.Drawing.Point(12, 39);
            this.cb_Avião.Name = "cb_Avião";
            this.cb_Avião.Size = new System.Drawing.Size(65, 21);
            this.cb_Avião.TabIndex = 4;
            this.cb_Avião.Text = "Avião";
            this.cb_Avião.UseVisualStyleBackColor = true;
            // 
            // F_FilhoCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 536);
            this.Controls.Add(this.cb_Onibus);
            this.Controls.Add(this.cb_Navio);
            this.Controls.Add(this.cb_Carro);
            this.Controls.Add(this.cb_Avião);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_FilhoCheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_FilhoCheckBox";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_FilhoCheckBox_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_Onibus;
        private System.Windows.Forms.CheckBox cb_Navio;
        private System.Windows.Forms.CheckBox cb_Carro;
        private System.Windows.Forms.CheckBox cb_Avião;
    }
}