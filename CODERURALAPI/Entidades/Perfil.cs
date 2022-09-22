namespace CODERURALAPI.Entidades
{
    public class Perfil
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        #region Relacionamentos

        public List<UsuarioPerfil> Usuarios { get; set; }

        #endregion
    }
}
