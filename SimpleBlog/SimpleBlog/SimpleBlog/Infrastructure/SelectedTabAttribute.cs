using System;
using System.Web.Mvc;

namespace SimpleBlog.Infrastructure
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class SelectedTabAttribute : ActionFilterAttribute
    {
        private readonly string _sectedTab;

        public SelectedTabAttribute(string selectedTab)
        {
            _sectedTab = selectedTab; 
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.Controller.ViewBag.SelectedTab = _sectedTab;
        }
    }
}