using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calendario
{
    public partial class Form1 : Form
    {
        public int Mes { get; set; }
        public int Ano { get; set; }
        
        public static int static_Mes, static_Ano;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayDias();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void DisplayDias()
        {

            DateTime atual = DateTime.Now;
            Mes = atual.Month;
            Ano = atual.Year;

            string nomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(Mes);
            lbMesAno.Text = nomeMes + " " + Ano;
            
            static_Mes = Mes;
            static_Ano = Ano;

            DateTime comecoMes = new DateTime(Ano, Mes, 1);
            int dias = DateTime.DaysInMonth(Ano, Mes);
            int diaSemana = Convert.ToInt32(comecoMes.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < diaSemana; i++)
            {
                UserControlVazio uc = new UserControlVazio();
                diaContainer.Controls.Add(uc);
            }

            for (int i = 1; i <= dias; i++)
            {
                UserControlDias ucdias = new UserControlDias();
                ucdias.dias(i);
                diaContainer.Controls.Add(ucdias);
            }
        }

        private void btnProximo_Click_1(object sender, EventArgs e)
        {
            diaContainer.Controls.Clear();
            if (Mes != 12)
            {
                Mes++;
            }
            else
            {
                Mes = 1;
                Ano++;
            }

            string nomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(Mes);
            lbMesAno.Text = nomeMes + " " + Ano;

            static_Mes = Mes;
            static_Ano = Ano;

            DateTime comecoMes = new DateTime(Ano, Mes, 1);
            int dias = DateTime.DaysInMonth(Ano, Mes);
            int diaSemana = Convert.ToInt32(comecoMes.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < diaSemana; i++)
            {
                UserControlVazio uc = new UserControlVazio();
                diaContainer.Controls.Add(uc);
            }

            for (int i = 1; i <= dias; i++)
            {
                UserControlDias ucdias = new UserControlDias();
                ucdias.dias(i);
                diaContainer.Controls.Add(ucdias);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            diaContainer.Controls.Clear();

            Mes--;

            if(Mes > 13 || Mes < 1)
            {
                Ano--;
                Mes = 12;
            }


            string nomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(Mes);
            lbMesAno.Text = nomeMes + " " + Ano;

            static_Mes = Mes;
            static_Ano = Ano;

            DateTime comecoMes = new DateTime(Ano, Mes, 1);
            int dias = DateTime.DaysInMonth(Ano, Mes);
            int diaSemana = Convert.ToInt32(comecoMes.DayOfWeek.ToString("d")) + 1;


            for (int i = 1; i < diaSemana; i++)
            {
                UserControlVazio uc = new UserControlVazio();
                diaContainer.Controls.Add(uc);
            }

            for (int i = 1; i <= dias; i++)
            {
                UserControlDias ucdias = new UserControlDias();
                ucdias.dias(i);
                diaContainer.Controls.Add(ucdias);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
