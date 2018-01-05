using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PruebaMVC.Alerts
{
    public interface IAlertFluent: IHtmlString
    {
        IAlertFluent Dismissible(bool canDismiss = true);
    }

    public interface IAlert : IAlertFluent
    {
        IAlertFluent Danger();

        IAlertFluent Info();

        IAlertFluent Success();

        IAlertFluent Warning();

    }


}
