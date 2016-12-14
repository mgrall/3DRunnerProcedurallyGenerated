using UnityEngine;
using System.Collections;

// THE OBJECTS MUST DESPAWN EVENTUALLY, ADD LATER
public class Object_Spawner : MonoBehaviour {

	public GameObject player;
	public GameObject [] coins;
	public GameObject [] trees;
	public GameObject enemy;

	private float coinSpawnTimer = 7.0f;
	private float treeSpawnTimer = 0.5f;
	private float enemySpawnTimer = 10.0f;
	private int xOffset = 30;


	
	// Update is called once per frame
	void Update () {
		coinSpawnTimer -= Time.deltaTime;
		enemySpawnTimer -= Time.deltaTime;
		treeSpawnTimer -= Time.deltaTime;

		if (coinSpawnTimer < 0.01 && GameInit.gameisPlaying == true) {
			SpawnCoins ();
		}
		if (enemySpawnTimer < 0.01 && GameInit.gameisPlaying == true) {
			SpawnEnemy ();
		}
		if (treeSpawnTimer < 0.01 && GameInit.gameisPlaying == true) {
			SpawnTrees ();
		}
	}

	void SpawnCoins (){
		//Instantiate a random coin prefab at a random y position
		Instantiate (coins [(Random.Range (0, coins.Length))], 
			new Vector3 (player.transform.position.x + xOffset, Random.Range (2, 8), 0),
				Quaternion.identity);

		coinSpawnTimer = Random.Range (1.0f, 3.0f);
	}

	void SpawnEnemy (){
		//change enemy scale
		enemy.transform.localScale = new Vector3 (Random.Range (1, 3.5f), Random.Range (1, 3.5f), Random.Range (1, 3.5f));

		//Instantiate new enemy at a random y position
		Instantiate (enemy, 
			new Vector3 (player.transform.position.x + xOffset, Random.Range (1, 9), 0), 
				Quaternion.identity);

		enemySpawnTimer = Random.Range (1, 5);
	}

	void SpawnTrees (){
		Instantiate (trees [(Random.Range(0, trees.Length))], 
			new Vector3 (player.transform.position.x + 70, 0, Random.Range (5, 22)),
			Quaternion.identity);
		treeSpawnTimer = 0.3f;
	}
}
