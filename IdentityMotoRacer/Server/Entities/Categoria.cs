using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace IdentityMotoRacer.Server.Entities
{
    public class Categoria
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Tipo { get; set; } = string.Empty;

        [MaxLength(200)]
        public string Descricao { get; set; } = string.Empty;

        public Collection<Veiculo> Veiculos { get; set; }
              = new Collection<Veiculo>();
    }
}
