using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskAPI.Models;

namespace TestTaskAPI.Interfaces
{
    public interface IRGDialog
    {
        Task<List<Guid>> FindAllChats(List<Guid> Clients);
        Task<List<RGDialogsClients>> GetListOfDialogs(); 
    }
}
