// Copyright (c) Oleksii Nikiforov, 2021. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.

namespace NikiforovAll.CA.Template.Application.SharedKernel.Models;

using MediatR;
using NikiforovAll.CA.Template.Domain.SharedKernel;

public class DomainEventNotification<TDomainEvent> : INotification where TDomainEvent : DomainEvent
{
    public DomainEventNotification(TDomainEvent domainEvent) => this.DomainEvent = domainEvent;

    public TDomainEvent DomainEvent { get; }
}
