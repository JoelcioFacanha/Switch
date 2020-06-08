using Switch.Domain.Enums;

namespace Switch.Domain.Entities
{
    public class Identificacao
    {
        public int Id { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string Numero { get; set; }
        public int UsuarioId { get; set; }
        /// <summary>
        /// Propriedade de navegação
        /// </summary>
        public virtual Usuario Usuario { get; set; }
    }
}