using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroCaminhao
{
    public class Caminhao
    {
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public int id { get; set; }

        public Caminhao(string modelo, string placa, int id)
        {
            this.Modelo = modelo;
            this.Placa = placa;
            this.id = id;
        }
    }
}
