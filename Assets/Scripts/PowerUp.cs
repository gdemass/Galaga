using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float speed = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.CompareTag("GalagaPlayer"))
        {
            Destroy(gameObject);  
        }

    }
}
