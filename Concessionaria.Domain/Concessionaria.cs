using System;
using System.Collections.Generic;
using System.Text;
using Concessionaria.Domain.Base;
using System.Collections.Generic;

namespace Concessionaria.Domain
{
    public class Concessionaria : BaseEntity
    {
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public List<Carro> Carros { get; set; } = new List<Carro>();
    }
}