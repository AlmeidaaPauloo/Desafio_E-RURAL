using CODERURALAPI.Entidades;

namespace CODERURALAPI.DTOs
{
    public class CadastrarPerfilDTO
    {
        public string Nome { get; set; }

        #region Relacionamentos

        public List<UsuarioPerfil> Usuarios { get; set; }

        #endregion
    }
}
