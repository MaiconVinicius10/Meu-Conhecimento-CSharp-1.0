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
    public partial class F_LinkLabel :Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();

            lbl_Multiplos.Links.Add(0, 6, "www.google.com.br");
            lbl_Multiplos.Links.Add(9, 5, "https://www.youtube.com/@jslucasyt");
            lbl_Multiplos.Links.Add(17, 7, "https://www.youtube.com/@DevMike347/featured");
        }
        // botão Lbl_LinkLabel
        private void lbl_Canal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/@jslucasyt");
            LinkLabel ll = (LinkLabel)sender;
            ll.LinkVisited = true;
        }
        // botão lbl_Calculadora
        private void lbl_Calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
            LinkLabel ll = (LinkLabel)sender;
            ll.LinkVisited = true;
        }
        // Botão lbl_Multiplos
        private void lbl_Multiplos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            e.Link.Visited = true;
        }
    }
}
