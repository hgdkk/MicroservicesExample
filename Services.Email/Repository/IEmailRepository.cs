using Services.Email.Messages;
using Services.Email.Models;

namespace Services.Email.Repository
{
    public interface IEmailRepository
    {
        Task SendAndLogEmail(UpdatePaymentResultMessage message);
    }
}
