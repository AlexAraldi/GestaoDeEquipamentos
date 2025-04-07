﻿namespace GestaoDeEquipamentos.ConsoleApp
{
    internal partial class Program
    {
        public class GeradorIds
        {
            public int IdEquipamentos = 0;

            public int GerarIdEquipamento()
            {
                IdEquipamentos++;

                return IdEquipamentos;
            }

            public Guid GerarGuidEquipamento()
            {
                return Guid.NewGuid();
            }

        }
    }
}