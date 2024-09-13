using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SysPecNSLib
{
    public class Estoque
    {
        public int Id { get; set; }
        public double Quantidade { get; set; }
        public DateTime DataMovimento { get; set; }


        public Estoque()
        {

        }

        public Estoque(double quantidade, DateTime dataMovimento)
        {

            Quantidade = quantidade;
            DataMovimento = dataMovimento;
        }

        public Estoque(int id ,double quantidade)
        {
            Id = id;
            Quantidade = quantidade;
        }

        public Estoque(int id,double quantidade, DateTime dataMovimento)
        {
            Id = id;
            Quantidade = quantidade;
            DataMovimento = dataMovimento;

        }



        public void Inserir() // inserir o Endereço no banco
        {

            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert estoques (id, quantidade, dataMovimento) values ('{Id} ','{Quantidade}','{DataMovimento})";
            cmd.ExecuteNonQuery();
        }

        public static Estoque ObterPorId(int id)
        {
            Estoque estoque = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select *from produto where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                estoque = new(
                dr.GetInt32(0),
                dr.GetDouble(1),
                dr.GetDateTime(2)
                    );
            }
            return estoque;
        }

        public static List<Estoque> ObterLista()
        {
            List<Estoque> lista = new List<Estoque>();
            // consulta para retornar a lista do Estoque
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from estoques";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(
                    new(
                        dr.GetInt32(0),
                        dr.GetDouble(1),
                        dr.GetDateTime(2)
                        )
                    );
            }
            return lista;
        }

        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update estoques " +
            $"set quantidade = '{Quantidade}',data_ultimo_movimento = '{DataMovimento}' where produto.id = {Id}";
            return cmd.ExecuteNonQuery() > 0 ? true : false;

        }
    }
}
