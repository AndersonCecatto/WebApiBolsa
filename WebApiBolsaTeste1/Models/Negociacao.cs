namespace WebApiBolsaTeste1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Negociacao
    {
        public int Id { get; set; }

        public int MonitoramentoId { get; set; }

        public decimal ValorNegociado { get; set; }

        public int Quantidade { get; set; }

        public string TipoOperacao { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DataHora { get; set; }

        public virtual Monitoramento Monitoramento { get; set; }
    }
}
