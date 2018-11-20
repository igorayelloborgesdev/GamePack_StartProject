using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScreen {
	#region Variables
	/// <summary>
	/// The screen array.
	/// </summary>
	private GameObject[] screens;
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
	/// Initializes a new instance of the <see cref="ChangeScreen"/> class.
	/// </summary>
	/// <param name="screen">Screen.</param>
	public ChangeScreen(GameObject[] screens, Vector3 outScreenPosition, Vector3 screenPosition)
	{
		this.screens = screens;
		this.outScreenPosition = outScreenPosition;
		this.screenPosition = screenPosition;
	}
	#endregion
	#region Methods
	/// <summary>
	/// Changes the screen selected.
	/// </summary>
	/// <param name="id">Identifier.</param>
	public void ChangeScreenSelected(int id)
	{
		HideAll ();
		screens [id].transform.position = screenPosition;
	}
	/// <summary>
	/// Hides all.
	/// </summary>
	private void HideAll()
	{
		foreach(GameObject screen in screens)
		{
			screen.transform.position = outScreenPosition;
		}
	}
	#endregion
}