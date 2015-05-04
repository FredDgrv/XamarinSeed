using System;
using System.Net.Http;
using ModernHttpClient;

namespace XamarinSeed
{
    public class ModernHttpClient
    {
        public static HttpClient CreateHttpClient()
        {
            return new HttpClient(new NativeMessageHandler());
        }
    }
}

