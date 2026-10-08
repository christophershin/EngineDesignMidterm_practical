using UnityEngine;

public abstract class Enemy : MonoBehaviour
{

    protected Rigidbody rb;



    protected void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    public abstract void attack();


}