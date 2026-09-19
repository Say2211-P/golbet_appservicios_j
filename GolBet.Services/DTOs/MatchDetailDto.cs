using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolBet.Services.DTOs;

public class MatchDetailDto : MatchDto
{
    public int TotalBets { get; set; }
}