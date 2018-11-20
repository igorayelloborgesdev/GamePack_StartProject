using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class LanguageText : MonoBehaviour {
	#region Variables
	/// <summary>
	/// The text.
	/// </summary>
	[SerializeField]
	private Text text;
	/// <summary>
	/// Sets the text.
	/// </summary>
	/// <value>The set text.</value>
	public Text SetText{
		set{ 
			text = value;
		}
	}
	/// <summary>
	/// The ID.
	/// </summary>
	[SerializeField]
	private int ID;
	#endregion
	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start () {
		ChangeText ();
	}
	#region Method
	/// <summary>
	/// Changes the text.
	/// </summary>
	public void ChangeText()
	{
		try
		{
			text.text = Language.GetLanguage [Config.GetSetLanguageID] [ID];	
		}
		catch {
		}
	}
	/// <summary>
	/// Changes the text dynamically.
	/// </summary>
	/// <param name="textID">Text I.</param>
	public void ChangeTextDynamically(int textID)
	{
		try
		{
			text.text = Language.GetLanguage [Config.GetSetLanguageID] [textID];
		}
		catch {
		}
	}
	#endregion
}
