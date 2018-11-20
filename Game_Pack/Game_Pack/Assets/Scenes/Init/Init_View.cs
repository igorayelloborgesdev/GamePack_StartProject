using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Init_View : MonoBehaviour {
	#region Variables
	/// <summary>
	/// The init controller.
	/// </summary>
	private Init_Controller init_Controller;
	#endregion
	#region Behaviors
	// Use this for initialization
	void Start () {
		Init ();
	}
	// Update is called once per frame
	void Update () {
		LoadScene ();
	}
	#endregion
	#region Methods
	/// <summary>
	/// Init this instance.
	/// </summary>
	private void Init()
	{
		init_Controller = new Init_Controller ();
		init_Controller.Init ();
	}
	/// <summary>
	/// Loads the scene.
	/// </summary>
	private void LoadScene()
	{
		init_Controller.GetSetPeriod += Time.deltaTime;
		if(init_Controller.GoToNextScreen (init_Controller.GetSetPeriod))
			SceneManager.LoadScene(SceneInfo.GetSceneNames[1], LoadSceneMode.Single);
	}
	#endregion
}