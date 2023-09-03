namespace OnionCrafter.Action.Base
{
    /// <summary>
    /// Interface for time tracing actions
    /// </summary>
    public interface IActionTimeStamp
    {  /// <summary>
       /// Gets the timestamp of the action.
       /// </summary>
        public DateTime TimeStamp { get; protected set; }
    }
}