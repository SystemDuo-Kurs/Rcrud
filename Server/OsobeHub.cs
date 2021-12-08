using Microsoft.AspNetCore.SignalR;
using Rcrud.Shared;

namespace Rcrud.Server
{
    public class OsobeHub : Hub
    {
        private readonly Db _db;
        private readonly ILogger _logger;
        public OsobeHub(Db db, ILogger<OsobeHub> logger)
        {
            _db = db;
            _logger = logger;
        }
        public void Unos(Osoba o)
        {
            _logger.LogInformation($"{o.Name} {o.Surname}");
            _db.Add(o);
            _db.SaveChanges();
            Posalji();
        }
        public async void Posalji()
        {
            _logger.LogInformation($"Saljem ka klijentu");
            await Clients.All.SendAsync("slanje", _db.Osobas.ToList());
        }
    }
}
