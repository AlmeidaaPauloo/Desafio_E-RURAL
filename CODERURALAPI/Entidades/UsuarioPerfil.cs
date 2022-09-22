namespace CODERURALAPI.Entidades
{
    public class UsuarioPerfil
    {
        public Guid UsuarioId { get; set; }
        public Guid PerfilId { get; set; }

        #region Relacionamentos

        public Usuario Usuario { get; set; }
        public Perfil Perfil { get; set; }

        #endregion
    }
}
