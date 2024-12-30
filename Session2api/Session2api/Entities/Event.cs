using System;
using System.Collections.Generic;

namespace Session2api.Entities;

public partial class Event
{
    public int IdEvent { get; set; }

    public string? EventName { get; set; }

    public string? EventType { get; set; }

    public string? EventStatus { get; set; }

    public DateTime? EventDateTime { get; set; }

    public string? EventSponsors { get; set; }

    public string? EventInfo { get; set; }
}
