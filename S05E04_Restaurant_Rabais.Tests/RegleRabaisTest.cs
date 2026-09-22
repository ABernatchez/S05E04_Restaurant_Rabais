using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Rabais.Tests;

public class RegleRabaisTest
{
    [Theory]
    [InlineData(-16, 0)]
    [InlineData(0, 0)]
    [InlineData(5, 5)]
    public void LimiterTotalAZero_Theory_EstEgaleAuRésultatAttendu(decimal total, decimal expected)
    {
        decimal result = ReglesRabais.LimiterTotalAZero(total);

        Assert.Equal(expected, result);
    }
}
