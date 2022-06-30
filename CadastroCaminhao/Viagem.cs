using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroCaminhao
{
    public class Viagem
    {
        Caminhao Caminhao { get; set; }
        Motorista Motorista  { get; set; }
        public int Id { get; set; }
        public Viagem(Caminhao caminhao, Motorista motorista ,int id) 
        { 
            this.Caminhao = caminhao;
            this.Motorista = motorista;
            this.Id = id;   
        }
    }
}
