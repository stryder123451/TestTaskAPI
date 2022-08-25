using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskAPI.Interfaces;
using TestTaskAPI.Models;

namespace TestTaskAPI.Services
{
    public class RGDialogService : IRGDialog
    {
        public async Task<List<Guid>> FindAllChats(List<Guid> Clients)
        {
            var dialogsList = await GetListOfDialogs();
            var resultList = new List<Guid>();
            for (int i = 0; i < dialogsList.Count; i++)
            {
                foreach (var x in Clients)
                {
                    if (x == dialogsList[i].IDClient)
                    {
                        resultList.Add(dialogsList[i].IDRGDialog);
                    }
                }
            }
            return resultList;
            
        }

        public async Task<List<RGDialogsClients>> GetListOfDialogs()
        {
            RGDialogsClients dialogsClients = new RGDialogsClients();
            return await Task.FromResult(dialogsClients.Init());
        }
    }
}
