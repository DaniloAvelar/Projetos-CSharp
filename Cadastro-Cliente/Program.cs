internal class Program
{
    // Estanciando uma nova lista de clientes
    static List<Cliente> clientes = new List<Cliente>();

    private static void Main(string[] args)
    {
        bool executando = true;

        while (executando)
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Cadastrar Cliente");
            Console.WriteLine("2 - Visualizar Cliente");
            Console.WriteLine("3 - Editar Cliente");
            Console.WriteLine("4 - Excluir Cliente");
            Console.WriteLine("5 - Sair");

            int opcao = Convert.ToInt32(Console.ReadLine());

            switch(opcao)
            {
                case 1:
                    AdcionarCliente();
                    break;
                case 2:
                    VisualizarCliente();
                    break;
                case 3:;
                    EditarCliente();
                    break;
                case 4:;
                    ExcluirCliente();
                    break;
                case 5:
                    executando = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }

    // Cadastrar Cliente
    static void AdcionarCliente()
    {
        Console.WriteLine("Digite o nome do cliente: ");
        string nmCliente = Console.ReadLine();

        Console.WriteLine("Digite o e-mail do cliente: ");
        string emailCliente = Console.ReadLine();

        Cliente cliente = new Cliente(nmCliente, emailCliente);
        clientes.Add(cliente);

        Console.WriteLine("Cliente cadastrado com sucesso!");
    }

    //Visualizar Cliente
    static void VisualizarCliente()
    {
        foreach(Cliente cliente in clientes)
        {
            Console.WriteLine("Nome: " + cliente.Nome);
            Console.WriteLine("Email: "+ cliente.Email);
            Console.WriteLine("------------------------"); 
        }
    }

    // Editar Cliente
    static void EditarCliente()
    {
        Console.WriteLine("Digite o nome do cliente que deseja alterar:");
        string nmCliente = Console.ReadLine();

        Cliente cliente = clientes.Find(c => c.Nome == nmCliente);

        if(cliente != null)
        {
            Console.WriteLine("Digite o 'NOVO' nome do cliente: ");
            string nnmCliente = Console.ReadLine();

            Console.WriteLine("Digite o 'NOVO' email do cliente: ");
            string nEmailCliente = Console.ReadLine();

            cliente.Nome = nnmCliente;
            cliente.Email = nEmailCliente;

            Console.WriteLine("Cliente editado com sucesso!");
        }
        else
        {
            Console.WriteLine("Cliente não cadastrado!");
        }
    }

    static void ExcluirCliente()
    {
        Console.WriteLine("Digite o nome que deseja excluir: ");
        string exCliente = Console.ReadLine();

        Cliente cliente = clientes.Find(c => c.Nome == exCliente);

        if(cliente != null)
        {
            clientes.Remove(cliente);
            Console.WriteLine("Cliente excluído com sucesso.");
        }
        else
        {
            Console.WriteLine("Cliente não encontrado.");
        }
    }



    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Cliente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }

}