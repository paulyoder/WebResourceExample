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
            Response.Redirect(styleUrl);
        }
    }
}
