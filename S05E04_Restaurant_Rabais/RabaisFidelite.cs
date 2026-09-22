using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Rabais;

public class RabaisFidelite : IStrategieRabais
{
    public decimal CalculerRabais(decimal sousTotal)
    {
        return ReglesRabais.LimiterTotalAZero(sousTotal * 0.90m);
    }
}
