using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Rabais;

public interface IStrategieRabais
{
    decimal CalculerRabais(decimal sousTotal);
}
