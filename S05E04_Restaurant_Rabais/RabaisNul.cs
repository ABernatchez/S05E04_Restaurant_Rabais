using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Rabais;

public class RabaisNul : IStrategieRabais
{
    public decimal CalculerRabais(decimal sousTotal)
    {
        return ReglesRabais.LimiterTotalAZero(sousTotal);
    }
}
