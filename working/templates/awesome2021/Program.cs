using System;
using System.Threading.Tasks;

namespace awesome2021
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var wb = new WordsBank();

            await Console.Out.WriteLineAsync(wb.y2020);
            await Console.Out.WriteLineAsync(wb.y2021);
        }
    }
}
