﻿using EventBus.Base.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Base.Abstraction
{
    public interface IIntegrationEventHandler<TIntegraionEvent>:IntegrationEventHandler where TIntegraionEvent:IntegrationEvent
    {
        Task Handle(TIntegraionEvent @event);
    }

    public interface IntegrationEventHandler
    {
    }
}
