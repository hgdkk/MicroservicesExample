using WebSite.Models;

namespace WebSite.Services.Abstract
{
    public interface ICouponService
    {        
        Task<T> GetCoupon<T>(string couponCode, string token = null);
    }
}
