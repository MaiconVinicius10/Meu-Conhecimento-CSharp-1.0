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
    public partial class F_FilhoCheckBox :Form
    {   //criando uma variavel global
        F_CheckBox fp;

        public F_FilhoCheckBox()
        {
            InitializeComponent();
            //abrindo coleção openforms F_checkBox
            fp=Application.OpenForms["F_CheckBox"] as F_CheckBox;
            //recebendo os dados da classe F_CheckBox
            cb_Avião.Checked = fp.cb_Avião.Checked;
            cb_Carro.Checked = fp.cb_Carro.Checked;
            cb_Navio.Checked = fp.cb_Navio.Checked;
            cb_Onibus.Checked = fp.cb_Onibus.Checked;
        }
        //evento fechar
        private void F_FilhoCheckBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.cb_Carro.Checked = cb_Carro.Checked;
            fp.cb_Avião.Checked = cb_Avião.Checked;
            fp.cb_Navio.Checked = cb_Navio.Checked;
            fp.cb_Onibus.Checked = cb_Onibus.Checked;
        }
    }
}
