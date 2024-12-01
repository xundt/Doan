using System;
using System.Collections.Generic;

namespace ForKids.Models;

public partial class TbUser
{
    public int UserId { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? FullName { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public int? RoleId { get; set; }

    public string? Address { get; set; }

    public bool IsActive { get; set; }

    public string? Descriptions { get; set; }
}
