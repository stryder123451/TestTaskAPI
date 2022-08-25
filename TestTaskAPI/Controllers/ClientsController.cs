using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskAPI.Interfaces;
using TestTaskAPI.Models;

namespace TestTaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ClientsController : ControllerBase
    {
        private readonly IRGDialog _dialogService;
        public ClientsController(IRGDialog dialogService)
        {
            _dialogService = dialogService;
        }


        [HttpPost]
        public async Task<List<Guid>> FindAllDialogs(List<Guid> clients)
        {
            var res = await _dialogService.FindAllChats(clients);
            if (res==null)
            {
                throw new Exception();
            }
            else
            {
                return res;
            }
        }
    }
}
