/*############################################################
**OneManArmy Games
**Anderson A. M.
**Score
############################################################*/

using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	#region Variables
	public static int currentScore = 0;
	public Text scoreText;
	#endregion

	#region UnityMethods
	
	void Start () 
	{
		scoreText.text = currentScore.ToString();
	}
	
	#endregion

	#region MyMethods
	
	#endregion

}
