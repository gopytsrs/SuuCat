﻿using System;
using System.Collections.Generic;
using EventBus.Events.Interfaces;

namespace EventBus.Events;

public class StockReservedEvent : IStockReservedEvent
{
    public StockReservedEvent(Guid correlationId)
    {
        CorrelationId = correlationId;
    }

    public List<OrderItem> OrderItems { get; set; }

    public Guid CorrelationId { get; }
}