using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models;

public partial class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public short Id { get; set; }

    public string Name { get; set; } = null!;

    public string Tz { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string CreditNumber { get; set; } = null!;

    public string ExpirationDate { get; set; }

    public string Cvv { get; set; } = null!;

    public short UserTypeId { get; set; }

    public virtual ICollection<Rental> Rentals { get; set; } = new List<Rental>();

    public virtual UserType UserType { get; set; } = null!;
}
