using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Controls.
/// </summary>
public class Controls {
	#region Events
	/// <summary>
	/// Key press up
	/// </summary>
	public static bool KeyCodeUP()
	{		
		if (Input.GetKey (KeyCode.UpArrow))
			return true;
		return false;
	}
	/// <summary>
	/// Key press right
	/// </summary>
	public static bool KeyCodeRIGHT()
	{		
		if (Input.GetKey (KeyCode.RightArrow))
			return true;
		return false;
	}
	/// <summary>
	/// Key press down
	/// </summary>
	public static bool KeyCodeDOWN()
	{		
		if (Input.GetKey (KeyCode.DownArrow))
			return true;
		return false;
	}
	/// <summary>
	/// Key press left
	/// </summary>
	public static bool KeyCodeLEFT()
	{		
		if (Input.GetKey (KeyCode.LeftArrow))
			return true;
		return false;
	}
	/// <summary>
	/// Key press up
	/// </summary>
	public static bool KeyCodeUPDown()
	{		
		if (Input.GetKeyDown (KeyCode.UpArrow))
			return true;
		return false;
	}
	/// <summary>
	/// Key press right
	/// </summary>
	public static bool KeyCodeRIGHTDown()
	{		
		if (Input.GetKeyDown (KeyCode.RightArrow))
			return true;
		return false;
	}
	/// <summary>
	/// Key press down
	/// </summary>
	public static bool KeyCodeDOWNDown()
	{		
		if (Input.GetKeyDown (KeyCode.DownArrow))
			return true;
		return false;
	}
	/// <summary>
	/// Key press left
	/// </summary>
	public static bool KeyCodeLEFTDown()
	{		
		if (Input.GetKeyDown (KeyCode.LeftArrow))
			return true;
		return false;
	}
	/// <summary>
	/// Keys the code ACTION n1.
	/// </summary>
	/// <returns><c>true</c>, if code ACTION was keyed, <c>false</c> otherwise.</returns>
	public static bool KeyCodeACTIONDOWN1()
	{		
		if (Input.GetKeyDown (KeyCode.Space))
			return true;
		return false;
	}
	/// <summary>
	/// Keies the code ACTIONDOW n2.
	/// </summary>
	/// <returns><c>true</c>, if code ACTIONDOW n2 was keyed, <c>false</c> otherwise.</returns>
	public static bool KeyCodeACTIONDOWN2()
	{		
		if (Input.GetKeyDown (KeyCode.A))
			return true;
		return false;
	}
	/// <summary>
	/// Keys the code ACTION.
	/// </summary>
	/// <returns><c>true</c>, if code ACTION was keyed, <c>false</c> otherwise.</returns>
	public static bool KeyCodeACTION()
	{		
		if (Input.GetKey (KeyCode.Space))
			return true;
		return false;
	}
	/// <summary>
	/// Keys the code ESCAPE.
	/// </summary>
	/// <returns><c>true</c>, if code ESCAPE was keyed, <c>false</c> otherwise.</returns>
	public static bool KeyCodeESCAPE()
	{		
		if (Input.GetKeyDown (KeyCode.Escape))
			return true;
		return false;
	}

	public static bool KeyCodeANYKEY()
	{	
		if (Input.anyKeyDown)
			return true;
		return false;
	}
	#endregion
}