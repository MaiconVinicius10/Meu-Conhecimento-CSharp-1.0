using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meu_Conhecimento_CSharp_1._0.Forms
{
    public partial class F_ComboBox :Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }
        //Botão Mostrar Selecionados
        private void btn_MostrarSelecionados_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_Transporte.Text);
        }

        //Botão Limpar Elementos
        private void btn_LimparElementos_Click(object sender, EventArgs e)
        {
            cb_Transporte.Items.Clear();
            txt_Transporte.Clear();
            txt_Transporte.Focus();
        }
        //botão Resetar
        private void btn_ResetarLista_Click(object sender, EventArgs e)
        {
            cb_Transporte.Items.Clear();
            cb_Transporte.Items.Add("Avião");
            cb_Transporte.Items.Add("Carro");
            cb_Transporte.Items.Add("Navio");
            cb_Transporte.Items.Add("Ônibus");
            cb_Transporte.Items.Add("Trem");
        }
        // BOtão Adicionar
        private void btn_AdicionarTransporte_Click(object sender, EventArgs e)
        {
            // if Se for diferente que vazio
            if (txt_Transporte.Text != "")
            {
                if (cb_Transporte.FindString(txt_Transporte.Text) < 0)
                {
                    cb_Transporte.Items.Add(txt_Transporte.Text);
                    MessageBox.Show("Transporte Cadastrado com Sucesso" +
                       "", "ComboBox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Transporte.Clear();
                    txt_Transporte.Focus();
                }
                else
                {
                    MessageBox.Show("Olha você está escrevendo ja um transporte ja existente" +
                        "", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Transporte.Clear();
                    txt_Transporte.Focus();
                }

            }
            else
            {
                MessageBox.Show("Cara digita algo ai......", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Transporte.Clear();
                txt_Transporte.Focus();
            }
        }
        // botão que envia dado pra txttransporte
        private void cb_Transporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Transporte.Text = cb_Transporte.Text;
        }
    }
}
