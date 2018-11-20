using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class MainMenu_View : MonoBehaviour {
	#region Serialized Field
	/// <summary>
	/// The screen array.
	/// </summary>
	[SerializeField]
	private GameObject[] screens;
	/// <summary>
	/// The color button selected.
	/// </summary>
	[SerializeField]
	private Color colorBtnSelected;
	/// <summary>
	/// The color button unselected.
	/// </summary>
	[SerializeField]
	private Color colorBtnUnselected;
	/// <summary>
	/// The text button radio language.
	/// </summary>
	[SerializeField]
	private Text[] textBtnRadioLanguage;
	/// <summary>
	/// The text button radio difficult.
	/// </summary>
	[SerializeField]
	private Text[] textBtnRadioDifficult;
	/// <summary>
	/// The text button radio control.
	/// </summary>
	[SerializeField]
	private Text[] textBtnRadioControl;
	/// <summary>
	/// The language text.
	/// </summary>
	[SerializeField]
	private LanguageText[] languageText;
	/// <summary>
	/// The text title.
	/// </summary>
	[SerializeField]
	private LanguageText text_Title;
	/// <summary>
	/// The out screen position.
	/// </summary>
	[SerializeField]
	private GameObject outScreenPosition;
	/// <summary>
	/// The screen position.
	/// </summary>
	[SerializeField]
	private GameObject screenPosition;
	/// <summary>
	/// The button menu.
	/// </summary>
	[SerializeField]
	private Button[] buttonMenu;
	#endregion
	#region Variables
	/// <summary>
	/// The main menu controller.
	/// </summary>
	private MainMenu_Controller mainMenu_Controller; 
	/// <summary>
	/// The options controller.
	/// </summary>
	private Options_Controller options_Controller;
	/// <summary>
	/// The selected main screen.
	/// </summary>
	private int selectedMainScreen = 0;
	#endregion
	#region Behavior
	// Use this for initialization
	void Awake () {
		Init ();
	}
	#endregion
	#region Method
	/// <summary>
	/// Init this instance.
	/// </summary>
	private void Init()
	{
		int[] mainMenuID = new int[]{1, 3, 7, 4, 2, 5, 6, 6, 6};
		mainMenu_Controller = new MainMenu_Controller (text_Title, outScreenPosition.transform.position, screenPosition.transform.position, mainMenuID, buttonMenu);
		mainMenu_Controller.Init (screens);
		options_Controller = new Options_Controller (colorBtnSelected, colorBtnUnselected, textBtnRadioLanguage, textBtnRadioDifficult, textBtnRadioControl);		
		options_Controller.Init ();
		ChangeScreenConfig (0);
	}
	#endregion
	#region Events
	/// <summary>
	/// Changes the screen config.
	/// </summary>
	/// <param name="id">Identifier.</param>
	public void ChangeScreenConfig(int id)
	{
		selectedMainScreen = id;
		mainMenu_Controller.ChangeScreenSelected (id);
	}
	/// <summary>
	/// Quits the game.
	/// </summary>
	public void QuitGame()
	{
		Application.Quit ();
	}
	/// <summary>
	/// Radios the button language change button.
	/// </summary>
	/// <param name="id">Identifier.</param>
	public void RadioButtonLanguageChangeButton(int id)
	{
		options_Controller.RadioButtonLanguageChangeButton(id, languageText, text_Title);
	}
	/// <summary>
	/// Radios the button difficult change button.
	/// </summary>
	/// <param name="id">Identifier.</param>
	public void RadioButtonDifficultChangeButton(int id)
	{
		options_Controller.RadioButtonDifficultChangeButton(id);
	}
	/// <summary>
	/// Radios the button control change button.
	/// </summary>
	/// <param name="id">Identifier.</param>
	public void RadioButtonControlChangeButton(int id)
	{
		options_Controller.RadioButtonControlChangeButton(id);
	}
	/// <summary>
	/// Selects the team.
	/// </summary>
	/// <param name="id">Identifier.</param>
	public void SelectTeam(int id)
	{
		ChangeScreenConfig (7);
	}
	/// <summary>
	/// Loads the trainning mode.
	/// </summary>
	public void LoadTrainningMode(int id)
	{
		mainMenu_Controller.ChangeScreenSelected (8);
		mainMenu_Controller.EnableDisableButtons (false);
		SceneManager.LoadSceneAsync(SceneInfo.GetSceneNames[id], LoadSceneMode.Single); 
		General.GetSetGameMode = 0;
	}
	#endregion
}
