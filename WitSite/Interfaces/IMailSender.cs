using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitSite.Interfaces
{
    interface IMailSender<T> where T:class
    {
        void SendMail(T item);
    }
}
