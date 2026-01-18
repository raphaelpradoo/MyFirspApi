namespace MyFirspApi.Entities;

/// <summary>
/// O modificador Sealed impede que a classe seja herdada
/// </summary>
public sealed class Laptop: Device
{
    public override string GetBrand()
    {
        return "Apple";
    }

    public string GetModel()
    {
        var isConnected = IsConnected();

        if (isConnected)
            return "MacBook";
        return "Unknow";
    }

    public override string Hello() => "Raphael";
}
