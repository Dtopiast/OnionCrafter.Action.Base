namespace OnionCrafter.Action.Base
{
    /// <summary>
    /// Interface for action details like important information.
    /// </summary>
    public interface IActionDetails<TKey> :
        IActionResult,
        IActionTimeStamp,
        IActionTrace<TKey>
        where TKey : notnull, IEquatable<TKey>, IComparable<TKey>
    {

    }
}