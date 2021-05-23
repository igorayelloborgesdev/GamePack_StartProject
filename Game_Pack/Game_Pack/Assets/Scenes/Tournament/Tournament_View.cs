using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Tournament_View : MonoBehaviour
{
    #region Serialized Field
    [SerializeField]
    private Text title = null;
    [SerializeField]
    GameObject[] screens = null;
    [SerializeField]
    private GameObject outScreenPosition = null;
    [SerializeField]
    private GameObject screenPosition = null;    
    [SerializeField]
    private Color btnSelected = default;
    [SerializeField]
    private Color btnUnselected = default;            
    #endregion
    #region Variables
    private Tournament_Model tournament_Model;
    #endregion
    #region Behaviors
    void Start()
    {
        Init();
    }    
    void Update()
    {
        
    }
    #endregion
    #region Methods
    private void Init()
    {       
        tournament_Model = new Tournament_Model(            
            title, screens, outScreenPosition.transform.position, screenPosition.transform.position, btnSelected, btnUnselected);
            tournament_Model.Init();        
    }    
    #endregion
    #region Events    
    public void ChangeScreenConfig(int id)
    {        

    }
    public void BackToMainScreen()
    {
        tournament_Model.BackToMainScreen();
    }        
    public void GoToGamePlay()
    {
        tournament_Model.GoToGamePlay();
    }
    public void SaveGame(int id)
    {
        tournament_Model.SaveGame(id, this);
    }    
    public void ContinueSeason()
    {

    }
    public void ShowSeasonTournamentMessage()
    {

    }    
    public void GotoFinalSeasonScreen()
    {
        
    }
    #endregion
}