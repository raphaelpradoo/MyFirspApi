namespace MyFirspApi.Entities;

public abstract class Device // Classes Abstratas não podem ser instanciadas
{
    protected bool IsConnected() => true;

    /// <summary>
    /// Abstract no método obriga todas as classes derivadas (classes filhas) à implementarem o método.
    /// O método não precisa ser implementado na classe base (classe pai)
    /// </summary>
    /// <returns></returns>
    public abstract string GetBrand();

    /// <summary>
    /// Virtual no método indica que as classes derivadas podem reescrever o método.
    /// </summary>
    /// <returns></returns>
    public virtual string Hello() => "Hello world";
}
