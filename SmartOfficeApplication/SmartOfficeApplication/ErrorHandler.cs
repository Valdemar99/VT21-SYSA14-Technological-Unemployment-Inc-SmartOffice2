using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartOfficeApplication
{
    class ErrorHandler
    {
        public string ErrorHandling(int errorCode, string objectName, string keyName)
        {​​
            string returnString = "Unhandled exception, please contact IT support. Error code: " + errorCode;
            if (errorCode == 2627)
            {
                returnString = ("There already exists a " + objectName + " with this " + keyName + " value.");
            }
            else if (errorCode == 0)
            {
                returnString = ("There is a problem with the connection, please check your internet connection and try again. If the problem persists, contact IT support.");
            }
            else if (errorCode == 207)
            {
                returnString = ("The chosen " + objectName + "does not exist.");
            }
            else if (errorCode == 547)
            {
                returnString = ("One of the entered values do not exist.");
            }​​
        return returnString;
        }
    }
}

