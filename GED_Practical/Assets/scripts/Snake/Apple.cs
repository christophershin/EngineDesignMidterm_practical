using UnityEngine;

public class Apple : Fruit
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Fruitname = "Apple";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void printName()
    {
        Debug.Log(Fruitname);
    }
}
