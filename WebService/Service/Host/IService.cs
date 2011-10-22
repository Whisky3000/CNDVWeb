using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Host
{
//Interface Service: định nghĩa các hàm cung cấp cho client
    [ServiceContract(Namespace = "http://myuri.org/Simple")]
    public interface IService
    {
        [OperationContract]
        string GetAuthors();


    }
   
}
