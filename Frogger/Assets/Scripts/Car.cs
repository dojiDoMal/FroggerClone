/*############################################################
**OneManArmy Games
**Anderson A. M.
**Car
############################################################*/

using UnityEngine;

public class Car : MonoBehaviour {

	#region Variables

	public Rigidbody2D rb;

	public float minSpeed = 2f;
	public float maxSpeed = 6f;

	float speed = 1f;

	#endregion

	#region UnityMethods

	void Start() {
		speed = Random.Range(minSpeed, maxSpeed);
	}

	void FixedUpdate ()
	{
		Vector2 forward = new Vector2(transform.right.x, transform.right.y);
		rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
	}
	#endregion

	#region MyMethods
	
	#endregion

}
