using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.IO;
using UnityEngine.UI;
using System;

public class Language {
	#region Variables
	/// <summary>
	/// The language.
	/// </summary>
	private static List<List<string>> language;
	/// <summary>
	/// Gets the language.
	/// </summary>
	/// <value>The get language.</value>
	public static List<List<string>> GetLanguage{
		get{ 
			return language;
		}
	}
	#endregion
	#region Methods
	/// <summary>
	/// Loads the language array.
	/// </summary>
	public static void LoadLanguage()
	{
		language = new List<List<string>> ();
		language.Add (new List<string> ());
		language.Add (new List<string> ());
		try
		{
			TextAsset textAsset = (TextAsset) Resources.Load("language");  
			XmlDocument xmldoc = new XmlDocument ();
			xmldoc.LoadXml ( textAsset.text );
			XmlNodeList nodeList = xmldoc.GetElementsByTagName ("language");
			foreach(XmlNode node in nodeList)
			{
				XmlNodeList content = node.ChildNodes;
				foreach(XmlNode node1 in content)
				{
					if (node1.Name == "english")
						language [0].Add (node1.InnerText);
					else
						language [1].Add (node1.InnerText);
				}
			}	
		}catch{
		}
	}
	/// <summary>
	/// Changes the language.
	/// </summary>
	/// <param name="id">Identifier.</param>
	/// <param name="languageText">Language text.</param>
	public static void ChangeLanguage(int id, LanguageText[] languageText)
	{
		try
		{
			Config.GetSetLanguageID = id;
			for(int i = 0; i < languageText.Length; i++){
				languageText [i].ChangeText ();
			}	
		}catch {
		}
	}
	#endregion
}