using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SysPecNSLib
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Cpf { get; set; }
        public string? Telefone { get; set; }
        public DateTime? Data_nasc {  get; set; }
        public DateTime? Data_cad { get; set; }
        public bool Ativo { get; set; }

        public Cliente() 
        {
        }

        public Cliente(string? nome, string? email, string? telefone, string? cpf, DateTime? data_nasc, DateTime? data_cad)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Cpf = cpf;
            Data_nasc = data_nasc;
            Data_cad = data_cad;
            
        }

        public Cliente(string? nome, string? email, string? cpf, string? telefone, DateTime? data_nasc, DateTime? data_cad, bool ativo) 
        {
            Nome = nome;
            Email = email;
            Cpf = cpf;
            Telefone = telefone;
            Data_nasc = data_nasc;
            Data_cad = data_cad;
            Ativo = ativo;

        }

        public Cliente(int id, string? nome, string? email, string? cpf, string? telefone, DateTime? data_nasc, DateTime? data_cad, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Cpf = cpf;
            Telefone = telefone;
            Data_nasc = data_nasc;
            Data_cad = data_cad;
            Ativo = ativo;
        }

        public void Inserir() //Inserir o cliente no banco
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spdatanasc", Data_nasc);
            cmd.Parameters.AddWithValue("spdatacad", Data_cad);
            cmd.Parameters.AddWithValue("spativo", Ativo);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }

        }

        public static Cliente ObterporId(int id) // puxar o cliente por id no banco
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select *from clientes where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cliente = new(
                    dr.GetInt32(0), // id
                    dr.GetString(1), // nome
                    dr.GetString(2), // email
                    dr.GetString(3), // cpf
                    dr.GetString(4), // telefone
                    dr.GetDateTime(5), // data de nasc
                    dr.GetDateTime(6), // data cad
                    dr.GetBoolean(7) // ativo
                    );
            }
            return cliente;
        }

        public static List<Cliente> ObterLista(string? nome = "") // obter a lista de clientes - nomes
        {
            List<Cliente> lista = new();
            var comandosSQL = Banco.Abrir();
            comandosSQL.CommandType = CommandType.Text;
            if (nome =="")
            {
                comandosSQL.CommandText = "select * from clientes order by nome";
            }
            else
            {
                comandosSQL.CommandText = $"select * from clientes where nome like '%{nome}%' order by nome";
            }

            var dr = comandosSQL.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(
                    new(
                    dr.GetInt32(0), // id
                    dr.GetString(1), // nome
                    dr.GetString(2), // email
                    dr.GetString(3), // cpf
                    dr.GetString(4), // telefone
                    dr.GetDateTime(5), // data nascimento
                    dr.GetDateTime(6), // data de cad
                    dr.GetBoolean(7) // ativo
                    )
                    );
            }
            return lista;
        }
        public void Atualizar() 
        {
            // usuario: nome, senha, nível...
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_altera";
            //cmd.Parameters.Add("spid", MySqlDbType.Int32).Value = Id;
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static void Arquivar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update clientes set ativo = 0 where id = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static void Restaurar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update clientes set ativo = 1 where id = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

    }
}
