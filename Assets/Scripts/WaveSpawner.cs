using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public GameObject [] enemyWaves;

        public float waveTimer = 0;
    public float waveWait = 3;

    // Update is called once per frame
    void Update()
    {

        waveTimer += Time.deltaTime;
        if(waveTimer > waveWait)
        {   
        waveTimer = 0;
        Instantiate(enemyWaves[Random.Range(0, enemyWaves.Length -1)], transform.position, Quaternion.identity);
        }
    }
}

