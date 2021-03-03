using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_customer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            cust_details details = new cust_details(1001, "Nimay", "nimaytiwari51@gmail.com", 7843853014, "A-block","Elite");
            details.Display();
        }
    }
}
