using UnityEngine;

public class BulletShip : MonoBehaviour

{
    public float speed = 3;
    public GameObject bullet;

    public GameObject Explosion;

    public float bulletTimer = 0;
    public float bulletWait = 3;


    void Update()
    {
      transform.Translate(-transform.up * speed * Time.deltaTime);  

      bulletTimer += Time.deltaTime;
      if(bulletTimer > bulletWait)
      {
       bulletTimer = 0;
       Instantiate(bullet, transform.position - new Vector3 (0, .5f , 8), Quaternion.identity);
      }
      if(transform.position.y < -6)
         {
            Destroy(gameObject);
         } 
    }

private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("PlayerBullet"))
        {
            Destroy(collision.gameObject);
            GameObject temp = Instantiate(Explosion, transform.position, Quaternion.identity);
            Destroy(temp, 1.0f);
            Destroy(gameObject);
        }
    }

}