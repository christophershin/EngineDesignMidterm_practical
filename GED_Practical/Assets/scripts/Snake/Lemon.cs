using UnityEngine;

public class Leomon : Fruit
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        name = "Lemon";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void printName()
    {
        Debug.Log(name);
    }
}
