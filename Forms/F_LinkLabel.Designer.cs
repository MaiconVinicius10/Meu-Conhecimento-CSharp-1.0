
namespace Meu_Conhecimento_CSharp_1._0.Forms
{
    partial class F_LinkLabel
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
            this.text_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Canal = new System.Windows.Forms.LinkLabel();
            this.lbl_Calculadora = new System.Windows.Forms.LinkLabel();
            this.lbl_Multiplos = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // text_Nome
            // 
            this.text_Nome.Location = new System.Drawing.Point(12, 55);
            this.text_Nome.Name = "text_Nome";
            this.text_Nome.Size = new System.Drawing.Size(156, 22);
            this.text_Nome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite seu nome:";
            // 
            // lbl_Canal
            // 
            this.lbl_Canal.AutoSize = true;
            this.lbl_Canal.Location = new System.Drawing.Point(12, 135);
            this.lbl_Canal.Name = "lbl_Canal";
            this.lbl_Canal.Size = new System.Drawing.Size(55, 21);
            this.lbl_Canal.TabIndex = 2;
            this.lbl_Canal.TabStop = true;
            this.lbl_Canal.Text = "Canal";
            this.lbl_Canal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_Canal_LinkClicked);
            // 
            // lbl_Calculadora
            // 
            this.lbl_Calculadora.AutoSize = true;
            this.lbl_Calculadora.Location = new System.Drawing.Point(86, 135);
            this.lbl_Calculadora.Name = "lbl_Calculadora";
            this.lbl_Calculadora.Size = new System.Drawing.Size(104, 21);
            this.lbl_Calculadora.TabIndex = 3;
            this.lbl_Calculadora.TabStop = true;
            this.lbl_Calculadora.Text = "Calculadora";
            this.lbl_Calculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_Calculadora_LinkClicked);
            // 
            // lbl_Multiplos
            // 
            this.lbl_Multiplos.AutoSize = true;
            this.lbl_Multiplos.Location = new System.Drawing.Point(9, 248);
            this.lbl_Multiplos.Name = "lbl_Multiplos";
            this.lbl_Multiplos.Size = new System.Drawing.Size(169, 17);
            this.lbl_Multiplos.TabIndex = 4;
            this.lbl_Multiplos.TabStop = true;
            this.lbl_Multiplos.Text = "Google - Canal - Youtube";
            this.lbl_Multiplos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_Multiplos_LinkClicked);
            // 
            // F_LinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 545);
            this.Controls.Add(this.lbl_Multiplos);
            this.Controls.Add(this.lbl_Calculadora);
            this.Controls.Add(this.lbl_Canal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_Nome);
            this.Name = "F_LinkLabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_LinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lbl_Canal;
        private System.Windows.Forms.LinkLabel lbl_Calculadora;
        private System.Windows.Forms.LinkLabel lbl_Multiplos;
    }
}