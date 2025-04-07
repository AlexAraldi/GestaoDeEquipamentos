
using System.Runtime.Intrinsics.X86;

namespace GestaoDeEquipamentos
{
    class TelaChamado
    {
        //  Deve ter um identificador único(Id);
        //• Deve ter a título do chamado;
        //• Deve ter a descrição do chamado;
        //• Deve ter um equipamento;
        //• Deve ter uma data de abertura;


        public string tipoDoChamado;
        public string descricaoDoChamado;
        public string equipamentoDoChamado;
        public string dataDoChamado;
        public int IdChamado = 0;
        public int GerarIDChamado()
        {
            IdChamado++;

            return IdChamado;
        }

        public void AbrirChamado()
        {

            Console.WriteLine("Abrir Chamado...");
            Console.WriteLine("--------------------------------------------");

            Console.Write("Digite o ID do registro que deseja selecionar: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Relate o problema que está ocorrendo: ");
            string tipoDoChamado = Console.ReadLine()!;

            Console.WriteLine();
            Console.WriteLine("O chamado foi aberto!");
        }
    }
}