using System.Threading;
using Chapter.Singleton;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{


    public FruitSpawner applespawner;
    public FruitSpawner lemonspawner;



    private float timer = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;


        if(timer<=0)
        {
            Fruit apple = applespawner.SpawnFruit();
            apple.transform.position = transform.position + new Vector3(Random.Range(1,5), 4, 1);
            Fruit lemon = lemonspawner.SpawnFruit();
            apple.transform.position = transform.position + new Vector3(4, Random.Range(1,5), 1);

            timer = 3;
        }
    }
}
