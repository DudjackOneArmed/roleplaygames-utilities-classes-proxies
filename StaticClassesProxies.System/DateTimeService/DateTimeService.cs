namespace System
{
    /// <inheritdoc/>
    public class DateTimeService : IDateTimeService
    {
        /// <inheritdoc/>
        public DateTime Now => DateTime.Now;

        /// <inheritdoc/>
        public DateTime UtcNow => DateTime.UtcNow;

        /// <inheritdoc/>
        public DateTime Today => DateTime.Today;
    }
}
