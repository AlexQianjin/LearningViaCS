using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class Handler
    {
        private Handler next;
        private int id;
        public int Limit { get; set; }

        public Handler(int id, Handler handler)
        {
            this.id = id;
            this.Limit = id * 1000;
            this.next = handler;
        }

        public string HandleRequest(int data)
        {
            if (data < this.Limit)
            {
                return "Request for " + data + " handled at level " + id;
            }
            else if (next != null)
            {
                return next.HandleRequest(data);
            }
            else
            {
                return ("Request for " + data + " handled BY DEFAULT at level " + id);
            }
        }
    }
}
