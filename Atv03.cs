/*
Um estacionamento deseja registrar a entrada de veículos durante o dia. 
Para cada veículo que entrar, o atendente deve informar a placa. 
O sistema deve continuar pedindo novas placas enquanto o 
operador desejar continuar o atendimento.

Ao final, o programa deve mostrar:
- a quantidade total de veículos registrados.

Regras da atividade
- o programa deve usar while para repetir o cadastro das placas;
- após cada tentativa de cadastro, o programa deve perguntar se o operador deseja continuar;
- ao final, exibir a quantidade de veículos registrados com sucesso.

Observação: Vestigios de uso de IA, atividade zerada, 
ou código copiado de terceiros sem a devida citação, serão penalizados.

*/
public static class Atv03
{
    public static void Executar()
    {
        string placa = "";
        int quantidadeVeiculos = 0;
        string continuar = "s";
        int opcao;

        Console.Clear();
        Console.Write("Deseja iniciar o registro de veículos?\n1. Sim\n 2. Não\n\n->");
        opcao = int.Parse(Console.ReadLine()!);

        while (continuar == "s")
        {
            if (opcao == 1)
            {
                Consol.Write("Digite a placa do veículo: ");
                placa = Console.ReadLine()!;
                quantidadeVeiculos++;
                Console.Clear();
                Console.Write("Deseja registrar outro veículo? (s/n)\n->");
                continuar = Console.ReadLine()!;.ToLower();
                Console.Clear();

                if (continuar == "n")
                {
                    Console.WriteLine($"Quantidade total de veículos registrados: {quantidadeVeiculos}");
                }

            }
            else
            {
                Console.WriteLine("Registro de veículos encerrado.");
                Console.WriteLine($"Quantidade total de veículos registrados: {quantidadeVeiculos}");
                break;
            }
        }
    }
}
