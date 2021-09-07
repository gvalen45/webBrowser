using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace converterService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        // Method to convert Celsius temperature to Fahrenheit temperature 
        public int c2f(int c) {
            //performs Celsius to Fahrenheit calculation
            double convertedInt = ((c * 1.8) + (32));
            //converts calculation to a int32(int type) and then returns it
            return Convert.ToInt32(convertedInt);
        }
        // Method to convert Fahrenheit temperature to Celsius temperature
        public int f2c(int f)
        {
            //performs Fahrenheit to Celsius calculation
            double convertedInt = ((f - 32) * 0.555555555556);
            //converts calculation to a int32(int type) and then returns it
            return Convert.ToInt32(convertedInt);

        }
        

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
