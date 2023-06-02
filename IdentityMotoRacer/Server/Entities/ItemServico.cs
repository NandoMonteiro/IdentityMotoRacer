using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IdentityMotoRacer.Server.Entities
{
    public class ItemServico
    {
        public int Id { get; set; }

        [MaxLength(200)]
        public string Descricao { get; set; } = string.Empty;

        public string Tipo { get; set; } = string.Empty;

        [Column(TypeName = "decimal(10,2)")]
        public decimal Valor { get; set; }
    }
}
