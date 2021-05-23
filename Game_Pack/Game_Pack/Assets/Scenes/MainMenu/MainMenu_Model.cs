using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static General;

public class MainMenu_Model {
    #region Serialized field    
    private Button[] buttonMenu;        
    private Text ErrorTextTitle;    
    private Text ErrorText;
    #endregion
    #region Variables    
    private ChangeScreen changeScreen;    
    private LanguageText text_Title;    
    private int[] menuID;    
    private Vector3 outScreenPosition;    
    private Vector3 screenPosition;
    private ChangeScreen changeScreenRedefineButtons;    
    #endregion    
    #region Constructor    
    public MainMenu_Model(LanguageText text_Title, Vector3 outScreenPosition, Vector3 screenPosition, int[] menuID, Button[] buttonMenu, Text ErrorTextTitle, Text ErrorText)
	{
		this.text_Title = text_Title;
		this.outScreenPosition = outScreenPosition;
		this.screenPosition = screenPosition;
		this.menuID = menuID;
		this.buttonMenu = buttonMenu;        
        this.ErrorTextTitle = ErrorTextTitle;
        this.ErrorText = ErrorText;
    }
	#endregion
	#region Method
	public void Init(GameObject[] screens, GameObject[] screensRedefineButtons)
	{
        try
        {
            if (General.GetSetisShowErrorMessage)
            {
                DefineError(screens[11]);
                throw new System.Exception("Could not load language, please close the game and start again.");
            }
            else
            {
                changeScreen = new ChangeScreen(screens, outScreenPosition, screenPosition);
                changeScreenRedefineButtons = new ChangeScreen(screensRedefineButtons, outScreenPosition, screenPosition);
            }            
        }
        catch(System.Exception ex)
        {
            Debug.Log(ex.Message);
        }
    }
	public void ChangeScreenSelected(int id, bool isChangeTitle = true)
	{
        try
        {
            changeScreen.ChangeScreenSelected(id);
            if(isChangeTitle)
                text_Title.ChangeTextDynamically(menuID[id]);
        }
		catch(System.Exception ex)
        {
            Debug.Log(ex.Message);
        }
	}    
    public void EnableDisableButtons(bool isEnable)
	{
		for(int i = 0; i < buttonMenu.Length; i++)
		{
			buttonMenu [i].enabled = isEnable;
		}	
	}         
    public void SelectGameMode(int id)
    {
        General.SetGameMode((GameModesEnum)id);
    }
    public void ChangeScreenConfigDefineKey(int id)
    {
        try
        {
            changeScreenRedefineButtons.ChangeScreenSelected(id);
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex.Message);
        }
    }    
    private void DefineError(GameObject screen)
    {        
        screen.SetActive(true);
        this.ErrorTextTitle.text = "Error";
        this.ErrorText.text = "Could not load language, please close the game and start again.";
    }
    #endregion
}