using System;

namespace InternetLog.Model
{
    public class LogRecord : IComparable<LogRecord>
    {
        public string Username { get; set; }
        public DateTime Instant { get; set; }

        public LogRecord(string username, DateTime instant)
        {
            Username = username;
            Instant = instant;
        }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is not LogRecord)
            {
                return false;
            }

            LogRecord other = obj as LogRecord;
            return Username.Equals(other.Username);
        }

        // public int CompareTo(object obj)
        // {
        //     if (obj is not LogRecord)
        //     {
        //         throw new ArgumentException("The argument is not LogRecord");
        //     }

        //     LogRecord other = obj as LogRecord;
        //     return Username.CompareTo(other.Username);
        // }

        public int CompareTo(LogRecord other)
        {
            return Username.CompareTo(other.Username);
        }
    }
}
