using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdentityMotoRacer.Server.Entities
{
    public class Locacao
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int VeiculoId { get; set; }
        public DateTime DataRetirada { get; set; }
        public DateTime HoraRetirada { get; set; }
        public DateTime DataDevolucao { get; set; }
        public DateTime Horadevolucao { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal ValorLocacao { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal ValorDesconto { get; set; }
        public int QuilometragemInicial { get; set; }
        public int QuilometragemFinal { get; set; }

        [MaxLength(300)]
        public string Observacao { get; set; } = string.Empty;
        public enum StatusLocacao
        {
            Pendente,
            Emandamento,
            Concluida,
            Cancelada
        }

        public Veiculo? Veiculos { get; set; }
        public Cliente? Clientes { get; set; }
        public LocacaoItemServico? LocacaoItemServicos { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal ValorServico { get; set; }

        public ItemServico? Items { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal ValorItem { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal ValorItemTotal { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Valortotallocacao { get; set; }

        public ICollection<LocacaoItemServico> ItemServicos { get; set; }
            = new List<LocacaoItemServico>();
    }
}
