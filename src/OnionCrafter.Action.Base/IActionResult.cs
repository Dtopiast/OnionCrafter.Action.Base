namespace OnionCrafter.Action.Base
{
    /// <summary>
    /// Interface for tracing action result in boolean.
    /// </summary>
    public interface IActionResult
    {
        /// <summary>
        /// Gets a value indicating whether the response succeeded.
        /// </summary>
        public bool Succeeded { get; protected set; }
    }
}