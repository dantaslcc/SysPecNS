using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Fornecedor
    {
        public int Id { get; set;}
        public string? Razao_social  { get; set;}
        public string? Fantasia { get; set;}
        public string? Cnpj {  get; set;}
        public string? Contato { get; set;}
        public string? Telefone { get; set;}
        public string? Email { get; set;}

        public Fornecedor()
        {
        }

        public Fornecedor(string? razao_social, string fantasia, string cnpj, string contato)
        {
            Razao_social = razao_social;
            Fantasia = fantasia;
            Cnpj = cnpj;
            Contato = contato;
        }

        public Fornecedor(string? razao_social, string fantasia, string cnpj, string contato, string telefone)
        {
            Razao_social = razao_social;
            Fantasia = fantasia;
            Cnpj = cnpj;
            Contato = contato;
            Telefone = telefone;
            
        }

        public Fornecedor(int id, string? razao_social, string fantasia, string cnpj, string contato, string email)
        {
            Id = id;
            Razao_social = razao_social;
            Fantasia = fantasia;
            Cnpj = cnpj;
            Contato = contato;
            Email = email;
        }



    }
}
