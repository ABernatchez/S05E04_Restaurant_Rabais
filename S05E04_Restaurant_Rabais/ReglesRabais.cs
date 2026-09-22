using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Rabais;

public static class ReglesRabais
{
    public static decimal LimiterTotalAZero(decimal total)
    {
        return total <= 0m ? 0m : total;
    }
}
