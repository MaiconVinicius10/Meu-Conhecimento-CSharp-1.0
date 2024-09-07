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
    public partial class F_CheckBox :Form
    {   //crinado minha lista checkBox
        List<CheckBox> listatransportes = new List<CheckBox>();
        public F_CheckBox()
        {
            InitializeComponent();
            //adicionando os checkbox a lista
            listatransportes.Add(cb_Carro);
            listatransportes.Add(cb_Avião);
            listatransportes.Add(cb_Navio);
            listatransportes.Add(cb_Onibus);
        }
        // Botão Mostrar Selecionados
        private void btn_MostrarSelecionados_Click(object sender, EventArgs e)
        {   //criando variavel
            String txt = "";
            String txt2 = "";
            int num = 0;

            foreach (CheckBox t in listatransportes)
            {
                if (t.Checked)
                {   
                    num++;
                    txt = t.Text;
                }
            }
            if (num == 0)
            {               
                MessageBox.Show("Você não selecionou nenhum transporte", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (num == 1)
            {
                MessageBox.Show("Você selecionou o tranporte:" + txt, "Mike Tranportes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                
            }else if (num > 1)
            {
                foreach (CheckBox t2 in listatransportes)
                {
                    if (t2.Checked)
                    {
                        num++;
                        txt2 += t2.Text+", ";
                    }
                }
                MessageBox.Show("Transportes selecionados: " + txt2,"Atenção");
            }
        }
        //cb_DevMike
        private void cb_DevMike_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Com muito esforço vamos conseguir é questão de trabalhar bastante todos os dias.....");
        }
    }
}
