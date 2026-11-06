using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class SnakeMovement : MonoBehaviour

{
    public GameObject snakebody;
    public float moveSpeed = 1f;

    private void Update()

    {

        float horizontalInput = Input.GetAxis("Horizontal");

        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0);

        transform.position += moveDirection * moveSpeed * Time.deltaTime;

    }




}