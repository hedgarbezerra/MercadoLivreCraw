using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLCrawler.Domain.Models
{
    public class Produto
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int Vendidos { get; set; }
    }
}
