using System;
using System.Collections.Generic;
using System.Text;
using Concessionaria.Domain.Base;

namespace Concessionaria.Domain
{
    public class Marca : BaseEntity
    {
        public string Nome { get; set; }
        public string PaisOrigem { get; set; }
        public List<Carro> Carros { get; set; } = new List<Carro>();
    }
}