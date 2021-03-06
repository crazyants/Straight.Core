﻿using Straight.Core.EventStore;
using Straight.Core.Sample.RealEstateAgency.Account.EventStore.Events;
using Straight.Core.Sample.RealEstateAgency.Model;
using System;
using System.Collections.Generic;

namespace Straight.Core.Sample.RealEstateAgency.Test.Common.Server
{
    public static class PersonaAccount
    {
        private static IAccount _virginie;
        private static IAccount _pierre;

        public static IAccount Virginie => _virginie ?? (_virginie = BuildVirginie());

        public static IAccount Pierre => _pierre ?? (_pierre = BuildPierre());

        private static IAccount BuildVirginie()
        {
            var virginie = new Account.Domain.Account();
            virginie.LoadFromHistory(new List<IDomainEvent>
            {
                new AccountCreated("chevalier.virginie", PersonaUser.John, new[] {PersonaCustomer.Virginie})
                {
                    AggregateId = Guid.NewGuid()
                }
            });
            return virginie;
        }

        private static IAccount BuildPierre()
        {
            var pierre = new Account.Domain.Account();
            pierre.LoadFromHistory(new List<IDomainEvent>
            {
                new AccountCreated("pierre.durand", PersonaUser.Jane, new[] {PersonaCustomer.Pierre})
                {
                    AggregateId = Guid.NewGuid()
                }
            });
            return pierre;
        }
    }
}