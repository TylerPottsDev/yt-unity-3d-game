using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour {
    [SerializeField] Vector3[] spawnPoints;
    [SerializeField] GameObject blockPrefab;
    [SerializeField] ScoreCounter sc;
    [SerializeField] float[] spawnRates;
    float spawnRate;

    private void Start() {
        spawnRate = spawnRates[0];
        StartCoroutine(Spawn());
    }

    private void Update() {
        if (sc.score > 10 && spawnRate == spawnRates[0]) {
            spawnRate = spawnRates[1];
        } else if (sc.score > 20 && spawnRate == spawnRates[1]) {
            spawnRate = spawnRates[2];
        } else if (sc.score > 30 && spawnRate == spawnRates[2]) {
            spawnRate = spawnRates[3];
        }
    }

    IEnumerator Spawn() {
        while (true) {
            float spawnTime = Random.Range(spawnRate - 0.5f, spawnRate + 0.5f);
            yield return new WaitForSeconds(spawnTime);
            Instantiate(blockPrefab, spawnPoints[Random.Range(0, spawnPoints.Length)], Quaternion.identity);
        }
    }
}
