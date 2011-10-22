using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Host
{
    //định nghĩa các hàm xử lý tại đây, override các hàm định nghĩa bên IService: Interface Service

     [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class OperationService: IService
    {
         public string GetAuthors(){
            return "1/Nguyễn Bá Hiệp        2/Trần Đại Sơn       3/Huỳnh Hữu Tạo";
        }
    }
}
