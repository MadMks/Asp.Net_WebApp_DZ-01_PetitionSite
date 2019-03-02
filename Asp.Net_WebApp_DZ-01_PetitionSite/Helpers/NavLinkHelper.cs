using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Asp.Net_WebApp_DZ_01_PetitionSite.Helpers
{
    public static class NavLinkHelper
    {
        public static MvcHtmlString MainNavLink(
            this HtmlHelper html,
            string linkText,
            string actionName,
            string controllerName)
        {
            //TagBuilder a = new TagBuilder("a");
            //a.AddCssClass("nav-link");
            //a.MergeAttribute("href", "/" + controllerName + "/" + actionName);
            //a.SetInnerText(linkText);
            
            //return new MvcHtmlString(a.ToString());
            return html.ActionLink(linkText, actionName, controllerName,
                                new { area = "" }, new { @class = "nav-link" }
                                );
        }
    }
}