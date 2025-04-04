﻿

namespace GestaoDeEquipamentos.ConsoleApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            TelaEquipamento telaEquipamento = new TelaEquipamento();
            TelaChamado telaChamado = new TelaChamado();

            while (true)
            {
                string opcaoEscolhida = telaEquipamento.ApresentarMenu();

                switch (opcaoEscolhida)
                {
                    case "1":
                        telaEquipamento.CadastrarEquipamento();
                        break;

                    case "2":
                        telaEquipamento.EditarEquipamento();
                        break;

                    case "3":
                        telaEquipamento.ExcluirEquipamento();
                        break;

                    case "4":
                        telaEquipamento.VisualizarEquipamentos(true);
                        break;

                    case "5":
                        telaChamado.AbrirChamado();
                        break;

                    default:
                        Console.WriteLine("Saindo do programa...");
                        break;
                }

                Console.ReadLine();
            }

        }
    }
}