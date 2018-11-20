using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;
using System;

/// <summary>
/// Data file.
/// </summary>
public static class DataFile {
	#region Variables
	/// <summary>
	/// Gets or sets the savefile.
	/// </summary>
	/// <value>The savefile.</value>
	private static SaveFile datafile { get; set;}
	/// <summary>
	/// Gets the get data file.
	/// </summary>
	/// <value>The get data file.</value>
	public static SaveFile GetDataFile{
		get{ 
			return datafile;
		}	
	}
	/// <summary>
	/// The name of the data file.
	/// </summary>
	private static string dataFileName = "datafile";
	#endregion
	#region methods
	/// <summary>
	/// Inits the data file.
	/// </summary>
	public static void InitDataFile()
	{
		try
		{
			var dfs = Resources.Load<TextAsset>(dataFileName); 
			datafile = JsonUtility.FromJson<SaveFile>(dfs.text);
		}
		catch {
		}
	}
	#endregion
}