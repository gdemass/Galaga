using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GalagaMovement : MonoBehaviour
{
    public float speed = 5;

    public GameObject bullet;

    public Image[] lives;
    public int lifeCount = 3;
    bool isDouble = false;

    void Update()
    {
        
      if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(transform.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-transform.up * speed * Time.deltaTime);
        }

        // Moving left and right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-transform.right * speed * Time.deltaTime);
        }

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7f, 7f),
            Mathf.Clamp(transform.position.y, -4f, 4f),
            transform.position.z
        );
//shooting bullets
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position, Quaternion.identity);

            float offset = isDouble ? 0.7f : 0f;
            Instantiate(bullet, transform.position + new Vector3(offset, 0, 0), Quaternion.identity);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            lifeCount -= 1;
            if (lifeCount <= 0)
            {
                lifeCount = 0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            
            lives[lifeCount].enabled = false;


        }

//power up effect
if (collision.gameObject.CompareTag("PowerUp"))
    {
        //makes double bullets
        isDouble = true;

        if (lifeCount < lives.Length)
        {
            lives[lifeCount].enabled = true;
            lifeCount += 1;
            Destroy(collision.gameObject);
        }
    }

        
    }

    
}
