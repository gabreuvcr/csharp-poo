namespace System
{
    public static class StringExtensions
    {
        public static string Cut(this string thisStr, int count)
        {
            if (thisStr.Length <= count)
            {
                return thisStr;
            }

            return $"{thisStr.Substring(0, count)}...";
        }
    }
}