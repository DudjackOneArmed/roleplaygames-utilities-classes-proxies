namespace System
{
    /// <summary>
    /// Contains methods that are static in DateTime.
    /// </summary>
    public interface IDateTimeService
    {
        /// <summary>
        /// Gets a System.DateTime object that is set to the current date and time on this computer, expressed as the local time.
        /// </summary>
        DateTime Now { get; }

        /// <summary>
        /// Gets a System.DateTime object that is set to the current date and time on this computer, expressed as the Coordinated Universal Time (UTC).
        /// </summary>
        DateTime UtcNow { get; }

        /// <summary>
        /// 
        /// </summary>
        DateTime Today { get; }
    }
}
