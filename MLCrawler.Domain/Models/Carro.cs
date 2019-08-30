using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLCrawler.Domain.Models
{
    public class Carro
    {
        public string Nome { get; set; }
        public string Ano { get; set; }
        public decimal Valor { get; set; }
        public string Link { get; set; }
        public string KM { get; set; }
        public string Imagem { get; set; }
    }
}
