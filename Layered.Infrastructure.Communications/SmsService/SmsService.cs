using Layered.Infrastructure.Communications.SmsService.Models;

namespace Layered.Infrastructure.Communications.SmsService;

/// <summary>
/// https://github.com/OrchardCMS/OrchardCore/tree/64529e917f7a6f20bd8c8227ea771263e53f8935/src/OrchardCore/OrchardCore.Sms.Core
/// TODO: SMS Genişletilecek twilio vs implement edilecek
/// </summary> <summary>
/// 
/// </summary>
public class SmsService : ISmsService
{

    public async Task<SmsResult> SendAsync(SmsMessage message)
    {
        return null;
    }
}