using System;
using System.Collections.Generic;
using System.Text;
using QuasarQuery.Entity;

namespace QuasarQuery.Entity.Collection
{
    public class SessionCollection : List<Session>
    {
        public SessionCollection()
        {
            
        }

        public Session Current()
        {
            return this[0];
        }

    }
}
