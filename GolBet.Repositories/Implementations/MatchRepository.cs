using GolBet.Entities.Enums;
using Microsoft.EntityFrameworkCore;

public async Task<IEnumerable<Match>> GetAllWithTeamsAsync(MatchStatus? status = null, string? search = null)
{
    var query = _dbSet
        .Include(m => m.HomeTeam)
        .Include(m => m.AwayTeam)
        .Where(m => m.IsActive)
        .AsNoTracking()
        .AsQueryable();

    if (status.HasValue)
        query = query.Where(m => m.Status == status.Value);

    if (!string.IsNullOrWhiteSpace(search))
    {
        var term = search.Trim().ToLower();
        query = query.Where(m =>
            m.HomeTeam.Name.ToLower().Contains(term) ||
            m.AwayTeam.Name.ToLower().Contains(term));
    }

    return await query.OrderBy(m => m.Date).ToListAsync();
}