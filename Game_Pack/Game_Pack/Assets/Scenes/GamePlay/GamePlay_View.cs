using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay_View : MonoBehaviour
{
    #region Serialized     
    [SerializeField]
    private GameObject Pause_Menu = null;    
    [SerializeField]
    private CameraManager mainCamera = null;    
    [SerializeField]
    private GameObject Loading_Screen = null;    
    [SerializeField]
    private GameObject EndGame_Screen = null;    
    [SerializeField]
    private GameObject default_PauseMenu = null;    
    [SerializeField]
    public AudioSource[] audioSource = null;    
    #endregion
    #region Variables    
    private GamePlay_Model gamePlay_Model;
    #endregion
    #region Behavior    
    void Start()
    {
        gamePlay_Model = new GamePlay_Model(Pause_Menu, mainCamera, Loading_Screen, EndGame_Screen, default_PauseMenu, audioSource);
        gamePlay_Model.Init();
    }
    void Update()
    {
        gamePlay_Model.Update();
    }
    public void FixedUpdate()
    {
        gamePlay_Model.FixedUpdate();
    }
    #endregion
    #region Methods        
    private void PauseGame()
    {
        try
        {
            gamePlay_Model.PauseGame();
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex.Message);
        }
    }
    #endregion
    #region Events    
    public void ContinePauseGame()
    {
        try
        {
            gamePlay_Model.PauseGame(false);
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
            gamePlay_Model.QuitGame(isBackToMain);
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex.Message);
        }
    }    
    public void UnPauseTutorial(bool pause)
    {
        gamePlay_Model.UnPauseTutorial(pause);
    }
    #endregion
}
