using Steamworks;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static General;

public class Tournament_Model
{
    #region Variables
    private Text title;
    private GameObject[] screens;
    private Vector3 outScreenPosition;
    private Vector3 screenPosition;
    private Color btnSelected;
    private Color btnUnselected;        
    #endregion
    #region Reset    
    #endregion
    #region Constant    
    #endregion
    #region Constructor
    public Tournament_Model(Text title, GameObject[] screens, Vector3 outScreenPosition, Vector3 screenPosition, Color btnSelected, Color btnUnselected)
    {
        this.title = title;
        this.screens = screens;
        this.outScreenPosition = outScreenPosition;
        this.screenPosition = screenPosition;        
        this.btnSelected = btnSelected;
        this.btnUnselected = btnUnselected;                        
    }
    #endregion
    #region Methods
    public void Init()
    {
        try
        {
            
        }
        catch (Exception ex)
        {
            var exMsg = ex.Message;
        }        
    }
    private void NewGame()
    {

    }    
    private void BackToGame()
    {
           
    }
    private void LoadGame()
    {
       
    }    
    private void SetAchievement()
    {
        if (General.GetSetisSteamEnable)
        {
            if (SteamManager.Initialized)
            {
                string achievementName = "";
                if (General.GetSetTournamentID == 0)
                    achievementName = "NEW_ACHIEVEMENT_1_3";
                else if (General.GetSetTournamentID == 1)
                    achievementName = "NEW_ACHIEVEMENT_1_4";
                else if (General.GetSetTournamentID == 2)
                    achievementName = "NEW_ACHIEVEMENT_1_5";
                else if (General.GetSetTournamentID == 3)
                    achievementName = "NEW_ACHIEVEMENT_1_6";
                else if (General.GetSetTournamentID == 4)
                    achievementName = "NEW_ACHIEVEMENT_1_7";
                else if (General.GetSetTournamentID == 7)
                    achievementName = "NEW_ACHIEVEMENT_1_8";
                else if (General.GetSetTournamentID == 8)
                    achievementName = "NEW_ACHIEVEMENT_1_9";
                else if (General.GetSetTournamentID == 9)
                    achievementName = "NEW_ACHIEVEMENT_1_10";

                bool tutorialCompleted;
                Steamworks.SteamUserStats.GetAchievement(achievementName, out tutorialCompleted);
                SteamUserStats.SetAchievement(achievementName);
                bool bSuccess = SteamUserStats.StoreStats();
            }
        }            
    }
    #endregion
    #region Events        
    public void BackToMainScreen()
    {                
        SceneManager.LoadSceneAsync(SceneInfo.GetSceneNames[1], LoadSceneMode.Single);
    }    
    public void GoToGamePlay()
    {        
        SceneManager.LoadScene(SceneInfo.GetSceneNames[2], LoadSceneMode.Single);
    }
    public void SaveGame(int id, Tournament_View tournament_View)
    {
        try
        {
            JSONResult result = SaveLoadGame.SaveGame(id);
#if UNITY_EDITOR
            UnityEditor.AssetDatabase.Refresh();
#endif
        }
        catch(Exception ex)
        {      
            Debug.Log(ex.Message);
        }        
    }         
    #endregion
}
