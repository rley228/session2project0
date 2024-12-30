using System;
using System.Collections.Generic;

namespace Session2api.Entities;

public partial class Staff
{
    public int IdStaff { get; set; }

    public string? LastName { get; set; }

    public string? FisrtName { get; set; }

    public string? MiddleName { get; set; }

    public DateOnly? Birthday { get; set; }

    public int? IdDivision { get; set; }

    public string? Position { get; set; }

    public string? Leader { get; set; }

    public string? Assistant { get; set; }

    public string? WorkPhone { get; set; }

    public string? PersonalPhone { get; set; }

    public string? Cabinet { get; set; }

    public string? Email { get; set; }

    public string? OtherInfo { get; set; }

    public virtual ICollection<Division> Divisions { get; set; } = new List<Division>();

    public virtual Division? IdDivisionNavigation { get; set; }
}
