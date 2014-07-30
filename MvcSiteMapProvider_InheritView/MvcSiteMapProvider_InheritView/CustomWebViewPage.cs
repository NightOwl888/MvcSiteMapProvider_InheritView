using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSiteMapProvider_InheritView
{
    public class CustomWebViewPage<TModel>
        : WebViewPage<TModel>
    {
        public override void Execute()
        {
            // Do nothing.
        }
    }
}