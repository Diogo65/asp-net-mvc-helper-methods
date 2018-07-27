using HelperMethods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelperMethods.Infraestrutura
{
    public static class CustomHelpers
    {
        //criação de uma biblioteca de métodos úteis pessoal, para ser utilizada ao longo de vários projetos.

        public static MvcHtmlString ListarItens(this HtmlHelper html, List<Produto> list)
        {
            //TagBuilder.Essa classe serve para, como o nome sugere, a construção de tags HTML
           TagBuilder tagFinal = new TagBuilder("div");

            foreach (Produto item in list)
            {
                TagBuilder tag1 = new TagBuilder("h3");
                //Estamos definindo o texto interno das tags<h> como sendo os valores das propriedades do produto.
               tag1.SetInnerText(item.Nome);
                TagBuilder tag2 = new TagBuilder("h4");
                tag2.SetInnerText(item.Valor.ToString());
                TagBuilder tag3 = new TagBuilder("h5");
                tag3.SetInnerText(item.Descricao);
                //estamos passando para o HTML interno do < div > o texto das tags internas recém criadas, que contém os dados.                 //estamos passando para o HTML interno do < div > o texto das tags internas recém criadas, que contém os dados. 
                tagFinal.InnerHtml += tag1.ToString();
                tagFinal.InnerHtml += tag2.ToString();
                tagFinal.InnerHtml += tag3.ToString();
            }

            //estamos retornando um objeto do tipo MvcHtmlString com a tag<div> e todo o seu conteúdo.
            return new MvcHtmlString(tagFinal.ToString());
        }
    }
 }