using Quiron.LojaVirtual.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.HtmlHelpers
{
    public static class PaginacaoHelpers
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html, Paginacao paginacao, Func<int, string> paginaUrl) {

            StringBuilder sbResultado = new StringBuilder();

            for (int i = 1; i <= paginacao.TotalDePaginas; i++)
            {
                TagBuilder tag = new TagBuilder("a");

                tag.MergeAttribute("href", paginaUrl(i));
                tag.InnerHtml = i.ToString();

                if (i == paginacao.PaginaAtual)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }
                tag.AddCssClass("btn-default");
                sbResultado.Append(tag);

            }
            return MvcHtmlString.Create(sbResultado.ToString());

        }

    }
}