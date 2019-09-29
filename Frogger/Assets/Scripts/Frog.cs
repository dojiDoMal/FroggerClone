/*############################################################
**OneManArmy Games
**Anderson A. M.
**Frog
############################################################*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour {

	#region Variables

	public Rigidbody2D rb;
	
	#endregion

	#region UnityMethods
	
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			rb.MovePosition(rb.position + Vector2.right);
		}
		else if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			rb.MovePosition(rb.position + Vector2.left);
		}
		else if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			rb.MovePosition(rb.position + Vector2.up);
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			rb.MovePosition(rb.position + Vector2.down);
		}
	}
	#endregion

	#region MyMethods

	void OnTriggerEnter2D(Collider2D col) {
		if(col.tag == "Car")
		{
			Debug.Log("GAME OVER!");
			Score.currentScore = 0;
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}

	#endregion

}
