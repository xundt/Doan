using System;
using System.Collections.Generic;

namespace ForKids.Models;

public partial class TbProgram
{
    public int ProgramsId { get; set; }

    public string? Programsname { get; set; }

    public string? AgeGroup { get; set; }

    public string? Descriptions { get; set; }

    public string? Duration { get; set; }

    public string? Prince { get; set; }
}
