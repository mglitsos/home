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

                List<string[]> records = new List<string[]>();
                using (var parser = new CsvParser(reader))
                {
                    while (true)
                    {
                        var row = parser.Read();
                        if (row == null)
                            break;
                        records.Add(row);
                    }
                }

                reader.Close();

                foreach (string[] record in records)
                {
                    for (int i = 0; i < record.Length; i++)
                        Console.Write(record[i] + Environment.NewLine);
                    Console.Write(Environment.NewLine + Environment.NewLine);
                }
                Console.ReadLine();
            }
        }
    }
}
