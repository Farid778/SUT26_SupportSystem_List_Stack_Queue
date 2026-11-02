using System;
using System.Collections.Generic;
using System.Text;

namespace SUT26_SupportSystem_List_Stack_Queue.Models
{
    internal class Customer
    {
        public int ID { get; set; } 
        public string Name { get; set; }

        public Customer(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
