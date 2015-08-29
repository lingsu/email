using System;
using System.Collections.Generic;
using System.Net;
using email.Delivery;
using email.Providers;
using email.Templates;

namespace email.Sample
{
    class Program
    {
        static void Main(string[] args)
        {

            IEmailProvider ep = new SmtpEmailProvider("smtp.qq.com", 25, new NetworkCredential("570678569", "q284655"));
            IEmailTemplateEngine tn = new DotLiquidEmailTemplateEngine();
            IDeliveryConfiguration dc = new DeliveryConfiguration();

            DeliveryService service = new DeliveryService(ep, dc);

            var tos = new List<string>()
            {
                "q25a25q@live.com",
                "570678569@qq.com"
            };
            var message = tn.CreateTextEmail("用户{{ UserName }}兑换了 aa，请及时处理!", new { UserName = "自定义数据", From = "570678569@qq.com", To = "q25a25q@live.com", Subject = "邮件主题" });
            message.Cc = tos;
            ep.Send(message);

            service.Start();

            service.Send(message);

            Console.WriteLine("success ");
            Console.Read();
            service.Stop();
        }
    }
}
