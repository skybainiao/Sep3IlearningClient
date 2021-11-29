using System.Collections.Generic;
using System.Threading.Tasks;
using LoginExample.Models;

namespace LoginExample.Data
{
    public interface CourseData
    {
        Task<IList<Course>> getAllUsers(string courseName);
    }
}