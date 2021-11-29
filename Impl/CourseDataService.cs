using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using LoginExample.Pages;
using Course = LoginExample.Models.Course;

namespace LoginExample.Data.Impl
{
    public class CourseDataService : CourseData
    {
        
        public async Task<IList<Course>> getAllCourses(string courseName)
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
        
        
        public async Task<IList<Announcement>> getAllAnnouncement(string courseName)
        {
            using HttpClient client = new HttpClient();
            Task<string> stringAsync = client.GetStringAsync($"http://localhost:8080/getAnnouncement?courseName={courseName}");
            string message = await stringAsync;
            IList<Announcement> result = JsonSerializer.Deserialize<List<Announcement>>(message, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return result;
        }
        
        
    }
}