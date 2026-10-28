using UnityEngine;

public class NewMonoBehavioBackgroundScroller : MonoBehaviour
{

    public float speed = 2f;
    
    //var1 is the positiont to check the hight of the background and var2 is the position to reset the background to
    public float var1 = -5;

    public float var2 = 16;


    // Update is called once per frame
    void Update()
    {
       transform.Translate (-transform.up * speed * Time.deltaTime);
        if (transform.position.y < var1)
        
            transform.position = new Vector3(transform.position.x, var2, transform.position.z);
        
    }
}
