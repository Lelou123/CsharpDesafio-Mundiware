using Calendario.Apresentacao;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendario
{
    internal class Controle
    {
        Eventos evento = new Eventos();
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public string Mensagem { get; set; }
        public Controle (string data, string evento)
        {
            cmd.CommandText = "INSERT INTO calendario (Data, Evento) VALUES(@data,@evento);";

            cmd.Parameters.AddWithValue ("@data", data);
            cmd.Parameters.AddWithValue ("@evento", evento);

            try
            {
                cmd.Connection = conexao.Conectar(); // recebe endereço do banco de dados que quero mandar o comando a ser executado
                cmd.ExecuteNonQuery(); // Enviar valor ao banco de dados enviar para receber reader();
                conexao.Desconectar();
                Mensagem = "Enviado com sucesso";
            }
            catch (SqlException)
            {
                Mensagem = "Erro ao tentar se conectar com banco de dados";
            }
        }
    }
}
