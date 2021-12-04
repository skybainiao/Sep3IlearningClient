using System.Collections.Generic;
using System.Threading.Tasks;
using LoginExample.Models;

namespace LoginExample.Data
{
    public interface GroupData
    {
        Task<IList<Group>> getAllGroups();

        Task<IList<string>> getAllGroupName();

        Task<IList<string>> getAllGroupMember(string username);
    }
}