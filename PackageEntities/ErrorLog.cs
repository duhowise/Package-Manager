using System;

namespace PackageEntities
{
    public class ErrorLog:ILog {
        public int UserId { get; set; }
        public string Action { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}