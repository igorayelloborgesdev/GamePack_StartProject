using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// General configs.
/// </summary>
public static class General {
	#region variables
	/// <summary>
	/// The game mode.
	/// 0- Trainning
	/// 1- Qualify
	/// 2- World Games
	/// </summary>
	private static int gameMode = 0;
	public static int GetSetGameMode
	{
		get
		{ 
			return gameMode;
		}
		set
		{ 
			gameMode = value;
		}
	}
	/// <summary>
	/// The selected country.
	/// </summary>
	private static int selectedCountry = 0;
	public static int GetSetSelectedCountry{
		get{
			return selectedCountry;
		}
		set{
			selectedCountry = value;
		}
	}
	#endregion
}