using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Rabais.Tests;

public class RabaisMultipleTest
{
    public static IList<object[]> StrategieRabaisNullData => new List<object[]>
    {
        new object[] { new RabaisNul(), null },
        new object[] { null, new RabaisNul() },
    };


    [Theory]
    [MemberData(nameof(StrategieRabaisNullData))]
    public void Constructor_StrategieRabaisNull_LanceErreur(IStrategieRabais rabais1, IStrategieRabais rabais2)
    {
        Assert.Throws<ArgumentNullException>(() =>
            new RabaisMultiple(rabais1, rabais2)
        );
    }
}
