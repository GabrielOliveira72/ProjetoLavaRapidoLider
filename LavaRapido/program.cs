using LavaRapido;

List<Servico> servicos = new();

while (true)
{
    Console.WriteLine("------------------------");
    Console.WriteLine("1 - Cadastrar serviço: ");
    Console.WriteLine("2 - Listar serviços: ");
    Console.WriteLine("3 - Sair: ");
    Console.WriteLine("Insira a opção desejada: ");
    Console.WriteLine("------------------------");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao) {

        case 1:

             Console.WriteLine("insira o nome do serviço");
             string tipo1 = Console.ReadLine();
             Console.WriteLine("insira o preço do serviço");
             decimal preco1 = decimal.Parse(Console.ReadLine());
             servicos.Add(new Servico { Tipo = tipo1, Preco = preco1 });
            break;

        case 2:

            foreach (Servico s in servicos)
            {
         
                Console.WriteLine($"{s.Tipo} - R$ {s.Preco}");
            }
            break;

        case 3:
            return; //CASO EU QUEIRA RODAR ALGO DEPOIS DO WHILE, RETIRAR O RETURN E COLOCAR BOOL
    }


    

}

