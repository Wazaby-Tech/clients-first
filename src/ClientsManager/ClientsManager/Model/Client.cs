using ClientsManager.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClientsManager.Core.Model
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IList<ClientAddress> Addresses { get; set; }
        public IList<ClientContact> Contacts { get; set; }
        public ClientAddress PrimaryAddress => Addresses.SingleOrDefault(a => a.IsPrimary);
        public ClientContact PrimaryContact => Contacts.SingleOrDefault(c => c.IsPrimary);
    }
}
