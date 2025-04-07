
namespace GestaoDeEquipamentos
{
    class TelaChamado
    {
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
            string tipoChamado = Console.ReadLine()!;

            Console.WriteLine();
            Console.WriteLine("O chamado foi aberto!");
        }
    }
}