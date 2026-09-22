using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Rabais;

public class RabaisMultiple : IStrategieRabais
{
    private IStrategieRabais rabais1;
    private IStrategieRabais rabais2;


    public RabaisMultiple(IStrategieRabais rabais1, IStrategieRabais rabais2)
    {
        ArgumentNullException.ThrowIfNull(rabais1);
        this.rabais1 = rabais1;

        ArgumentNullException.ThrowIfNull(rabais2);
        this.rabais2 = rabais2;
    }

    public decimal CalculerRabais(decimal sousTotal)
    {
        decimal total = this.rabais1.CalculerRabais(sousTotal);
        total = this.rabais2.CalculerRabais(total);
        return ReglesRabais.LimiterTotalAZero(total);
    }
}
