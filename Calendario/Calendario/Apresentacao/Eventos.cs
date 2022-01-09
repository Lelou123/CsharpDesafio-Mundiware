using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Calendario.Apresentacao
{
    public partial class Eventos : Form
    {

        public Eventos()
        {
            InitializeComponent();
        }



        private void Eventos_Load(object sender, EventArgs e)
        {
            txbData.Text = UserControlDias.static_dia + "/" + Form1.static_Mes + "/" + Form1.static_Ano;
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string a = txbData.Text;
            string b = txbEvento.Text;

            Controle controle = new Controle(a, b);
            MessageBox.Show(controle.Mensagem);

        }
    }
}
