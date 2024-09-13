using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Estoque
    {
        public int Id { get; set; }
        public string? Categoria { get; set; }
        public string? Quantidade  { get; set; }
        public DateOnly DataMovimento { get; set; }





        public Estoque(string? categoria, string? quantidade, DateOnly dataMovimento)
        {
           
            Categoria = categoria;
            Quantidade = quantidade;
            DataMovimento = dataMovimento;
        }

        public Estoque(string? categoria, string? quantidade)
        {
            Id = Id;
            Categoria = categoria;
            Quantidade = quantidade;   
        }

        public Estoque(int id, string? categoria, string? quantidade, DateOnly dataMovimento)
        {
            Id= Id;
            Categoria = categoria;
            Quantidade = quantidade;
            DataMovimento = dataMovimento;
        }


    }

}
