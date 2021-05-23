using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;

public class Init_Model {
	#region Variables	
	private const float presentTime = 5.0f;
	public float GetPresentTime
	{
		get{
			return presentTime;
		}
	}	
	private float period = 0.0f;
	public float GetSetPeriod
	{
		get{
			return period;
		}
		set{ 
			this.period = value;
		}
	}    
    //private string countriesTeams = "countriesTeams";//----- Use this to load all config, save or database
    private string configName = "/Saves/config.json";//----- Use this to load all config, save or database
    //private string tournamentName = "tournaments";//----- Use this to load all config, save or database
    #endregion
    #region Methods    
    public bool GoToNextScreen(float currentTime)
	{
        try
        {
            if (currentTime > presentTime)
                return true;
            return false;
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
            return false;
        }        
	}
	public void Init()
	{
        try
        {
            Language.LoadLanguage();
            //General.GetSetTeams = DataFile.GetData<TeamObjectDTO>(countriesTeams).teamDTO;//----- Use this to load all config, save or database
            string pathConfig = Application.persistentDataPath + "/" + configName;
            if (File.Exists(pathConfig))
            {
                General.GetSetConfig = DataFile.GetDataS<ConfigDTO>(configName);
                //General.GetSetshowTutorialInit = false;//----- Use this to enable auto tutorial
            }
            else
            {
                General.GetSetConfig = new ConfigDTO()
                {
                    languageID = 0,
                    difficultID = 0,
                    controlID = 0,
                    controlsKeycode = new int[] { 273, 274, 276, 275, 97, 27 }
                };
                //General.GetSetshowTutorialInit = true;//----- Use this to enable auto tutorial
            }
            //General.GetSetTournament = DataFile.GetData<TournamentObjectDTO>(tournamentName).tournamentDTOArray;//----- Use this to load all config, save or database
            //Season.GetSetQualifiedTeams = new List<List<int>>();//----- Use this to load all config, save or database
            //for (int i = 0; i < General.GetSetTournament.Count; i++)//----- Use this to load all config, save or database
            //{
            //    Season.GetSetQualifiedTeams.Add(new List<int>());
            //}
            //General.GetSetSeasonTournamentDTO = DataFile.GetDataSResources<List<List<SeasonTournamentDTO>>>("season");//----- Use this to load all config, save or database
            General.GetSetisShowErrorMessage = false;
        }
        catch (Exception ex)
        {
            General.GetSetisShowErrorMessage = true;
            Debug.Log(ex.Message);         
        }        
    }
	#endregion
}