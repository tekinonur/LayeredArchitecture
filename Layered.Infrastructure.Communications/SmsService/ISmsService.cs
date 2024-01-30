using Layered.Infrastructure.Communications.SmsService.Models;

namespace Layered.Infrastructure.Communications.SmsService;

public interface ISmsService
{
    Task<SmsResult> SendAsync(SmsMessage message);
}
