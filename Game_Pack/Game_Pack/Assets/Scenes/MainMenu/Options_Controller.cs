using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options_Controller {
	#region Variable
	/// <summary>
	/// The radio button language.
	/// </summary>
	private RadioButton radioButtonLanguage;
	/// <summary>
	/// The radio button difficult.
	/// </summary>
	private RadioButton radioButtonDifficult;
	/// <summary>
	/// The radio button control.
	/// </summary>
	private RadioButton radioButtonControl;
	/// <summary>
	/// The color button selected.
	/// </summary>
	private Color colorBtnSelected;
	/// <summary>
	/// The color button unselected.
	/// </summary>
	private Color colorBtnUnselected;
	/// <summary>
	/// The text button radio language.
	/// </summary>
	private Text[] textBtnRadioLanguage;
	/// <summary>
	/// The text button radio difficult.
	/// </summary>
	private Text[] textBtnRadioDifficult;
	/// <summary>
	/// The text button radio points.
	/// </summary>
	private Text[] textBtnRadioPoints;
	/// <summary>
	/// The text button radio sets.
	/// </summary>
	private Text[] textBtnRadioSets;
	/// <summary>
	/// The text button radio control.
	/// </summary>
	private Text[] textBtnRadioControl;
	/// <summary>
	/// The radio button main menu.
	/// </summary>
	private RadioButton radioButtonMainMenu;
	#endregion
	#region Constructor
	public Options_Controller(Color colorBtnSelected, Color colorBtnUnselected, 
		Text[] textBtnRadioLanguage, Text[] textBtnRadioDifficult, Text[] textBtnRadioControl)
	{
		this.colorBtnSelected = colorBtnSelected;
		this.colorBtnUnselected = colorBtnUnselected;
		this.textBtnRadioLanguage = textBtnRadioLanguage;
		this.textBtnRadioDifficult = textBtnRadioDifficult;
		this.textBtnRadioControl = textBtnRadioControl;
	}
	#endregion
	#region Methods
	/// <summary>
	/// Init this instance.
	/// </summary>
	public void Init()
	{
		radioButtonLanguage = new RadioButton (textBtnRadioLanguage, colorBtnSelected, colorBtnUnselected);
		radioButtonLanguage.ChangeButton (0);
		radioButtonDifficult = new RadioButton (textBtnRadioDifficult, colorBtnSelected, colorBtnUnselected);
		radioButtonDifficult.ChangeButton (1);
		radioButtonControl = new RadioButton (textBtnRadioControl, colorBtnSelected, colorBtnUnselected);
		radioButtonControl.ChangeButton (0);
	}
	#endregion
	#region Events
	/// <summary>
	/// Radios the button language change button.
	/// </summary>
	public void RadioButtonLanguageChangeButton(int id, LanguageText[] languageText, LanguageText mainMenuText)
	{
		radioButtonLanguage.ChangeButton (id);
		Language.ChangeLanguage (id, languageText);
		mainMenuText.ChangeTextDynamically (3);
	}
	/// <summary>
	/// Radios the button difficult change button.
	/// </summary>
	/// <param name="id">Identifier.</param>
	public void RadioButtonDifficultChangeButton(int id)
	{
		radioButtonDifficult.ChangeButton (id);
	}
	/// <summary>
	/// Radios the button control change button.
	/// </summary>
	/// <param name="id">Identifier.</param>
	public void RadioButtonControlChangeButton(int id)
	{
		radioButtonControl.ChangeButton (id);
	}
	#endregion
}