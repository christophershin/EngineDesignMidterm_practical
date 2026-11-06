using UnityEngine;

public class SnakeMovement : MonoBehaviour

{
    public GameObject snakebody;
    public float moveSpeed = 1f;



    private void Start()
    {
        GameObject b = Instantiate(snakebody, transform);
        b.GetComponent<SnakeBody>().parent = this.gameObject;
    }



    private void Update()

    {

        float horizontalInput = Input.GetAxis("Horizontal");

        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0);

        transform.position += moveDirection * moveSpeed * Time.deltaTime;

    }




}