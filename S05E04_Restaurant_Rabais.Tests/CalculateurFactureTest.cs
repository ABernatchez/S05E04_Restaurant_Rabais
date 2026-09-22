using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Rabais.Tests;

public class CalculateurFactureTest
{
    [Fact]
    public void Constructor_StrategieRabaisNull_LanceErreur()
    {
        Assert.Throws<ArgumentNullException>(() =>
            new CalculateurFacture(null)
        );
    }

    [Fact]
    public void CalculerTotal_DelegationCalculRabaisAStrategie_RetourneCorrecteTotal()
    {
        RabaisFixe rabais = new();
        CalculateurFacture calculateur = new(rabais);

        decimal expected = rabais.CalculerRabais(20m);
        decimal result = calculateur.CalculerTotal(20m);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void CalculerTotal_SousTotalNegatif_LanceErreur()
    {
        RabaisNul rabais = new();
        CalculateurFacture calculateur = new(rabais);

        Assert.Throws<ArgumentOutOfRangeException>(() =>
            calculateur.CalculerTotal(-10)
        );
    }
}
