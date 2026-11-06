using UnityEngine;

public class LemonSpawner : FruitSpawner
{

    public GameObject fruitPrefab;

    public override Fruit SpawnFruit()
    {

        GameObject OBJ = Instantiate(fruitPrefab, transform);
        return OBJ.GetComponent<Fruit>();
    }



}