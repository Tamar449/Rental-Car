using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models;

public partial class Return
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public short Id { get; set; }

    public short RentalId { get; set; }

    public DateTime DateAndTime { get; set; }

    public short Balance { get; set; }

    public double TotalPayable { get; set; }

    public bool Paid { get; set; }

    public virtual Rental Rental { get; set; } = null!;
}
