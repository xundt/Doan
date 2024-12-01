using System;
using System.Collections.Generic;

namespace ForKids.Models;

public partial class TbFAQ
{
    public int Faqid { get; set; }

    public string? Question { get; set; }

    public string? Answer { get; set; }

    public string? Descriptions { get; set; }
}
