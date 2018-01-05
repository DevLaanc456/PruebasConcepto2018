using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaMVC.Alerts
{
    public class AlertFluent : IAlertFluent
    {

        private readonly Alert _parent;

        public AlertFluent(Alert parent)
        {
            _parent = parent;

        }

        public IAlertFluent Dismissible(bool canDismiss = true)
        {
            return _parent.Dismissible(canDismiss);
        }

        public string ToHtmlString()
        {
            return _parent.ToHtmlString();
        }
    }



    public class Alert : IAlert
    {
        AlertStyle _style;
        bool _dismissible;
        string _message;

        public Alert(string message)
        {
            _message = message;
        }


        public IAlertFluent Danger()
        {
            _style = AlertStyle.Danger;
            return new AlertFluent(this);
        }

        public IAlertFluent Dismissible(bool canDismiss = true)
        {
            this._dismissible = canDismiss;
            return new AlertFluent(this);
        }

        public IAlertFluent Info()
        {
            _style = AlertStyle.Info;
            return new AlertFluent(this);
        }

        public IAlertFluent Success()
        {
            _style = AlertStyle.Success;
            return new AlertFluent(this);
        }

        public string ToHtmlString()
        {
            var alertDiv = new TagBuilder("div");
            alertDiv.AddCssClass("alert");
            alertDiv.AddCssClass("alert-" + _style.ToString().ToLower());
            alertDiv.InnerHtml = _message;

            if (_dismissible)
            {
                alertDiv.AddCssClass("alert-dismissible");
                alertDiv.InnerHtml += AddCloseButton();
            }

            return alertDiv.ToString();

        }

        public static TagBuilder AddCloseButton()
        {
            var closebutton = new TagBuilder("button");
            closebutton.AddCssClass("close");
            closebutton.Attributes.Add("data-dismiss", "alert");
            closebutton.InnerHtml = "&times;";
            return closebutton;
        }

        public IAlertFluent Warning()
        {
            _style = AlertStyle.Warning;
            return new AlertFluent(this);
        }
    }

    
}