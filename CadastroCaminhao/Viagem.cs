using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroCaminhao
{
    public class Viagem
    {
        public Caminhao Caminhao { get; set; }
        public Motorista Motorista { get; set; }
        public int Id { get; set; }
        public Viagem() { }
        public Viagem(Caminhao caminhao, Motorista motorista ) 
        { 
            this.Caminhao = caminhao;
            this.Motorista = motorista;
             
        }
    }
}
