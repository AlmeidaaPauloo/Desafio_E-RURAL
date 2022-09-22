using CODERURALAPI.Entidades;

namespace CODERURALAPI.DTOs
{
    public class ConsultarPerfilDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        #region Relacionamentos

        public List<UsuarioPerfil> Usuarios { get; set; }

        #endregion
    }
}
