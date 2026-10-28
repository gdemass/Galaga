using UnityEngine;

public class PowerWaveSPWN : MonoBehaviour
{
    public GameObject [] PowerUp;

        public float waveTimer = 0;
        public float waveWait = 7;
        public float speed = 10;
        public float xRange = 7f;
        public float zRange = 7f;      

    void Update()
    {
        waveTimer += Time.deltaTime;
        if(waveTimer > waveWait)
        {   
        waveTimer = 0;
       Instantiate(PowerUp[Random.Range(0, PowerUp.Length)],
       new Vector3(transform.position.x + Random.Range(-xRange, xRange), transform.position.y,
       transform.position.z + Random.Range(-zRange, zRange)), Quaternion.identity
    );
        }
          
    }

}
