﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.ViewModels
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Informe o e-mail do Usuário")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe o e-mail do Usuário")]
        public string Senha { get; set; }

    }
}