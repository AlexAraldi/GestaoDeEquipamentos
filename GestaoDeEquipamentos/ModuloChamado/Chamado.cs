namespace GestaoDeEquipamentos.ConsoleApp.ModuloChamado;

internal class Chamado
{
    public int id;
    public string tituloChamado;
    public string descricaoChamado;
    public Equipamento equipamento;
    public DateTime dataAbertura;

    public Chamado(string tituloChamado, string descricaoChamado, Equipamento equipamento)
    {
        this.tituloChamado = tituloChamado;
        this.descricaoChamado = descricaoChamado;
        this.equipamento = equipamento;
        dataAbertura = DateTime.Now;
    }


}