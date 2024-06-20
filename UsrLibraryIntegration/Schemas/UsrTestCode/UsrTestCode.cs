using System;
using System.Net.Http;
using System.Threading.Tasks;

public class UsrTestCode
{
    public async Task<string> GetExampleAsync(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            // Set a base address if you have one
            client.BaseAddress = new Uri(url);

            // Set any necessary headers
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            // Send the GET request
            HttpResponseMessage response = await client.GetAsync(url);

            // Check the response status code
            if (response.IsSuccessStatusCode)
            {
                // Read and return the content
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            else
            {
                throw new HttpRequestException($"Request failed with status code {response.StatusCode}");
            }
        }
    }
}