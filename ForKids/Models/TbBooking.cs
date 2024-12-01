using System;
using System.Collections.Generic;

namespace ForKids.Models;

public partial class TbBooking
{
    public int BookingId { get; set; }

    public int? UserId { get; set; }

    public int? ServiceId { get; set; }

    public int? ProgramId { get; set; }

    public int? EventId { get; set; }

    public DateTime? BookingDate { get; set; }

    public string? Status { get; set; }

    public string? Descriptions { get; set; }
}
