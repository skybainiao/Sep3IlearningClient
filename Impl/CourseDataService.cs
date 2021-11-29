using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using LoginExample.Models;

namespace LoginExample.Data.Impl
{
    public class CourseDataService : CourseData
    {
        
        public async Task<IList<Course>> getAllUsers(string courseName)
        {
            using HttpClient client = new HttpClient();
            Task<string> stringAsync = client.GetStringAsync($"http://localhost:8080/getCourses?courseName={courseName}");
            string message = await stringAsync;
            IList<Course> result = JsonSerializer.Deserialize<List<Course>>(message, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return result;
        }
        
        
    }
}