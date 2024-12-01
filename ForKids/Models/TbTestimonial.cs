using System;
using System.Collections.Generic;

namespace ForKids.Models;

public partial class TbTestimonial
{
    public int TestimonialId { get; set; }

    public int? UserId { get; set; }

    public string? Message { get; set; }

    public int? Rating { get; set; }

    public DateTime? Date { get; set; }

    public string? Descriptions { get; set; }
}
