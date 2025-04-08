using System.Data;
using GestaoDeEquipamentos.ConsoleApp;

namespace GestaoDeEquipamentos
{
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

}