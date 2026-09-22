namespace Restaurant.Rabais;

public class CalculateurFacture
{
    private IStrategieRabais strategieRabais;


    public CalculateurFacture(IStrategieRabais strategieRabais)
    {
        ArgumentNullException.ThrowIfNull(strategieRabais, nameof(strategieRabais));
        this.strategieRabais = strategieRabais;
    }

    public decimal CalculerTotal(decimal sousTotal)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(sousTotal, 0, nameof(sousTotal));
        return this.strategieRabais.CalculerRabais(sousTotal);
    }
}
