using Microsoft.EntityFrameworkCore;
using MitDataoverblik.Data;
using MitDataoverblik.Models;

namespace MitDataoverblik.Services
{
    public class BorgerService
    {
        private readonly IDbContextFactory<AppDbContext> _dbFactory;
        public BorgerService(IDbContextFactory<AppDbContext> dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<Borger?> HentBorgerAsync(int id)
        {
            using var db = await _dbFactory.CreateDbContextAsync();

            return await db.Borgere
                .AsNoTracking()
                .FirstOrDefaultAsync(b => b.Id == id);

        }
    }
}
