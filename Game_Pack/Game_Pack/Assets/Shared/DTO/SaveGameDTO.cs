using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[System.Serializable]
public class SaveGameDTO
{
    #region Variables
    public int id;
    public int idGameMode;
    public string dateTimeNow;
    public int tournamentID;
    public int currentRound;
    public int rounds;    
    public int teamPlayerID;
    public int currentLevel;    
    public bool isTournamentFinished;    
    public int currentYear;
    public int currentYearCycle;
    public int currentTournamentIndex;
    public List<List<int>> qualifiedTeams;
    #endregion
}
