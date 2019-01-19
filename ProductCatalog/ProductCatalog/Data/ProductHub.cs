using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalog.Data
{
    public class ProductHub : Hub
    {
        public async Task SendNewProduct()
        {
            
            await Clients.All.SendAsync("ReceiveNewProduct");
        }
    }
}
