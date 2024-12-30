using System;
using System.Collections.Generic;

namespace Session2api.Entities;

public partial class Material
{
    public int? IdMaterial { get; set; }

    public string? MatName { get; set; }

    public DateOnly? MatAcceptDate { get; set; }

    public DateOnly? MatChangeDate { get; set; }

    public string? MatType { get; set; }

    public string? MatStatus { get; set; }

    public string? MatScope { get; set; }

    public string? MatAuthor { get; set; }
}
