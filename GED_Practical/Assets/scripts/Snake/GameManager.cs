using Chapter.Singleton;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{


    public FruitSpawner applespawner;
    public FruitSpawner lemonspawner;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Fruit apple = applespawner.SpawnFruit();
        apple.transform.position = transform.position + new Vector3(1, 4, 1);
        Fruit lemon = lemonspawner.SpawnFruit();
        apple.transform.position = transform.position + new Vector3(4, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
