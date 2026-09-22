using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Rabais.Tests;

public class RabaisFixeTest
{
    [Theory]
    [InlineData(10, 5)]
    [InlineData(5, 0)]
    [InlineData(3, 0)]
    public void CalculerRabais_Theory_EstEgaleAuRésultatAttendu(decimal sousTotal, decimal expected)
    {
        RabaisFixe rabaisFixe = new();

        decimal result = rabaisFixe.CalculerRabais(sousTotal);

        Assert.Equal(expected, result);
    }
}
