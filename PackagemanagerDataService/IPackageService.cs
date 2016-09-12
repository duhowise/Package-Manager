using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PackageEntities;

namespace PackagemanagerDataService
{
    [ServiceContract]
    public interface IPackageService
    {
        [OperationContract]
        int Login(string username, string password);

        [OperationContract]
        List<Package> GetPackages();

    }
}
