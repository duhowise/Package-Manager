using System;

namespace PackageEntities
{
    public interface ILog
    {
        int UserId { get; set; }
        String Action { get; set; }
        DateTime TimeStamp { get; set; }
    }
}