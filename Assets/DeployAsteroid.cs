using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployAsteroid : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float respawnTime = 1.0f;
   
    private int launched = 0;

    private void OnEnable() {
      StartCoroutine(asteroidWave());
    }

    private void spawnEnemy()
    {
        GameObject a = Instantiate(asteroidPrefab) as GameObject;
        a.transform.position = new Vector3(Random.Range(-0.211f,0.217f),0.532f,-0.123f);
    }

    IEnumerator asteroidWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}

