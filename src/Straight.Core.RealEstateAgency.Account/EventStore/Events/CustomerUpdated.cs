﻿using Straight.Core.EventStore;
using Straight.Core.RealEstateAgency.Model;

namespace Straight.Core.RealEstateAgency.Account.EventStore.Events
{
    public sealed class CustomerUpdated : DomainEventBase
    {
        public CustomerUpdated(Customer c, User modifier)
        {
            Modifier = modifier;
            Customer = c;
        }

        public User Modifier { get; private set; }
        public Customer Customer { get; private set; }
    }
}