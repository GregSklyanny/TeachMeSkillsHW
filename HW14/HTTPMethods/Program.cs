using System.Net.Sockets;

namespace HTTPMethods
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var content = new StringContent("This is my content");
            
            Console.WriteLine(await HTTPMethods.Get("https://httpbin.org/"));
            Console.WriteLine(await HTTPMethods.Post("https://httpbin.org/post", content));
            Console.WriteLine(await HTTPMethods.Put("https://httpbin.org/put", content));
            Console.WriteLine(await HTTPMethods.Patch("https://httpbin.org/patch", content));
            Console.WriteLine(await HTTPMethods.Delete("https://httpbin.org/delete"));
        }
    }
}
