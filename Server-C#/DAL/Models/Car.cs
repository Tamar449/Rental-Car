using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Car
{
    public short Id { get; set; }

    public string LicensePlate { get; set; } = null!;

    public short CarModelId { get; set; }

    public short NumberOfSeats { get; set; }

    public short YearBook { get; set; }

    public bool AutomaticGear { get; set; }

    public short DriveTypeId { get; set; }

    public double PricePerHour { get; set; }

    public double FuelConsumptionPerKm { get; set; }

    public short Balance { get; set; }

    public string City { get; set; } = null!;

    public string Street { get; set; } = null!;

    public bool Available { get; set; }

    public virtual CarModel CarModel { get; set; } = null!;

    public virtual DriveType DriveType { get; set; } = null!;

    public virtual ICollection<Rental> Rentals { get; set; } = new List<Rental>();
}
