using cadastro_de_caminhoes;


namespace CadastroDeCaminhoes
{
    class Program
    {
        enum Operacao2
        {
            CadastrarCaminhao,
            CadastrarMotorista,
        }
        enum Operacao
        {
            Remover,
            Cadastrar,
            Atualizar,

        }
     
        static void Main(string[] args)
        {

            Console.WriteLine("Menu");
            Console.WriteLine("1- Cadastrar");
            Console.WriteLine("2- Atualizar");
            Console.WriteLine("0- Remover");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case (int)Operacao.Cadastrar:
                    Console.WriteLine("Menu");
                    Console.WriteLine("0 - Cadastrar Caminhão");
                    Console.WriteLine("1 - Cadastrar Motorista");
                    int opcao2 = Convert.ToInt32(Console.ReadLine());

                    break;

                    switch (opcao2)
                    {
                        case (int)Operacao2.CadastrarCaminhao:
                            Console.WriteLine("Digite Modelo, Placa e id do veiculo");
                            Caminhao caminhao1 = new Caminhao(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine("Cadastre o segundo Veiculo");
                            Console.WriteLine("Digite Modelo, Placa e id do veiculo");
                            Caminhao caminhao2 = new Caminhao(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine("Cadastre o terceiro Veiculo");
                            Console.WriteLine("Digite Modelo, Placa e id do veiculo");
                            Caminhao caminhao3 = new Caminhao(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
                            break;
                        
                    }

            }


        }


    }
}

