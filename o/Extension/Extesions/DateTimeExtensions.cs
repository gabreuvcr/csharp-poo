namespace System
{
    public static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24.0)
            {
                return $"{duration.TotalHours:F1} hours";
            }
            
            return $"{duration.TotalDays:F1} days";
        }
    }
}
