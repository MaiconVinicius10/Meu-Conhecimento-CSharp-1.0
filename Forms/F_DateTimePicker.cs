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
    public partial class F_DateTimePicker :Form
    {
        public F_DateTimePicker()
        {
            InitializeComponent();
        }
        //Botão Obter data
        private void btn_ObterData_Click(object sender, EventArgs e)
        {
            txt_Data.Text = dtp.Text;

            txt_Dia.Text = dtp.Value.Day.ToString();
            txt_Mes.Text = dtp.Value.Month.ToString();
            txt_Ano.Text = dtp.Value.Year.ToString();
            
        }
        //Botão Setar data
        private void btn_SetarData_Click(object sender, EventArgs e)
        {
            int d, m, a;

            d = Int32.Parse(txt_Dia.Text);
            m = Int32.Parse(txt_Mes.Text);
            a = Int32.Parse(txt_Ano.Text);

            DateTime dt = new DateTime(a, m, d);

            dtp.Value = dt;
        }
        //Botão Hoje
        private void btn_Hoje_Click(object sender, EventArgs e)
        {
            dtp.Value = DateTime.Today;
        }
    }
}
