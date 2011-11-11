using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace HostLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    
public class HostService : IService
    {
        public string GetAuthor()
        {
            Thread.Sleep(3000);
            return "Huynh Huu Tao   Tran Dai Son  Nguyen Ba Hiep";
        }
        public double Add(double n1, double n2)
        {
            Thread.Sleep(3000);
            return n1 + n2;
        }

        public double Subtract(double n1, double n2)
        {
            Thread.Sleep(3000);
            return n1 - n2;
        }

        public double Multiply(double n1, double n2)
        {
            Thread.Sleep(3000);
            return n1 * n2;
        }

        public double Divide(double n1, double n2)
        {
            Thread.Sleep(3000);
            return n1 / n2;
        }
        //public string GetData(int value)
        //{
        //    return string.Format("You entered: {0}", value);
        //}

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}
    }
}
