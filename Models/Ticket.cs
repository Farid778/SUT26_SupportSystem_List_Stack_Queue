using System;
using System.Collections.Generic;
using System.Text;

namespace SUT26_SupportSystem_List_Stack_Queue.Models
{
    internal class Ticket
    {
        public int CustomerID { get; set; }
        public string Description { get; set; }

        public Ticket(int customerID, string discription)
        {
            CustomerID = customerID;
            Description = discription;
        }
    }
}
