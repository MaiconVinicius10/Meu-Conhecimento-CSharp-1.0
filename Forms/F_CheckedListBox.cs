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
    public partial class F_CheckedListBox :Form
    {   // Criando lista veiculos
        List<String> transp = new List<String>();
        public F_CheckedListBox()
        {
            InitializeComponent();
            transp.Add("Carro");
            transp.Add("Avião");
            transp.Add("Navio");
            transp.Add("Ônibus");
            transp.Add("Trem");
        }
        // botão Mostrar Selecionados
        private void btn_MostrarSelecionados_Click(object sender, EventArgs e)
        {
            String txt = "";
            
            foreach(String t in cb_Transportes.CheckedItems)
            {
                txt += t+", ";
            }

            MessageBox.Show(txt.ToString());
        }
        // botão Limpar Lista
        private void btn_LimparLista_Click(object sender, EventArgs e)
        {
            cb_Transportes.Items.Clear();
            txt_NovoTransporte.Clear();
            txt_NovoTransporte.Focus();
        }
        // botão Resetar Lista
        private void btn_ResetarLista_Click(object sender, EventArgs e)
        {
            cb_Transportes.Items.Clear();
            cb_Transportes.Items.AddRange(transp.ToArray());
            txt_NovoTransporte.Focus();
        }
        //Botão Adicionar Novo Transporte
        private void btn_AdicionarNovoTransporte_Click(object sender, EventArgs e)
        {
            cb_Transportes.Items.Add(txt_NovoTransporte.Text);
            txt_NovoTransporte.Clear();
            txt_NovoTransporte.Focus();
        }
    }
}
