using System;
using System.Collections.Generic;
using System.Linq;

namespace CadastroCaminhao
{
    internal class Program
    {
        
        enum Operacao
        {
            Sair,
            Cadastrar,
            Atualizar,
            Remover,


        }
        enum Operacao2
        {
            CadastrarCaminhao,
            CadastrarMotorista,
            CadastrarViagem,
        }
        enum Operacao3
        {
            AtualizarCaminhao,
            AtualizarMotorista,

        }

        private static List<Caminhao> LstCaminhao { get; set; } = new List<Caminhao>();
        private static List<Motorista> LstMotorista { get; set; } = new List<Motorista>();
        private static List<Viagem> LstViagem { get; set; } = new List<Viagem>();

        private void MostrarCaminhoesDisponiveis()
        {
            foreach (Caminhao caminhao in LstCaminhao)
            {
                Console.WriteLine(caminhao.ToString());
            }
        }

        private Caminhao SelectCaminhao()
        {
            int id = 0;
            Caminhao veiculo = null;
            var caminhaoQuery =
              from Caminhao caminhao in LstCaminhao
              where caminhao.Id == id
              select caminhao;
            MostrarCaminhoesDisponiveis();
            while (veiculo == null)
            {
                Console.WriteLine("Digite o ID do veículo: ");
                id = Convert.ToInt32(Console.ReadLine());
                foreach (var caminhao in caminhaoQuery)
                {
                    veiculo = caminhao;
                }
            }
            return veiculo;
        }

        private static Caminhao ObterCaminhaoPorId(int idPEsquisar)
        {
            return LstCaminhao.FirstOrDefault(c => c.Id == idPEsquisar);
        }
        private static Motorista ObterMotoristaPorId(int idProcurar) 
        {
            return LstMotorista.FirstOrDefault(m => m.Id == idProcurar);
        }

        private static void CriarCaminhao(Caminhao caminhao)
        {
            LstCaminhao.Add(caminhao);
        }
        private static void CriarMotorista(Motorista motorista)
        {
            LstMotorista.Add(motorista);
        }

        public static void AlterarMotorista(int idProcurar, string novoNome, string novoEndereco) 
        {
            //Pesquisar o Motorista pelo Id
            var resultado = ObterMotoristaPorId(idProcurar);

            //Alterar as propriedades
            if (resultado != null)
            {
                resultado.Nome = novoNome;
                resultado.Endereco = novoEndereco;
            }
        }
        public static void AlterarCaminhao(int idProcurar, string novoModelo, string novaPlaca)
        {
            // Pesquisar o caminhao pelo Id.
            var resultado = ObterCaminhaoPorId(idProcurar);

            // Alterar as propriedades
            if (resultado != null)
            {
                resultado.Modelo = novoModelo;
                resultado.Placa = novaPlaca;
            }
        }

        private static void ExcluirCaminhao(int idExcluir)
        {
            Caminhao caminhaoExcluir = ObterCaminhaoPorId(idExcluir);
            if (caminhaoExcluir != null)
                LstCaminhao.Remove(caminhaoExcluir);
        }

        public static int ObterIdParaCaminhao(int Id)
        {
            return LstCaminhao.Count + 1;
        }
        public static int ObterIdParaMotorista(int IdMotorista)
        {
            return LstMotorista.Count + 1;
        }
        public static int ObterIdParaViagem(int IdViagem) 
        { 
            return LstViagem.Count + 1;
        }

        // private static Caminhao ObterCaminhaoPelaPlaca(string placaPesquisar)
        //{
          //  return LstCaminhao.FirstOrDefault(c => c.Placa.ToUpper() == placaPesquisar.ToUpper());
        //}

        

