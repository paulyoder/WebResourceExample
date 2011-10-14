using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

[assembly: WebResource("WebResources.Styles.ResourceStyle.css", "text/css")]
namespace WebResources
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var styleUrl = Page.ClientScript.GetWebResourceUrl(this.GetType(), "WebResources.Styles.ResourceStyle.css");
            //var styleUrl = "/Styles/ResourceStyle.css";
            var attribute = string.Format("<link href='{0}' type='text/css' rel='stylesheet' />", styleUrl);
            var include = new LiteralControl(attribute);
            ((System.Web.UI.HtmlControls.HtmlHead)Page.Header).Controls.Add(include);
        }
    }
}
