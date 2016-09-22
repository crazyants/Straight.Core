﻿using System;
using Straight.Core.Domain;
using Straight.Core.EventStore.Aggregate;

namespace Straight.Core.EventStore.Storage
{
    public interface IIdentityMap<out TDomainCommand, TDomainEvent>
        where TDomainEvent : IDomainEvent
        where TDomainCommand : IDomainCommand
    {
        TAggregate GetById<TAggregate>(Guid id) where TAggregate : class, IAggregator<TDomainCommand, TDomainEvent>, new();
        void Add<TAggregate>(TAggregate aggregateRoot) where TAggregate : class, IAggregator<TDomainCommand, TDomainEvent>, new();
        void Remove<TAggregate>(Guid aggregateRootId) where TAggregate : class, IAggregator<TDomainCommand, TDomainEvent>, new();
        void Remove(Type aggregateRootType, Guid aggregateRootId);
    }

}