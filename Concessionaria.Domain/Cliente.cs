using System;
using System.Collections.Generic;
using System.Text;
using Concessionaria.Domain.Base;

namespace Concessionaria.Domain
{
    public class Cliente : BaseEntity
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public List<Venda> Vendas { get; set; } = new List<Venda>();
    }
}