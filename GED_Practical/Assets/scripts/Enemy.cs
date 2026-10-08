using UnityEngine;

public abstract class Enemy : MonoBehaviour
{

    protected Rigidbody2D rb;



    protected void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    public abstract void attack();


}