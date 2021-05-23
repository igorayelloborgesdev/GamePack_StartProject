using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SceneInfo {
	#region Variables
	/// <summary>
	/// The scene names.
	/// </summary>
	private static string[] sceneNames = new string[]{
		"Init_View",//0 
		"MainMenu_View",//1
		"GamePlay_View",//2		
        "Tournament_View"//3		
	};
	public static string[] GetSceneNames
	{
		get
		{ 
			return sceneNames;
		}
	}
	#endregion
}