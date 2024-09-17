
namespace Meu_Conhecimento_CSharp_1._0.Forms
{
    partial class F_CheckedListBox
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
            this.cb_Transportes = new System.Windows.Forms.CheckedListBox();
            this.btn_MostrarSelecionados = new System.Windows.Forms.Button();
            this.btn_LimparLista = new System.Windows.Forms.Button();
            this.btn_ResetarLista = new System.Windows.Forms.Button();
            this.txt_NovoTransporte = new System.Windows.Forms.TextBox();
            this.btn_AdicionarNovoTransporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_Transportes
            // 
            this.cb_Transportes.FormattingEnabled = true;
            this.cb_Transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.cb_Transportes.Location = new System.Drawing.Point(12, 12);
            this.cb_Transportes.Name = "cb_Transportes";
            this.cb_Transportes.Size = new System.Drawing.Size(171, 191);
            this.cb_Transportes.TabIndex = 0;
            // 
            // btn_MostrarSelecionados
            // 
            this.btn_MostrarSelecionados.Location = new System.Drawing.Point(189, 12);
            this.btn_MostrarSelecionados.Name = "btn_MostrarSelecionados";
            this.btn_MostrarSelecionados.Size = new System.Drawing.Size(155, 23);
            this.btn_MostrarSelecionados.TabIndex = 1;
            this.btn_MostrarSelecionados.Text = "Mostrar Selecionados";
            this.btn_MostrarSelecionados.UseVisualStyleBackColor = true;
            this.btn_MostrarSelecionados.Click += new System.EventHandler(this.btn_MostrarSelecionados_Click);
            // 
            // btn_LimparLista
            // 
            this.btn_LimparLista.Location = new System.Drawing.Point(189, 41);
            this.btn_LimparLista.Name = "btn_LimparLista";
            this.btn_LimparLista.Size = new System.Drawing.Size(155, 23);
            this.btn_LimparLista.TabIndex = 2;
            this.btn_LimparLista.Text = "Limpar Lista";
            this.btn_LimparLista.UseVisualStyleBackColor = true;
            this.btn_LimparLista.Click += new System.EventHandler(this.btn_LimparLista_Click);
            // 
            // btn_ResetarLista
            // 
            this.btn_ResetarLista.Location = new System.Drawing.Point(189, 70);
            this.btn_ResetarLista.Name = "btn_ResetarLista";
            this.btn_ResetarLista.Size = new System.Drawing.Size(155, 23);
            this.btn_ResetarLista.TabIndex = 3;
            this.btn_ResetarLista.Text = "Resetar Lista";
            this.btn_ResetarLista.UseVisualStyleBackColor = true;
            this.btn_ResetarLista.Click += new System.EventHandler(this.btn_ResetarLista_Click);
            // 
            // txt_NovoTransporte
            // 
            this.txt_NovoTransporte.Location = new System.Drawing.Point(189, 122);
            this.txt_NovoTransporte.Name = "txt_NovoTransporte";
            this.txt_NovoTransporte.Size = new System.Drawing.Size(155, 22);
            this.txt_NovoTransporte.TabIndex = 4;
            // 
            // btn_AdicionarNovoTransporte
            // 
            this.btn_AdicionarNovoTransporte.Location = new System.Drawing.Point(189, 150);
            this.btn_AdicionarNovoTransporte.Name = "btn_AdicionarNovoTransporte";
            this.btn_AdicionarNovoTransporte.Size = new System.Drawing.Size(155, 53);
            this.btn_AdicionarNovoTransporte.TabIndex = 5;
            this.btn_AdicionarNovoTransporte.Text = "Adicionar Novo Transporte";
            this.btn_AdicionarNovoTransporte.UseVisualStyleBackColor = true;
            this.btn_AdicionarNovoTransporte.Click += new System.EventHandler(this.btn_AdicionarNovoTransporte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite um novo transporte:";
            // 
            // F_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 536);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AdicionarNovoTransporte);
            this.Controls.Add(this.txt_NovoTransporte);
            this.Controls.Add(this.btn_ResetarLista);
            this.Controls.Add(this.btn_LimparLista);
            this.Controls.Add(this.btn_MostrarSelecionados);
            this.Controls.Add(this.cb_Transportes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_CheckedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cb_Transportes;
        private System.Windows.Forms.Button btn_MostrarSelecionados;
        private System.Windows.Forms.Button btn_LimparLista;
        private System.Windows.Forms.Button btn_ResetarLista;
        private System.Windows.Forms.TextBox txt_NovoTransporte;
        private System.Windows.Forms.Button btn_AdicionarNovoTransporte;
        private System.Windows.Forms.Label label1;
    }
}