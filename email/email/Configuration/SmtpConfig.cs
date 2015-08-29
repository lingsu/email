using System.Net;

namespace email.Configuration
{
    public class SmtpConfig: ISmtpConfig
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public ICredentialsByHost Credentials { get; set; }

        public SmtpConfig() : this("localhost")
        {
        }

        public SmtpConfig(string host) : this(host, 587)
        {
            
        }

        public SmtpConfig(string host, int port) : this(host, port, CredentialCache.DefaultNetworkCredentials)
        {
            
        }
        public SmtpConfig(string host, int port, ICredentialsByHost credentials)
        {
            Host = host;
            Port = port;
            Credentials = credentials;
        }
    }
}