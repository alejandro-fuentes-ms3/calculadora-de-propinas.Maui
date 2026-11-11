using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDePropinas.net.Models
{
    public class ConsumoCompartido
    {
        public decimal ImporteDelConsumo { get; set; } = decimal.Zero;
        public int NumeroDePersonas { get; set; } = 1;
        public decimal porcetanjeDePropina { get; set; } = 10m;

        public ConsumoCompartido( decimal importeDelConsumo,
            int numeroDePersonas =1,
            decimal porcentajeDePersonas = 10.0m)
        {
            ImporteDelConsumo = importeDelConsumo;
            NumeroDePersonas = numeroDePersonas;
            porcetanjeDePropina = porcentajeDePersonas;
        }
        public decimal ImporteDelConsumoPorPersona => ImporteDelConsumo / NumeroDePersonas;
        public decimal ImporteDeLaPropina => ImporteDelConsumo * porcetanjeDePropina / 100.0m;
        public decimal ImporteDeLaPropinaPorPersona => ImporteDelConsumo /NumeroDePersonas;
        public decimal ImporteDelConsumoConPropina => ImporteDelConsumo + ImporteDeLaPropina;
        public decimal ImporteDelConsumoConPropinaPorPersona => ImporteDelConsumoConPropina / NumeroDePersonas;
    }
}
