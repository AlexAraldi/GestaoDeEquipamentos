namespace GestaoDeEquipamentos.ConsoleApp.Compartilhado;

public class GeradorIds
{
    public static int IdEquipamentos = 0;
    public static int IdChamado = 0;

    public static int GerarIdEquipamento()
    {
        IdEquipamentos++;

        return IdEquipamentos;
    }
    public static int GerarIDChamado()
    {
        IdChamado++;

        return IdChamado;
    }
}