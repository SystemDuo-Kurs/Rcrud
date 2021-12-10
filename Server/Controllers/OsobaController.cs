using Microsoft.AspNetCore.Mvc;
using Rcrud.Shared;

namespace Rcrud.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OsobaController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly Db _db;
        public OsobaController(ILogger<OsobaController> log, Db db)
        {
            _logger = log;
            _db = db;
        }

        [HttpGet]
        public List<Osoba> PosaljiOsobe()
            => _db.Osobas.ToList();

        [HttpDelete]
        public void Brisanje()
        {
            _logger.LogWarning("Brisem osobu iz kontrolera");           
            //_db.Remove(o);
            //_db.SaveChanges();
        }
    }
}
