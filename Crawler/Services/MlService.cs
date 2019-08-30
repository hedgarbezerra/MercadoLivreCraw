using MLCrawler.Domain.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.Services
{
    public class MlService
    {
        WebClient wCliente = new WebClient();

        public Carro getCarro(string pesquisa)
        {

            string pesquisaArg = pesquisa.Replace(" ", "-");

            string baseLink = "https://carros.mercadolivre.com.br/@_OrderId_PRICE";

            string actualLink = baseLink.Replace("@", pesquisaArg);

            wCliente.Headers.Add("User-Agent:Other");
            wCliente.Encoding = System.Text.Encoding.UTF8;

            var data = wCliente.DownloadString(actualLink);

            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(data);

            var pagina = document.DocumentNode.SelectNodes("//ol[@id='searchResults']/li");

            var imagem = pagina[0].ChildNodes[1].ChildNodes[0].ChildNodes[1].ChildNodes[0].ChildNodes[1].ChildNodes[1].ChildNodes[1].ChildNodes[1].OuterHtml;  
            var link = pagina[1].ChildNodes[1].ChildNodes[3].OuterHtml;
            string preco = pagina[0].ChildNodes[1].ChildNodes[3].ChildNodes[1].ChildNodes[0].InnerText;
            var arrayAnoKm = pagina[0].ChildNodes[1].ChildNodes[3].ChildNodes[1].ChildNodes[2].InnerText.Split('|');
            string ano = arrayAnoKm[0];
            string km = arrayAnoKm[1];
            string nome = pagina[0].ChildNodes[1].ChildNodes[3].ChildNodes[1].ChildNodes[3].InnerText;
            decimal valor = Convert.ToDecimal(preco, new CultureInfo("pt-BR"));

            Carro carro = new Carro { Valor = valor, Ano = ano, KM = km, Nome = nome, Link = link, Imagem=imagem};

            return carro;
        }
        
        public List<Moeda> GetCotacaoMoedas()
        {
            WebClient webClient = new WebClient();

            webClient.Headers.Add("User-Agent: Other");
            webClient.Encoding = System.Text.Encoding.UTF8;
            string pagina = webClient.DownloadString("https://economia.uol.com.br/");

            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(pagina);


            List<Moeda> listaMoeda = new List<Moeda>();

            var cotacaoDolar = document.DocumentNode.SelectNodes("//div[@class='hidden-xs']/h3[@class='tituloGrafico']");

            string nomeMoeda = cotacaoDolar[0].ChildNodes[0].ChildNodes[0].InnerText;
            var valorItem = item.ChildNodes[2].ChildNodes[0].InnerHtml.ToString().Replace("US$", "").Replace("R$", "");

            var valor = Convert.ToDecimal(valorItem, new CultureInfo("pt-BR"));


            listaMoeda.Add(new Moeda { Nome = "Dólar Comercial", Valor = valor });


            var moedas = document.DocumentNode.SelectNodes("//table[@class='data-table tableMoedas']/tbody/tr[@class='linhaDados']");

            foreach (var item in moedas)
            {
                if (!item.ChildNodes[0].ChildNodes[0].InnerHtml.Contains("Dólar"))
                {
                    nomeMoeda = item.ChildNodes[0].ChildNodes[0].InnerHtml;
                    valorItem = item.ChildNodes[2].ChildNodes[0].InnerHtml;
                    var valorr = Convert.ToDecimal(valorItem.Replace("R$", ""), new CultureInfo("pt-BR"));

                    listaMoeda.Add(new Moeda { Nome = nomeMoeda, Valor = valorr });
                }
            }
            return listaMoeda;
        }
    }
}
