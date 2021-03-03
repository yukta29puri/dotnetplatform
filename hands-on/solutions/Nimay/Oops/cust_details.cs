using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_customer
{
    class cust_details
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Mobile { get; set; }
        public string Address { get; set; }
        public string LoyaltyMember { get; set; }

        public cust_details(int id, string name, string email, long mobile, string address, string loyaltymember)
        {
            Id = id;
            Name = name;
            Email = email;
            Mobile = mobile;
            Address = address;
            LoyaltyMember = loyaltymember;
        }
        public void Display()
        {
            Console.WriteLine("Customer Details ");
            Console.WriteLine("*******************");
            Console.WriteLine(" Id        : {0}\n " +
                              "Name       : {1}\n " +
                              "Email      : {2}\n " +
                              "Mobile     : {3}\n " +
                              "Address    : {4}\n" +
                              "Membership : {5}\n", Id, Name, Email, Mobile, Address,LoyaltyMember);
        }
    }
}
