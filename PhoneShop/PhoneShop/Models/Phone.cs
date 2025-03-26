using System;
using System.Collections.Generic;

namespace PhoneShop.Models;

public partial class Phone
{
    public int PhoneId { get; set; }

    public string Model { get; set; } = null!;

    public string Producer { get; set; } = null!;

    public string Country { get; set; } = null!;

    public DateTime YearOfRelease { get; set; }

    public string? ImageLocation { get; set; }
}
