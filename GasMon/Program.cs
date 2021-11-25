using System;
using Amazon.Runtime;
using Amazon.S3;
using static GasMon.S3Helper.S3Helper;

namespace GasMon
{
    class Program
    {

        public static void Main()
        {
            Console.WriteLine("Hello World!");
            ReadObjectDataAsync().Wait();
        }
        
    }
}