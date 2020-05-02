namespace Structures.Interfaces.Advanced
{
    /// <summary>
    /// Não pode ser utilizado no foreach mas ao menos conseguimos utilizar para iterar na lista
    /// </summary>
    public interface IOneWayIterable<T> : IIterable<T>
    {
        void MoveNext();
    }
}
