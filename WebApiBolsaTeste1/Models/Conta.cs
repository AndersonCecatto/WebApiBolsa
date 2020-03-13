namespace WebApiBolsaTeste1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Conta
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public decimal Saldo { get; set; }
    }
}
