﻿using Meu_Conhecimento_CSharp_1._0.Forms;
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
    {   //criando variavel contagem de tela
        int contagem = 0;
        public F_Menu()
        {
            InitializeComponent();
        }
        //Botão Adicionar
        private void btn_Adicionar_Click(object sender, EventArgs e)
        {   //recebendo o valor digitado
            txt_ListaVeiculos.Text += txt_AdicionarVeiculo.Text+", ";
            txt_AdicionarVeiculo.Clear();
            txt_AdicionarVeiculo.Focus();
        }
        //Botão Limpar
        private void btb_Limpar_Click(object sender, EventArgs e)
        {   //apagando 
            txt_AdicionarVeiculo.Clear();
            txt_ListaVeiculos.Clear();
            //setando meu ponteio no adicionar
            txt_AdicionarVeiculo.Focus();
        }
        // Botão Mostrar Lista Veiculos
        private void btn_MostrarListaVeiculos_Click(object sender, EventArgs e)
        {
            contagem++;
            F_ListaVeiculos f_ListaVeiculos = new F_ListaVeiculos(txt_ListaVeiculos.Text,this);
            f_ListaVeiculos.ShowDialog();
        }
        // botão Contagem de Tela
        private void btn_ContagemTela_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esse contador mostra , quantas vezes você abriu a lista de veiculos.: "+contagem,
                "Atenção",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        //Menu CheckBox
        private void checkBoxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_CheckBox f_CheckBox = new F_CheckBox();
            f_CheckBox.ShowDialog();
        }
        //Menu CheckListBox
        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();
            f_CheckedListBox.ShowDialog();
        }
        // Menu ComboBox
        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ComboBox f_ComboBox = new F_ComboBox();
            f_ComboBox.ShowDialog();
        }
        //Menu DateTimePicker
        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DateTimePicker f_DateTimePicker = new F_DateTimePicker();
            f_DateTimePicker.ShowDialog();
        }
        //Menu LinkLabel
        private void linkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_LinkLabel f_LinkLabel = new F_LinkLabel();
            f_LinkLabel.ShowDialog();
        }
        //Menu ListBox
        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListBox f_ListBox = new F_ListBox();
            f_ListBox.ShowDialog();
        }
        //Menu ListView
        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListView f_ListView = new F_ListView();
            f_ListView.ShowDialog();
        }
    }
}
