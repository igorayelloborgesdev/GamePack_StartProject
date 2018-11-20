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
		"0",//2
		"1",//3
		"2",//4
		"3_Archery",//5
		"4_Shooting",//6
		"5",//7
		"6",//8
		"7",//9
		"8_100meters",//10
		"9_100metershurdles",//11
		"10_Highjump",//12,
		"11_Polevault",//13
		"12_Longjump",//14
		"13_Triplejump",//15
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