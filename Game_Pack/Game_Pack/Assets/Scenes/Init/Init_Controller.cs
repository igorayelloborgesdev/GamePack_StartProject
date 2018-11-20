using UnityEngine;
using System.Collections;

public class Init_Controller {
	#region Constructor
	#endregion
	#region Variables
	/// <summary>
	/// The present time.
	/// </summary>
	private const float presentTime = 1.0f;
	public float GetPresentTime
	{
		get{
			return presentTime;
		}
	}
	/// <summary>
	/// The period.
	/// </summary>
	private float period = 0.0f;
	public float GetSetPeriod
	{
		get{
			return period;
		}
		set{ 
			this.period = value;
		}
	}
	#endregion
	#region Methods
	/// <summary>
	/// Go to next screen.
	/// </summary>
	/// <returns><c>true</c>, if to next screen was gone, <c>false</c> otherwise.</returns>
	/// <param name="currentTime">Current time.</param>
	public bool GoToNextScreen(float currentTime)
	{
		if (currentTime > presentTime)
			return true;
		return false;
	}
	/// <summary>
	/// Init this instance.
	/// </summary>
	public void Init()
	{
		Language.LoadLanguage ();
	}
	#endregion
}