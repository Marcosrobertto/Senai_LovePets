using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace senai_lovePets_webApi.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Pets = new HashSet<Pet>();
            Veterinarios = new HashSet<Veterinario>();
        }

        [Required(ErrorMessage = "Informe o nome do usuário")]
        public int IdUsuario { get; set; }
        [Required(ErrorMessage = "Informe o Id do Tipo Usuario")]
        public int? IdTipoUsuario { get; set; }
        [Required(ErrorMessage = "Informe a E-mail")]
        public string Email { get; set; }
        [StringLength(100, MinimumLength = 5, ErrorMessage = "A senha deve conter no mínimo 5 caracteres")]
        public string Senha { get; set; }

        public virtual TipoUsuario IdTipoUsuarioNavigation { get; set; }
        public virtual ICollection<Pet> Pets { get; set; }
        public virtual ICollection<Veterinario> Veterinarios { get; set; }
    }
}
