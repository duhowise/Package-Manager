using System;

namespace PackageEntities
{
    public class Users
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string UserName { get; set; }
        public String Pasword { get; set; }

        public Users(int id, string name, string userName, string pasword)
        {
            Id = id;
            Name = name;
            UserName = userName;
            Pasword = pasword;
        }

    }
}