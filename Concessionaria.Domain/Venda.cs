using System;
using System.Collections.Generic;
using System.Text;
using Concessionaria.Domain.Base;

namespace Concessionaria.Domain
{
    public class Venda : BaseEntity
    {
        public int CarroId { get; set; }
        public Carro Carro { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int VendedorId { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal Valor { get; set; }
    }
}