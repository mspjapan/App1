using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;


namespace App1
{
    class HttpClientBasic
    {
        private HttpClient client;
        public void Initialize(string url)
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000; // Bufferサイズ　場合によっては要調整
            client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)");
        }
    }
}
