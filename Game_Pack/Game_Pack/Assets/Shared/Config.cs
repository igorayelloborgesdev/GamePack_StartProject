using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Config {
	#region Variables
	/// <summary>
	/// The language ID.
	/// </summary>
	private static int languageID = 0;
	public static int GetSetLanguageID
	{
		get{ 
			return languageID;
		}
		set{ 
			languageID = value;
		}
	}
	#endregion
}