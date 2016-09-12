using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PackageEntities;

namespace PackagemanagerDataService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class DataService : IPackageService
    {
        
        public int Login(string username, string password)
        {
            return 1;
        }

        public List<Package> GetPackages()
        {
            List<Package>packages=new List<Package>();
            Package sentPackage=new Package
            {
                Id =1,
                Code = "qwerty",
                Description = "sent package",
                DestinationId = 12,
                DispatchedTime = DateTime.Today,
                RecievedTime = DateTime.Today,
                DispatcherId = 12,
                Reciever = "Kweku Mensah",
                RecieverId = 11,
                RecieverNumber = "02544"
            };
            packages.Add(sentPackage);
            return packages;
            
        }
    }
}
