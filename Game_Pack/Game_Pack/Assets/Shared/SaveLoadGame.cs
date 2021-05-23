using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using static General;

public class SaveLoadGame
{
    private static string pathNameSave = "/Saves/";
    private static string pathNameLoad = "/Saves/savegame";
    #region Save Game
    public static JSONResult SaveGame(int id)
    {
        try
        {
            SaveGameDTO saveGameDTO = new SaveGameDTO();
            if (General.GetGameMode() == GameModesEnum.Tournaments)
            {
                saveGameDTO = new SaveGameDTO()
                {
                    id = id,
                    idGameMode = (int)General.GetGameMode(),
                    dateTimeNow = DateTime.Now.ToString(),                    
                };
            }
            else
            {
                saveGameDTO = new SaveGameDTO()
                {
                    id = id,
                    idGameMode = (int)General.GetGameMode(),
                    dateTimeNow = DateTime.Now.ToString(),                    
                };
            }
            string savePath = pathNameSave;
            string fileName = "savegame" + (id).ToString() + ".json";
            return DataFile.SaveDataS(saveGameDTO, savePath, fileName);
        }
        catch (Exception ex)
        {
            var exMsg = ex.Message;
            return new JSONResult() { IsOK = false, message = Language.GetLanguage[General.GetSetConfig.languageID][107] }; ;
        }
    }
    #endregion
    #region Load Game
    public static void LoadGame(int id)
    {
        try
        {
            string loadFiles = pathNameLoad + (id).ToString() + ".json";
            SaveGameDTO saveGameDTO = DataFile.GetDataS<SaveGameDTO>(loadFiles);
            if (saveGameDTO != null)
            {
                General.SetGameMode((GameModesEnum)saveGameDTO.idGameMode);
                General.GetSetTournamentID = saveGameDTO.tournamentID;                
                General.SetGamePlayStates(General.GamePlayStatesEnum.LoadGame);                
                SceneManager.LoadScene(SceneInfo.GetSceneNames[3], LoadSceneMode.Single);
            }
        }
        catch (Exception ex)
        {
            var exMsg = ex.Message;
        }
    }    
    #endregion
    #region read all saves
    public static void ReadAllSaves()
    {
        try
        {
            General.GetSetSaveGameDTO = new SaveGameDTO[5];
            for (int i = 0; i < 5; i++)
            {
                string loadFiles = pathNameLoad + (i).ToString() + ".json";
                SaveGameDTO saveGameDTO = DataFile.GetDataS<SaveGameDTO>(loadFiles);
                if (saveGameDTO != null)
                {
                    General.GetSetSaveGameDTO[i] = saveGameDTO;
                }
                else
                {
                    General.GetSetSaveGameDTO[i] = null;
                }

            }
        }
        catch (Exception ex)
        {
            var exMsg = ex.Message;
        }
    }
    #endregion
    #region Convert to DTO    
    #endregion
    #region Checks if is there a saved game in slot
    public static bool CheksIfSlotsHasSavePoint(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
            return false;
        }
    }
    #endregion
}
