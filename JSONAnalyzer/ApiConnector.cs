using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JSONAnalyzer
{
    class ApiConnector
    {

        public string getApiResponse(string url)
        {
            WebRequest request = WebRequest.Create(url);
            request.Method = "GET";
            WebResponse response = request.GetResponse();
            Stream data = response.GetResponseStream();
            int c = 0;
            string results = "";
            do
            {
                c= data.ReadByte();
                results += ((char)c);

            }
            while (c != -1);
            return results;
        }
    }
}
