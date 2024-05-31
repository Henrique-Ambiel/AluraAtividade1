        // Screen Sound (nome do aplicativo de música)
        string mensagemBoasVindas = "Boas vindas ao Screen Sound!";
        List<string> listaBandas = new List<string>(); //Cria uma lista para armazenar informações e que precisa indicar o seu tipo entre "<>" 

        //Função para executar a váriavel string "mensagemBoasVindas"
        void ExibirLogo()
        {
            Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░

"); // Verbatine Literal: o "@" permite que a string apareça da maneira desejada pelo programador
            Console.WriteLine(mensagemBoasVindas);
        }

        //Função que executa as opções do menu
        void ExibirOpcoesMenu()
        {
            ExibirLogo();
            Console.WriteLine("\nRegistrar uma banda (Digite 1)");
            Console.WriteLine("Criar uma conta (Digite 2)");
            Console.WriteLine("Registrar uma banda (Digite 3)");
            Console.WriteLine("Sair (Digite 4)");


            Console.Write("\nEscolha sua opção: "); //Apenas "Console.Write" para que o "Console.ReadLine" fique na mesma linha
            string opcaoUsuario = Console.ReadLine()!; //"!" evita retornar valor nulo
            int opcaoUsuarioNumerica = int.Parse(opcaoUsuario); //Converte uma string em um número inteiro
            switch (opcaoUsuarioNumerica) //Recomendado usar em situções que há várias opções em vez de if/else
            {
                case 1 = RegistrarBanda();
                    break;
                case 2 = MostrarBandasRegistradas();
                    break;
                case 3 = RegistrarBanda();
                    break;
                case 4 = Console.WriteLine("Você está saindo do aplicativo");
                    break;
                default = Console.WriteLine("Opção inválida");
                    break;
            }
        }

        //Função que recebe o nome da banda e faz o registro dela no site
        void RegistrarBanda()
        {
            string nomeBanda = Console.ReadLine()!;
            listaBandas.Add(nomeBanda);

            Console.Clear();
            Console.WriteLine("Registro de bandas");
            Console.WriteLine("Digite o nome da banda que deseja registrar: ");
            Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!"); //Interpolação de string
            Thread.Sleep(2000);
            Console.Clear();
            ExibirOpcoesMenu
        }

        //Função que mostra a lista de todas as bandas registradas
        void MostrarBandasRegistradas()
        {
            Console.Clear();
            Console.WriteLine("Exibindo todas as bandas registradas\n");
            //for (int i = 0; i < listaBandas.Count; i++)
            //{
                //Console.Writiline($"Banda: {listaBandas[i]}");
            //}

            foreach (string banda in listaBandas)
            {
                Console.Writiline($"Banda: {banda}");
            }
            
            Console.Writiline("\nDigite uma tecla para voltar para o menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesMenu();
        }

        ExibirOpcoesMenu();