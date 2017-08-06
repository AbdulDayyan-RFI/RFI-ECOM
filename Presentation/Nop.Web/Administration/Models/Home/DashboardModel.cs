using Nop.Web.Framework.Mvc;

namespace Nop.Admin.Models.Home
{
    public partial class DashboardModel : BaseNopModel
    {
        public bool IsLoggedInAsVendor { get; set; }
        public int ActiveShoppingCart { get; set; }
        public int Orders { get; set; }
        public int ExchangeOrReturn { get; set; }
        public int AbandonedCarts { get; set; }
        public int OutOfStock { get; set; }
        public int NewMessages { get; set; }
        public int NewCustomers { get; set; }
        public int NewSubscription { get; set; }
        public int TotalSubscription { get; set; }

    }
}