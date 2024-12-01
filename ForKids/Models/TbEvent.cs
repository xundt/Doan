using System;
using System.Collections.Generic;

namespace ForKids.Models;

public partial class TbEvent
{
    public int EventsId { get; set; }

    public string? Eventsname { get; set; }

    public DateTime? Date { get; set; }

    public string? Location { get; set; }

    public string? Descriptions { get; set; }
}