        public static void Main(string[] args)
        {

            Console.WriteLine("Menu");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1- Cadastrar");
            Console.WriteLine("2- Atualizar");
            Console.WriteLine("3- Remover");
            int opcao = Convert.ToInt32(Console.ReadLine());

            while (opcao != (int)Operacao.Sair)
            {

                if (opcao == (int)Operacao.Cadastrar)
                {

                    Console.WriteLine("Menu");
                    Console.WriteLine("0 - Cadastrar Caminhão");
                    Console.WriteLine("1 - Cadastrar Motorista");
                    Console.WriteLine("2 - Cadastrar Viagem");
                    int opcao2 = Convert.ToInt32(Console.ReadLine());

                    switch (opcao2)
                    {
                        case (int)Operacao2.CadastrarCaminhao:
                            Console.WriteLine("Digite o Modelo do caminhão");
                            string Modelo = Console.ReadLine();
                            Console.WriteLine("Digite a placa do Veiculo");
                            string PlacaVeiculo = Console.ReadLine();
                            int Id = 0;
                            ObterIdParaCaminhao(Id);
                            Caminhao caminhao1 = new Caminhao(Modelo, PlacaVeiculo, Id);
                            CriarCaminhao(caminhao1);
                            LstCaminhao.Add(caminhao1);
                            Console.WriteLine("Seu caminão foi cadastrado com sucesso");

                            break;
                        case (int)Operacao2.CadastrarMotorista:
                            Console.WriteLine("Digite o Nome Completo do Motorista");
                            string Nome = Console.ReadLine();
                            Console.WriteLine("Digite o Endereço do motorista");
                            string Endereco = Console.ReadLine();
                            int IdMotorista = 0;
                            ObterIdParaMotorista(IdMotorista);
                            Motorista motorista1 = new Motorista(Nome, Endereco, IdMotorista);
                            CriarMotorista(motorista1);
                            LstMotorista.Add(motorista1);
                            Console.WriteLine("Seu Motorista foi cadastrado com sucesso");

                            break;

                        case (int)Operacao2.CadastrarViagem:
                            Console.WriteLine("Digite o Id do veiculo que fará a viagem");
                            int i = Convert.ToInt32(Console.ReadLine());
                            ObterCaminhaoPorId(i);
                            int Idviagem = 0;
                            ObterIdParaViagem(Idviagem);
                            Console.WriteLine("Digite o Id do motorista que fará a viagem");
                            int IdCondutor = Convert.ToInt32(Console.ReadLine());
                            ObterMotoristaPorId(IdCondutor);
                            
                            

                            break;


                    }
                    
                        



                        // ObterPelaPlaca
                        //var res = ObterCaminhaoPelaPlaca("abc1234");

                        // Alterar um Caminhão.
                        //Caminhao caminhaoAlterar = ObterCaminhaoPorId(1);
                        //if (caminhaoAlterar != null)
                        //AlterarCaminhao(1, "Scania ALterada", "XXX-1234");


                        // Excluir um Caminhao
                        //int idExcluir = int.Parse(Console.ReadLine());
                        //ExcluirCaminhao(idExcluir);
                        //ExcluirCaminhao(1);

                }
                if (opcao == (int)Operacao.Atualizar)
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("0 - Atualizar Caminhão");
                    Console.WriteLine("1 - Atualizar Motorista");
                    int opcao3 = Convert.ToInt32(Console.ReadLine());

                    switch (opcao3)
                    {
                        case (int)Operacao3.AtualizarCaminhao:
                            Console.WriteLine("Digite o Id do veiculo a ser atualizado");
                            int i = Convert.ToInt32(Console.ReadLine());
                            ObterCaminhaoPorId(i);
                            Console.WriteLine("Digite o novo modelo do veiculo");
                            string modelo = Console.ReadLine();
                            Console.WriteLine("Digite a nova placa do veiculo");
                            string placa = Console.ReadLine();
                            AlterarCaminhao(i,modelo,placa);
                            Console.WriteLine("Seu caminhão foi atualizado com sucesso");
                     break;

                        case (int)Operacao3.AtualizarMotorista:
                            Console.WriteLine("Digite o Id do motorista a ser atualizado");
                            int idMotorista = Convert.ToInt32(Console.ReadLine());
                            ObterMotoristaPorId(idMotorista);
                            Console.WriteLine("Digite o nome do novo motorista");
                            string nome = Console.ReadLine();
                            Console.WriteLine("Digite o endereço do novo motorista");
                            string endereco = Console.ReadLine();
                            AlterarMotorista(idMotorista,nome,endereco);
                            Console.WriteLine("Seu motorista foi atualizado com sucesso");

                            break;
                    }
                }
                
                Console.WriteLine("Menu");
                Console.WriteLine("1- Cadastrar");
                Console.WriteLine("2- Atualizar");
                Console.WriteLine("0- Remover");
                opcao = Convert.ToInt32(Console.ReadLine());
            }



        }
    }
}

