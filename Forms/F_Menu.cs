using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meu_Conhecimento_CSharp_1._0
{
    public partial class F_Menu :Form
    {
        public F_Menu()
        {
            InitializeComponent();
        }
        //Botão Adicionar
        private void btn_Adicionar_Click(object sender, EventArgs e)
        {   //recebendo o valor digitado
            txt_ListaVeiculos.Text = txt_AdicionarVeiculo.Text;
        }
        //Botão Limpar
        private void btb_Limpar_Click(object sender, EventArgs e)
        {   //apagando 
            txt_AdicionarVeiculo.Clear();
            txt_ListaVeiculos.Clear();
            //setando meu ponteio no adicionar
            txt_AdicionarVeiculo.Focus();
        }
    }
}
