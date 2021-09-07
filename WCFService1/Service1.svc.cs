using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {        
        //Method that sorts a string of number values
        public string sort(string s)

        {
            //creates a string array of user values seperated by ','
            string[] values = (s).Split(',');
            //Converts the string array of inputs into a int array
            int[] intValues = Array.ConvertAll(values, int.Parse);
            //sorts int array of values using Array.sort()
            Array.Sort(intValues);
            //returns string of intValues[] followed by a comma 
            //after every intValue
            return String.Join(",", intValues);
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
