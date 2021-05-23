using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
using static General;

public class MainMenu_View : MonoBehaviour {
	#region Serialized Field	
	[SerializeField]
	private GameObject[] screens = null;	
	[SerializeField]
	private Color colorBtnSelected = default;	
	[SerializeField]
	private Color colorBtnUnselected = default;	
	[SerializeField]
	private Text[] textBtnRadioLanguage = null;	
	[SerializeField]
	private Text[] textBtnRadioDifficult = null;	
	[SerializeField]
	private Text[] textBtnRadioControl = null;	
	[SerializeField]
	private LanguageText[] languageText = null;	
	[SerializeField]
	private LanguageText text_Title = null;	
	[SerializeField]
	private GameObject outScreenPosition = null;	
	[SerializeField]
	private GameObject screenPosition = null;	
	[SerializeField]
	private Button[] buttonMenu = null;    
        
    [SerializeField]
    private GameObject[] screensRedefineButtons = null;
    [SerializeField]
    private Button[] buttonInput = null;
    [SerializeField]
    private Color buttonInputSelected = default;
    [SerializeField]
    private Color buttonInputUnselected = default;
                    
    [SerializeField]
    private Text[] text_Save_Label = null;
    [SerializeField]
    private GameObject Screen_12_LoadResult = null;
    [SerializeField]
    private Text Text_Save = null;                
    [SerializeField]
    private Text ErrorTextTitle = null;
    [SerializeField]
    private Text ErrorText = null;
    [SerializeField]
    private Text ErrorTextFile = null;    
    #endregion
    #region Variables    
    private MainMenu_Model mainMenu_Model; 
	private Options_Model options_Model;	
	private int selectedMainScreen = 0;        
    private int selectedscreensRedefineButtons = 0;
    private LoadModel loadModel;
    #endregion
    #region Behavior
    // Use this for initialization
    void Awake () {
		Init ();
	}
    private void Update()
    {
        if(CalibrateControl.GetSetinputID != -1)
        {
            options_Model.CalibrateControls();
        }        
    }
    #endregion
    #region Method
    /// <summary>
    /// Init this instance.
    /// </summary>
    private void Init()
	{
		int[] mainMenuID = new int[]{18, 19, 20, 22, 23, 18, 0, 1, 2, 0, 3};
		mainMenu_Model = new MainMenu_Model (text_Title, outScreenPosition.transform.position, screenPosition.transform.position, mainMenuID, buttonMenu, ErrorTextTitle, ErrorText);
		mainMenu_Model.Init (screens, screensRedefineButtons);
		options_Model = new Options_Model (colorBtnSelected, colorBtnUnselected, textBtnRadioLanguage,
            textBtnRadioDifficult, textBtnRadioControl, buttonInput, buttonInputSelected, buttonInputUnselected);
		options_Model.Init ();        
        ChangeScreenConfig (0);
        ChangeScreenConfigDefineKey(0);
        loadModel = new LoadModel(text_Save_Label, Screen_12_LoadResult, Text_Save);
        loadModel.FillSaveGamesInfo();
        loadModel.EnableDeleteWarning(false);

        if (General.GetSetshowTutorialInit)
        {
            options_Model.RadioButtonDifficultChangeButton(0);
            GoToTutorial();
        }            

    }
	#endregion
	#region Events	
	public void ChangeScreenConfig(int id)
	{
		selectedMainScreen = id;
		mainMenu_Model.ChangeScreenSelected (id);
	}   
    
    public void SelectGameMode(int id)
    {
        mainMenu_Model.SelectGameMode(id);
    }
	
	public void QuitGame()
	{
		Application.Quit ();
	}
	
	public void RadioButtonLanguageChangeButton(int id)
	{
		options_Model.RadioButtonLanguageChangeButton(id, languageText, text_Title);
        loadModel.FillSaveGamesInfo();
    }
	
	public void RadioButtonDifficultChangeButton(int id)
	{
		options_Model.RadioButtonDifficultChangeButton(id);
	}
	
	public void RadioButtonControlChangeButton(int id)
	{
		options_Model.RadioButtonControlChangeButton(id);
	}
	
	public void SelectTeam(int id)
	{
		ChangeScreenConfig (7);
	}
	
	public void LoadTrainningMode(int id)
	{
		mainMenu_Model.ChangeScreenSelected (8);
		mainMenu_Model.EnableDisableButtons (false);
		SceneManager.LoadSceneAsync(SceneInfo.GetSceneNames[id], LoadSceneMode.Single);
        General.SetGameMode(GameModesEnum.Friendly);
	}
        
    public void GoToGamePlay()
    {
        mainMenu_Model.ChangeScreenSelected(13, false);
        General.SetGamePlayStates(General.GamePlayStatesEnum.NewGame);
        SceneManager.LoadScene(SceneInfo.GetSceneNames[2], LoadSceneMode.Single);
    }
    public void ChangeScreenConfigDefineKey(int id)
    {
        selectedscreensRedefineButtons = id;
        mainMenu_Model.ChangeScreenConfigDefineKey(id);
    }
    public void SelectInput(int id)
    {
        options_Model.SelectInput(id);
    }
    public void LoadTournament(int id)
    {
        General.GetSetTournamentID = id;
        mainMenu_Model.ChangeScreenSelected(9);        
    }    
    public void GotoTournamentScreen()
    {
        General.SetGamePlayStates(General.GamePlayStatesEnum.NewGame);
        SceneManager.LoadScene(SceneInfo.GetSceneNames[3], LoadSceneMode.Single);
    }
    public void DeleteSave(int id)
    {
        try
        {
            General.GetSetisShowErrorMessage = false;
            loadModel.CheckDeleteSlot(id, this, ErrorTextFile);            
        }
        catch(Exception ex)
        {
            Debug.Log(ex.Message);
        }        
    }
    public void LoadSave(int id)
    {
        loadModel.LoadSave(id, this, ErrorTextFile);
    }
    public void ConfirmDelete()
    {
        loadModel.ConfirmDelete(this, ErrorTextFile);
    }
    public void CancelDelete()
    {
        loadModel.EnableDeleteWarning(false);
    }
    public void GoToTutorial()
    {        
        mainMenu_Model.SelectGameMode(6);
        mainMenu_Model.ChangeScreenSelected(13, false);        
        SceneManager.LoadScene(SceneInfo.GetSceneNames[2], LoadSceneMode.Single);
    }
    #endregion
}
