using System;
using System.Collections.Generic;

namespace Session2api.Entities;

public partial class Division
{
    public int IdDivision { get; set; }

    public string? DivName { get; set; }

    public string? DivInfo { get; set; }

    public string? DivLead { get; set; }

    public int? IdStaff { get; set; }

    public virtual Staff? IdStaffNavigation { get; set; }

    public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();
}
