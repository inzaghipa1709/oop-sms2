using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Pertemuan7
{

    public class LatTryCatch1
    {

        public static void DoBilling(object client,string clientID)
        {
            if (client == null)
            {
                throw new ClientBillingException(
                    string.Format("Unable to find a client by id {0}", 
                    clientID));
            }
        }

        public class ClientBillingException : Exception
        {
            public ClientBillingException(string message)
               : base(message)
            {
            }
        }
    }



}
