using System.Net;

namespace email.Configuration
{
    public interface ISmtpConfig
    {
        string Host { get; set; }
        int Port { get; set; }
        ICredentialsByHost Credentials { get; set; }
    }
}