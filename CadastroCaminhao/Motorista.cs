using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroCaminhao
{
    public class Motorista
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Id { get; set; }
        public Motorista(string nome, string endereco, int id)
        {
            Nome = nome;
            Endereco = endereco;
            Id = id;
        }
    }
}
