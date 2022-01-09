using Calendario.Apresentacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendario
{
    public partial class UserControlDias : UserControl
    {
        public static string static_dia;

        public UserControlDias()
        {
            InitializeComponent();
        }

        public void dias (int numdia)
        {
            lblDia.Text = numdia+"";
        }

        private void UserControlDias_Load(object sender, EventArgs e)
        {

        }

        private void UserControlDias_Click_1(object sender, EventArgs e)
        {
            static_dia = lblDia.Text;
            Eventos evento = new Eventos();
            evento.Show();
        }
    }
}
