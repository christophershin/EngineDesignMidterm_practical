using UnityEngine;

public class AppleSpawner : FruitSpawner
{

    public GameObject fruitPrefab;

    public override Fruit SpawnFruit()
    {

        GameObject OBJ = Instantiate(fruitPrefab, transform);
        return OBJ.GetComponent<Fruit>();
    }



}