using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class TournamentDTO
{
    #region Variables
    public int id;
    public int rounds;
    public int teamNumber;
    public int[] teamGroup;
    public int tournamentNameID;    
    public int[] tournamentTeamsFederations;    
    public bool isQualifing;
    #endregion
}
