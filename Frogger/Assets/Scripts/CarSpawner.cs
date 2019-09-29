/*############################################################
**OneManArmy Games
**Anderson A. M.
**CarSpawner
############################################################*/

using UnityEngine;

public class CarSpawner : MonoBehaviour {

	#region Variables

	public float spawnDelay = .3f;
	float nextTimeToSpawn = 0f;
	public GameObject car;
	public Transform[] spawnPoints;

	#endregion

	#region UnityMethods
	
	void Update ()
	{
		if(nextTimeToSpawn <= Time.time)
		{
			SpawnCar();
			nextTimeToSpawn = Time.time + spawnDelay;
		}
	}
	#endregion

	#region MyMethods

	void SpawnCar() {
		int randomIndex = Random.Range(0, spawnPoints.Length);
		Transform spawnPoint = spawnPoints[randomIndex];
		GameObject carSpawned = Instantiate(car, spawnPoint.position, spawnPoint.rotation);
		Destroy(carSpawned, 5f);
	}

	#endregion

}
