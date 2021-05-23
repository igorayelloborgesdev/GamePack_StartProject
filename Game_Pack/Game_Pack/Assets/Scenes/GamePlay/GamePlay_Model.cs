using Steamworks;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePlay_Model
{
    /// <summary>
    /// Gameplay model
    /// </summary>    
    #region Variables    
    /// <summary>
    /// Is game paused
    /// </summary>
    private bool isPause = false;        
    private const float maxTimeToResetPlay = 5.0f;    
    private Timer timer;        
    private const float timeToFinishLoading = 3.0f;    
    System.Random randNum = new System.Random();    
    #endregion
    #region Serialized    
    private GameObject Pause_Menu;    
    private CameraManager mainCamera;    
    private GameObject Loading_Screen;    
    private GameObject EndGame_Screen;    
    private GameObject default_PauseMenu;        
    public AudioSource[] audioSource = null;
    #endregion
    #region Variables to reset        
    #endregion
    #region Static variables                
    #endregion
    #region Constructor
    public GamePlay_Model(GameObject Pause_Menu, CameraManager mainCamera, GameObject Loading_Screen, GameObject EndGame_Screen, GameObject default_PauseMenu, AudioSource[] audioSource)
    {        
        this.Pause_Menu = Pause_Menu;        
        this.mainCamera = mainCamera;        
        this.Loading_Screen = Loading_Screen;        
        this.EndGame_Screen = EndGame_Screen;        
        this.default_PauseMenu = default_PauseMenu;        
        this.audioSource = audioSource;        
    }
    #endregion
    #region Methods    
    public void Init()
    {
        try
        {            
            
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex.Message);
        }
    }    
    
    public void PauseGame()
    {
        try
        {
            isPause = !isPause;
            if (isPause)
            {
                Time.timeScale = 0;
                Pause_Menu.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                Pause_Menu.SetActive(false);
            }
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex.Message);
        }
    }    
    public void PauseGame(bool paused)
    {
        try
        {
            isPause = paused;
            if (isPause)
            {
                Time.timeScale = 0;
                Pause_Menu.SetActive(isPause);
            }
            else
            {
                Time.timeScale = 1;
                Pause_Menu.SetActive(isPause);
            }
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex.Message);
        }
    }
    public void QuitGame(bool isBackToMain)
    {
        try
        {            
            if (isBackToMain)
            {
                General.SetGamePlayStates(General.GamePlayStatesEnum.NewGame);
                SceneManager.LoadScene(SceneInfo.GetSceneNames[1], LoadSceneMode.Single);
                return;
            }            
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex.Message);
        }
    }
    public void Update()
    {
        try
        {
            
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex.Message);
        }
    }
    public void FixedUpdate()
    {
        try
        {
            
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex.Message);
        }
    }    
    public void UnPauseTutorial(bool pause)
    {
        isPause = pause;
    }
    #endregion
}