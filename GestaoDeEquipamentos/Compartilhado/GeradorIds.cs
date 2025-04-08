namespace GestaoDeEquipamentos.ConsoleApp.Compartilhado;

internal partial class Program
{
    public class GeradorIds
    {
        public int IdEquipamentos = 0;
        public int IdChamado = 0;


        public int GerarIdEquipamento()
        {
            IdEquipamentos++;

            return IdEquipamentos;
        }
        public int GerarIDChamado()
        {
            IdChamado++;

            return IdChamado;
        }

    }

}