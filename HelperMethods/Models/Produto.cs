using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelperMethods.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}