using System;

namespace PackageEntities
{
    public class Log : ILog
    {
        public int  UserId { get; set; }
        public String Action { get; set; }
        public DateTime TimeStamp { get; set; }

        public Log(int userId, string action, DateTime timeStamp)
        {
            UserId = userId;
            Action = action;
            TimeStamp = timeStamp;
        }
    }
}