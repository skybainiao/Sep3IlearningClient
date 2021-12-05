using System.Collections.Generic;
using System.Threading.Tasks;
using LoginExample.Models;
using LoginExample.Pages;
using Course = LoginExample.Models.Course;

namespace LoginExample.Data
{
    public interface CourseData
    {
        Task<IList<Course>> getAllCourses(string courseName);

        Task<IList<Announcement>> getAllAnnouncement(string courseName);

        Task addCourse(Course course);

        Task addAnnouncement(Announcement announcement);

        Task<IList<Announcement>> getAnnouncements();
    }
}