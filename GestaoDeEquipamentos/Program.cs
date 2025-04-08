
using GestaoDeEquipamentos.ConsoleApp.ModuloEquipamento;
using GestaoDeEquipamentos.ConsoleApp.ModuloChamado;
using GestaoDeEquipamentos.ConsoleApp.Compartilhado;

namespace GestaoDeEquipamentos.ConsoleApp;

internal partial class Program
{
    static void Main2(string[] args)
    {
          
        int a = GeradorIds.GerarIdEquipamento();
        int b = GeradorIds.GerarIdEquipamento();
        int c = GeradorIds.GerarIdEquipamento();        
        int d = GeradorIds.GerarIDChamado();
        int e = GeradorIds.GerarIdEquipamento();
        int f = GeradorIds.GerarIDChamado();
    }

    static void Main(string[] args)
    {

        TelaEquipamento telaEquipamento = new TelaEquipamento();

        TelaChamado telaChamado = new TelaChamado();        

        while (true)
        {
            string opcaoEscolhida = telaEquipamento.ApresentarMenu();

            switch (opcaoEscolhida)
            {
                case "1": telaEquipamento.CadastrarEquipamento(); break;

                case "2": telaEquipamento.EditarEquipamento(); break;

                case "3": telaEquipamento.ExcluirEquipamento(); break;

                case "4": telaEquipamento.VisualizarEquipamentos(true); break;

                case "5": telaChamado.AbrirChamado(); break;

                default:
                    Console.WriteLine("Saindo do programa...");
                    break;
            }

            Console.ReadLine();
        }

    }
}