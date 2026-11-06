using UnityEngine;

public class SnakeBody : MonoBehaviour
{


    public GameObject parent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       if(Vector2.Distance(transform.position, parent.transform.position) > 1)
        {
            transform.position = Vector3.Lerp(transform.position, parent.transform.position, 5 * Time.deltaTime);
        }
        
    }
}
