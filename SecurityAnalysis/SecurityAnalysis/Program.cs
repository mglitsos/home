using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using CsvHelper;
using System.IO;

namespace SecurityAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {

            var request = WebRequest.Create("https://financials.morningstar.com/ajax/exportKR2CSV.html?&callback=?&t=XNAS:AAPL&region=usa&culture=en-US&cur=USD&order=");
            var response = request.GetResponse();

            using (var dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                CsvParser parser = new CsvParser(reader);

                reader.Close();

            }
        }
    }
}
