using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class General {
    #region variables    
    public enum GameModesEnum {
        Friendly = 0,
        Trainning = 1,
        Tournaments = 2,
        Seasons = 3,
        Podium = 4,
        PodiumSeason = 5,
        Tutorial = 6
    };
    private static GameModesEnum gameMode = GameModesEnum.Friendly;
	public static GameModesEnum GetGameMode()
	{		
		return gameMode;		
	}
    public static void SetGameMode(GameModesEnum value)
    {
        gameMode = value;
    }    
    public enum PL_CPUEnum {
        PL_CPU = 0,
        CPU_CPU = 1
    }
    private static PL_CPUEnum pL_CPU = PL_CPUEnum.PL_CPU;
    public static PL_CPUEnum GetPL_CPU()
    {
        return pL_CPU;
    }
    public static void SetPL_CPU(PL_CPUEnum value)
    {
        pL_CPU = value;
    }
    private static int team1P = 0;
    public static int getSetTeam1P
    {
        get
        {
            return team1P;
        }
        set
        {
            team1P = value;
        }
    }    
    private static int team2P = 1;
    public static int getSetTeam2P
    {
        get
        {
            return team2P;
        }
        set
        {
            team2P = value;
        }
    }    
    private static int team1Pscore = 0;
    public static int getSetTeam1Pscore
    {
        get
        {
            return team1Pscore;
        }
        set
        {
            team1Pscore = value;
        }
    }
    private static int team2Pscore = 0;
    public static int getSetTeam2Pscore
    {
        get
        {
            return team2Pscore;
        }
        set
        {
            team2Pscore = value;
        }
    }    
    private static Color team1Pjersey;
    public static Color GetSetTeam1Pjersey
    {
        get
        {
            return team1Pjersey;
        }
        set
        {
            team1Pjersey = value;
        }
    }    
    private static Color team1Pshort;
    public static Color GetSetTeam1Pshort
    {
        get
        {
            return team1Pshort;
        }
        set
        {
            team1Pshort = value;
        }
    }    
    private static Color team2Pjersey;
    public static Color GetSetTeam2Pjersey
    {
        get
        {
            return team2Pjersey;
        }
        set
        {
            team2Pjersey = value;
        }
    }    
    private static Color team2Pshort;
    public static Color GetSetTeam2Pshort
    {
        get
        {
            return team2Pshort;
        }
        set
        {
            team2Pshort = value;
        }
    }    
    private static TeamDTO[] teams;
    public static TeamDTO[] GetSetTeams
    {
        get
        {
            return teams;
        }
        set
        {
            teams  = value;
        }
    }    
    private static ConfigDTO config;
    public static ConfigDTO GetSetConfig
    {
        get
        {
            return config;
        }
        set
        {
            config = value;
        }
    }
    private static List<TournamentDTO> tournament;
    public static List<TournamentDTO> GetSetTournament
    {
        get
        {
            return tournament;
        }
        set
        {
            tournament = value;
        }
    }
    private static int tournamentID;
    public static int GetSetTournamentID {
        get
        {
            return tournamentID;
        }
        set
        {
            tournamentID = value;
        }
    }
    public enum GamePlayStatesEnum
    {
        NewGame = 0,
        BackToTournamentSeason = 1,
        LoadGame = 2,
        BackToSeasonCeremony = 3
    };
    private static GamePlayStatesEnum gamePlayStates = GamePlayStatesEnum.NewGame;
    public static GamePlayStatesEnum GetGamePlayStates()
    {
        return gamePlayStates;
    }
    public static void SetGamePlayStates(GamePlayStatesEnum value)
    {
        gamePlayStates = value;
    }
    private static SaveGameDTO[] saveGameDTO = new SaveGameDTO[5];
    public static SaveGameDTO[] GetSetSaveGameDTO
    {
        get
        {
            return saveGameDTO;
        }
        set
        {
            saveGameDTO = value;
        }        
    }
    private static int[] teamsIdPodium;
    public static int[] GetSetteamsIdPodium
    {
        get
        {
            return teamsIdPodium;
        }
        set
        {
            teamsIdPodium = value;
        }
    }    
    private static int tutorialStep = 0;
    public static int GetSettutorialStep
    {
        get
        {
            return tutorialStep;
        }
        set
        {
            tutorialStep = value;
        }
    }
    private static bool showTutorialInit = false;
    public static bool GetSetshowTutorialInit
    {
        get
        {
            return showTutorialInit;
        }
        set
        {
            showTutorialInit = value;
        }
    }
    private static bool isShowErrorMessage = false;
    public static bool GetSetisShowErrorMessage
    {
        get
        {
            return isShowErrorMessage;
        }
        set
        {
            isShowErrorMessage = value;
        }
    }
    //private static bool isSteamEnable = true;
    private static bool isSteamEnable = false;//Demo
    public static bool GetSetisSteamEnable
    {
        get
        {
            return isSteamEnable;
        }
        set
        {
            isSteamEnable = value;
        }
    }
    private static bool isDemo = false;
    //private static bool isDemo = true;//Demo
    public static bool GetSetisDemo
    {
        get
        {
            return isDemo;
        }
        set
        {
            isDemo = value;
        }
    }
    #endregion
}