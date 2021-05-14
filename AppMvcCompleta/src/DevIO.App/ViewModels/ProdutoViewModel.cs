﻿using DevIO.App.Extensions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevIO.App.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Fornecedor")]
        [Required(ErrorMessage = "O Campo {0} é obrigatório !!!")]
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório !!!")]
        [StringLength(200, ErrorMessage = "O Campo {0} deve ter entre {2} e {1} caracteres...", MinimumLength = 2)]
        public string Nome { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "O Campo {0} é obrigatório !!!")]
        [StringLength(1000, ErrorMessage = "O Campo {0} deve ter entre {2} e {1} caracteres...", MinimumLength = 2)]
        public string Descricao { get; set; }

        public string Imagem { get; set; }

        [DisplayName("Imagem do Produto")]
        public IFormFile ImagemUpload { get; set; }

        [Moeda]
        [Required(ErrorMessage = "O Campo {0} é obrigatório !!!")]
        public decimal Valor { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("Data de Cadastro")]
        public DateTime DataCadastro { get; set; }

        [DisplayName("Ativo ?")]
        public bool Ativo { get; set; }

        //EF Relation
        public FornecedorViewModel Fornecedor { get; set; }
        public IEnumerable<FornecedorViewModel> Fornecedores { get; set; }
    }
}
