using UnityEngine;
using System.Collections;

public class BatSpawner : MonoBehaviour {

	public GameObject batPrefab;

	void Start() {
		//InvokeRepeating("SpawnBat", 10, 10);
		SpawnBats();
	}

	private void SpawnBats() {
		for (int i = 0; i < 2; i++) {
			for (int j = 0; j < 2; j++) {
				SpawnBat(i * 2f, j*2f);
			}
		}
	}

	private void SpawnBat(float xPos, float yPos) {
		GameObject batClone = (GameObject)Instantiate(batPrefab, new Vector2 (xPos, yPos), Quaternion.identity);
	}
}
