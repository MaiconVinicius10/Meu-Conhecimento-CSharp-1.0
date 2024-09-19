
namespace Meu_Conhecimento_CSharp_1._0.Forms
{
    partial class F_ComboBox
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
            this.cb_Transporte = new System.Windows.Forms.ComboBox();
            this.btn_MostrarSelecionados = new System.Windows.Forms.Button();
            this.btn_LimparElementos = new System.Windows.Forms.Button();
            this.btn_ResetarLista = new System.Windows.Forms.Button();
            this.txt_Transporte = new System.Windows.Forms.TextBox();
            this.btn_AdicionarTransporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Transporte
            // 
            this.cb_Transporte.FormattingEnabled = true;
            this.cb_Transporte.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.cb_Transporte.Location = new System.Drawing.Point(12, 12);
            this.cb_Transporte.Name = "cb_Transporte";
            this.cb_Transporte.Size = new System.Drawing.Size(163, 24);
            this.cb_Transporte.TabIndex = 0;
            this.cb_Transporte.SelectedIndexChanged += new System.EventHandler(this.cb_Transporte_SelectedIndexChanged);
            // 
            // btn_MostrarSelecionados
            // 
            this.btn_MostrarSelecionados.Location = new System.Drawing.Point(195, 13);
            this.btn_MostrarSelecionados.Name = "btn_MostrarSelecionados";
            this.btn_MostrarSelecionados.Size = new System.Drawing.Size(229, 23);
            this.btn_MostrarSelecionados.TabIndex = 1;
            this.btn_MostrarSelecionados.Text = "Mostrar Selecionado";
            this.btn_MostrarSelecionados.UseVisualStyleBackColor = true;
            this.btn_MostrarSelecionados.Click += new System.EventHandler(this.btn_MostrarSelecionados_Click);
            // 
            // btn_LimparElementos
            // 
            this.btn_LimparElementos.Location = new System.Drawing.Point(195, 42);
            this.btn_LimparElementos.Name = "btn_LimparElementos";
            this.btn_LimparElementos.Size = new System.Drawing.Size(229, 23);
            this.btn_LimparElementos.TabIndex = 2;
            this.btn_LimparElementos.Text = "Limpar Elementos";
            this.btn_LimparElementos.UseVisualStyleBackColor = true;
            this.btn_LimparElementos.Click += new System.EventHandler(this.btn_LimparElementos_Click);
            // 
            // btn_ResetarLista
            // 
            this.btn_ResetarLista.Location = new System.Drawing.Point(195, 71);
            this.btn_ResetarLista.Name = "btn_ResetarLista";
            this.btn_ResetarLista.Size = new System.Drawing.Size(229, 23);
            this.btn_ResetarLista.TabIndex = 3;
            this.btn_ResetarLista.Text = "Resetar Transporte";
            this.btn_ResetarLista.UseVisualStyleBackColor = true;
            this.btn_ResetarLista.Click += new System.EventHandler(this.btn_ResetarLista_Click);
            // 
            // txt_Transporte
            // 
            this.txt_Transporte.Location = new System.Drawing.Point(195, 116);
            this.txt_Transporte.Name = "txt_Transporte";
            this.txt_Transporte.Size = new System.Drawing.Size(229, 22);
            this.txt_Transporte.TabIndex = 4;
            // 
            // btn_AdicionarTransporte
            // 
            this.btn_AdicionarTransporte.Location = new System.Drawing.Point(195, 144);
            this.btn_AdicionarTransporte.Name = "btn_AdicionarTransporte";
            this.btn_AdicionarTransporte.Size = new System.Drawing.Size(229, 23);
            this.btn_AdicionarTransporte.TabIndex = 5;
            this.btn_AdicionarTransporte.Text = "AdicionarTransporte";
            this.btn_AdicionarTransporte.UseVisualStyleBackColor = true;
            this.btn_AdicionarTransporte.Click += new System.EventHandler(this.btn_AdicionarTransporte_Click);
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 536);
            this.Controls.Add(this.btn_AdicionarTransporte);
            this.Controls.Add(this.txt_Transporte);
            this.Controls.Add(this.btn_ResetarLista);
            this.Controls.Add(this.btn_LimparElementos);
            this.Controls.Add(this.btn_MostrarSelecionados);
            this.Controls.Add(this.cb_Transporte);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_ComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Transporte;
        private System.Windows.Forms.Button btn_MostrarSelecionados;
        private System.Windows.Forms.Button btn_LimparElementos;
        private System.Windows.Forms.Button btn_ResetarLista;
        private System.Windows.Forms.TextBox txt_Transporte;
        private System.Windows.Forms.Button btn_AdicionarTransporte;
    }
}