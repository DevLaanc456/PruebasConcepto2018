using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using PruebaMVC.Alerts; 

namespace Extension.Helpers
{
    public static class BotonModal
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_htmlhelper"></param>
        /// <param name="text"></param>
        /// <param name="title"></param>
        /// <param name="action"></param>
        /// <param name="controller"></param>
        /// <param name="routevalues"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static MvcHtmlString NoEncodeActionLink(this HtmlHelper _htmlhelper,
                                                       string text,
                                                       string title,
                                                       string action,
                                                       string controller,
                                                       object routevalues,
                                                       object htmlAttributes = null)
        {
            UrlHelper _urlhelper = new UrlHelper(_htmlhelper.ViewContext.RequestContext);
            TagBuilder _tagbuilder = new TagBuilder("a");
            _tagbuilder.InnerHtml = text;
            _tagbuilder.Attributes["title"] = title;
            _tagbuilder.Attributes["type"] = "submit";
            _tagbuilder.Attributes["href"] = _urlhelper.Action(action, controller, routevalues);
            _tagbuilder.MergeAttributes(new RouteValueDictionary(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes)));

            return MvcHtmlString.Create(_tagbuilder.ToString());

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_htmlhelper"></param>
        /// <param name="text"></param>
        /// <param name="title"></param>
        /// <param name="ruta"></param>
        /// <param name="routevalues"></param>
        /// <param name="htmlattributes"></param>
        /// <returns></returns>
        public static MvcHtmlString BotonEjemplo(this HtmlHelper _htmlhelper, 
                                                 string text, 
                                                 string title, 
                                                 string ruta, 
                                                 object routevalues = null, 
                                                 object htmlattributes= null)
        {
             UrlHelper _urlhelper = new UrlHelper(_htmlhelper.ViewContext.RequestContext);
             TagBuilder _tagbuilder = new TagBuilder("a");
            _tagbuilder.InnerHtml = text;
            _tagbuilder.Attributes["title"] = title;
            _tagbuilder.Attributes["type"] = "submit";
            _tagbuilder.Attributes["href"] = ruta;
            _tagbuilder.MergeAttributes(new RouteValueDictionary(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlattributes)));

            return MvcHtmlString.Create(_tagbuilder.ToString());

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ajaxHelper"></param>
        /// <param name="linktext"></param>
        /// <param name="actionName"></param>
        /// <param name="controllerName"></param>
        /// <param name="routevalues"></param>
        /// <param name="ajaxOptions"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static MvcHtmlString RawActionLink(this AjaxHelper ajaxHelper, 
                                                  string linktext, 
                                                  string actionName, 
                                                  string controllerName, 
                                                  object routevalues, 
                                                  AjaxOptions ajaxOptions, 
                                                  object htmlAttributes)
        {
            var repID = Guid.NewGuid().ToString();
            var lnk = ajaxHelper.ActionLink(repID, actionName, controllerName, routevalues, ajaxOptions, htmlAttributes);
            return MvcHtmlString.Create(lnk.ToString().Replace(repID, linktext));
        }

    }


    public static class AlertHelper
    {
        public static Alert Alert(this HtmlHelper html, 
                                  string message)
        {
            return new Alert(message);

        }

    }



}