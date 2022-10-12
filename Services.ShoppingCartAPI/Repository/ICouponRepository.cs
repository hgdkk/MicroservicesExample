using Services.ShoppingCartAPI.Models.Dto;

namespace Services.ShoppingCartAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponDto> GetCoupon(string couponName);
    }
}
