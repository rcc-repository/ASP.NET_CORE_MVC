﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppMvcBasica.Models
{
    public class Fornecedor: Entity
    {
        [Required(ErrorMessage = "O Campo {0} é obrigatório !!!")]
        [StringLength(100, ErrorMessage = "O Campo {0} deve ter entre {2} e {1} caracteres...", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório !!!")]
        [StringLength(14, ErrorMessage = "O Campo {0} deve ter entre {2} e {1} caracteres...", MinimumLength = 11)]
        public string Documento { get; set; }

        public TipoFornecedor TipoFornecedor { get; set; }

        public Endereco Endereco { get; set; }

        [DisplayName("Ativo ?")]
        public bool Ativo { get; set; }
        
        //EF Relations
        public IEnumerable<Produto> Produtos { get; set; }
    }
}
