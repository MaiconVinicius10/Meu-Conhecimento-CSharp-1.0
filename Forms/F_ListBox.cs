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
    public partial class F_ListBox :Form
    {   //ListBox carros 
        List<string> carros = new List<string>();
        public F_ListBox()
        {
            InitializeComponent();

            carros.Add("HRV");
            carros.Add("Golf");
            carros.Add("Focuas");
            lb_carros.DataSource = carros;

        }
        // Metodo 
        private void AtualizarDados()
        {
            lb_carros.DataSource = null;
            lb_carros.DataSource = carros;
        }
        // Botão Adicionar 
        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (txt_Carro.Text == "")
            {
                MessageBox.Show("Digite um carro:");
                txt_Carro.Focus();
            }
            else
            {
                carros.Add(txt_Carro.Text);
                txt_Carro.Clear();
                AtualizarDados();
            }
        }
        //Botão Remover
        private void btn_Remover_Click(object sender, EventArgs e)
        {
            carros.RemoveAt(lb_carros.SelectedIndex);
            AtualizarDados();
        }
        //Botão Obter
        private void btn_Obter_Click(object sender, EventArgs e)
        {
            txt_Carro.Text = carros[lb_carros.SelectedIndex];
        }
        //Botão Limpar
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            carros.Clear();
            txt_Carro.Clear();
            AtualizarDados();
        }
    }
}
