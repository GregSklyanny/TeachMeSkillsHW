using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTPMethods
{
    public class HTTPMethods
    {
        public static async Task<string> Get(string url)
        {
            using var client = new HttpClient() ;
            var response = await client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }
        public static async Task<string> Post(string url, HttpContent contentToPost)
        {
            using var client = new HttpClient();
            var response = await client.PostAsync(url, contentToPost);
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }
        public static async Task<string> Put(string url, HttpContent contentToPost)
        {
            using var client = new HttpClient();
            var response = await client.PutAsync(url, contentToPost);
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }
        public static async Task<string> Patch(string url, HttpContent contentToPost)
        {
            using var client = new HttpClient();
            var response = await client.PatchAsync(url, contentToPost);
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }
        public static async Task<string> Delete(string url)
        {
            using var client = new HttpClient();
            var response = await client.DeleteAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }
    }
}
