using Microsoft.AspNetCore.SignalR;

namespace Rcrud.Server
{
    public class OsobeHub : Hub
    {
        public void Ping()
            => Console.WriteLine("pong");
    }
}
