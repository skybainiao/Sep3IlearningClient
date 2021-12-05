using System.Collections.Generic;
using System.Threading.Tasks;
using LoginExample.Models;

namespace LoginExample.Data
{
    public interface LecturerData
    {

        Task<IList<LecturerAccount>> getLecturer();

    }
}