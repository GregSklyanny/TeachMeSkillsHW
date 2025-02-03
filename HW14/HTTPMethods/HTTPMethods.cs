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
            string content;
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                content = await response.Content.ReadAsStringAsync();
            }
            return content;
        }
        public static async Task<string> Post(string url, HttpContent contentToPost)
        {
            string content;
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(url, contentToPost);
                content = await response.Content.ReadAsStringAsync();
            }
            return content;
        }
        public static async Task<string> Put(string url, HttpContent contentToPost)
        {
            string content;
            using (var client = new HttpClient())
            {
                var response = await client.PutAsync(url, contentToPost);
                content = await response.Content.ReadAsStringAsync();
            }
            return content;
        }
        public static async Task<string> Patch(string url, HttpContent contentToPost)
        {
            string content;
            using (var client = new HttpClient())
            {
                var response = await client.PatchAsync(url, contentToPost);
                content = await response.Content.ReadAsStringAsync();
            }
            return content;
        }
        public static async Task<string> Delete(string url)
        {
            string content;
            using (var client = new HttpClient())
            {
                var response = await client.DeleteAsync(url);
                content = await response.Content.ReadAsStringAsync();
            }
            return content;
        }
    }
}
