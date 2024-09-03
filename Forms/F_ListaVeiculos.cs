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
    public partial class F_ListaVeiculos :Form
    {
        F_Menu f;
        
        //dentro do metodo - eu recebo lista veiculos
        public F_ListaVeiculos(String lista,F_Menu f_Menu)
        {
            InitializeComponent();
            //recebendo as lista
            txt_ListaVeiculos.Text = lista;
            f = f_Menu;
        }
        // Evento close = Quando fechar executar
        private void F_ListaVeiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.txt_ListaVeiculos.Text = txt_ListaVeiculos.Text;
        }
    }
}
