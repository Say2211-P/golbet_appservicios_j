using GolBet.Entities.Enums;

namespace GolBet.Services.DTOs;

public class MatchDto
{
    public int Id { get; set; }
    public DateTime Date { get; set; } // UTC; la vista convierte
    public MatchStatus Status { get; set; }

    // Aplanado desde Match.HomeTeam / Match.AwayTeam (convención de AutoMapper)
    public string HomeTeamName { get; set; } = null!;
    public string? HomeTeamCrestUrl { get; set; }
    public string AwayTeamName { get; set; } = null!;
    public string? AwayTeamCrestUrl { get; set; }

    public int? HomeGoals { get; set; }
    public int? AwayGoals { get; set; }

    public decimal HomeOdds { get; set; }
    public decimal DrawOdds { get; set; }
    public decimal AwayOdds { get; set; }
}