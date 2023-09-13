using Microsoft.AspNetCore.Mvc;

namespace AlteCashIdentityProject.Presentation.Layer.ViewComponents.Customer
{
    public class _CustomerLayoutFooterPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
