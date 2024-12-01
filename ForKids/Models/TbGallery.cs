using System;
using System.Collections.Generic;

namespace ForKids.Models;

public partial class TbGallery
{
    public int GalleryId { get; set; }

    public string? FileName { get; set; }

    public string? Type { get; set; }

    public DateTime? UploadDate { get; set; }

    public string? Descriptions { get; set; }
}
