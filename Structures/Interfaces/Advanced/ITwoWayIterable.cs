namespace Structures.Interfaces.Advanced
{
    /// <summary>
    /// Não pode ser utilizado no foreach mas ao menos conseguimos utilizar para iterar na lista bidireccional
    /// </summary>
    public interface ITwoWayIterable<T> : IOneWayIterable<T>
    {
        void MovePrevious();
    }
}
