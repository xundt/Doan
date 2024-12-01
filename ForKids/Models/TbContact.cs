using System;
using System.Collections.Generic;

namespace ForKids.Models;

public partial class TbContact
{
    public int ContactId { get; set; }

    public int? UserId { get; set; }

    public string? Message { get; set; }

    public DateTime? ContactDate { get; set; }

    public string? Descriptions { get; set; }
}
