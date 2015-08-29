using System.Net;

namespace email.Configuration
{
    public interface ISmtpConfig
    {
        string Host { get; }
        int Port { get; }
        ICredentialsByHost Credentials { get; }
    }
}