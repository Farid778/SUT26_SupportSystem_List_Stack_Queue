using System;
using System.Collections.Generic;
using System.Text;

namespace SUT26_SupportSystem_List_Stack_Queue.Models
{
    internal class Helpdisk
    {
        //All Customers List<T>
        private List<Customer> customers = new List<Customer>();

        //Kolla på Customers by id Dictionary<T>
        private Dictionary<int, Customer> customerRegistry = new Dictionary<int, Customer>();

        //Incoming Tickets (FIFO) Queue<T>
        private Queue<Ticket> ticketQueue = new Queue<Ticket>();

        //Closed Tickets (LIFO) Stack<T>
        private Stack<Ticket> closedTickets = new Stack<Ticket>();
    }
}
