using System;
using System.Collections.Generic;
using System.Text;
using Concessionaria.Domain.Base;

namespace Concessionaria.Domain
{
    public class Carro : BaseEntity
    {
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }
        public int ConcessionariaId { get; set; }
        public Concessionaria Concessionaria { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public decimal Preco { get; set; }
        public bool Disponivel { get; set; }
    }
}