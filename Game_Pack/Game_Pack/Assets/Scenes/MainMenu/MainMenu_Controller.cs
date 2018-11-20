using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu_Controller {
	#region Serialized field
	/// <summary>
	/// The button menu.
	/// </summary>
	private Button[] buttonMenu;
	#endregion
	#region Variables
	/// <summary>
	/// The change screen.
	/// </summary>
	private ChangeScreen changeScreen;
	/// <summary>
	/// The text title.
	/// </summary>
	private LanguageText text_Title;
	/// <summary>
	/// The main menu ID.
	/// </summary>
	private int[] menuID;
	/// <summary>
	/// The out screen position.
	/// </summary>
	private Vector3 outScreenPosition;
	/// <summary>
	/// The screen position.
	/// </summary>
	private Vector3 screenPosition;
	#endregion
	#region Constructor
	/// <summary>
	/// Initializes a new instance of the <see cref="MainMenu_Controller"/> class.
	/// </summary>
	/// <param name="text_Title">Text title.</param>
	public MainMenu_Controller(LanguageText text_Title, Vector3 outScreenPosition, Vector3 screenPosition, int[] menuID, Button[] buttonMenu)
	{
		this.text_Title = text_Title;
		this.outScreenPosition = outScreenPosition;
		this.screenPosition = screenPosition;
		this.menuID = menuID;
		this.buttonMenu = buttonMenu;
	}
	#endregion
	#region Method
	/// <summary>
	/// Init this instance.
	/// </summary>
	public void Init(GameObject[] screens)
	{
		changeScreen = new ChangeScreen (screens, outScreenPosition, screenPosition);
		DataFile.InitDataFile ();
	}
	/// <summary>
	/// Changes the screen selected.
	/// </summary>
	/// <param name="id">Identifier.</param>
	public void ChangeScreenSelected(int id)
	{
		changeScreen.ChangeScreenSelected (id);
		text_Title.ChangeTextDynamically (menuID[id]);
	}
	/// <summary>
	/// Enables the disable buttons.
	/// </summary>
	/// <param name="isEnable">If set to <c>true</c> is enable.</param>
	public void EnableDisableButtons(bool isEnable)
	{
		for(int i = 0; i < buttonMenu.Length; i++)
		{
			buttonMenu [i].enabled = isEnable;
		}	
	}
	#endregion
}