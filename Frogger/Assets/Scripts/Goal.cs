/*############################################################
**OneManArmy Games
**Anderson A. M.
**Goal
############################################################*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

	#region Variables

	#endregion

	#region UnityMethods
	
	void Start () 
	{
		
	}
	
	void Update ()
	{
		
	}
	#endregion

	#region MyMethods

	void OnTriggerEnter2D() {
		Debug.Log("You Won!");
		Score.currentScore += 100;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	#endregion

}
