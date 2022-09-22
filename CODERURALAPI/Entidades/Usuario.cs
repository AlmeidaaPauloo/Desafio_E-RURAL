namespace CODERURALAPI.Entidades
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCriacao { get; set; }

        #region Relacionamentos

        public List<UsuarioPerfil> Perfis { get; set; }

        #endregion
    }
}