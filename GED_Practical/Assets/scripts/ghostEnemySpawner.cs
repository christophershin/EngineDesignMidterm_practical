using UnityEngine;

public class ghostEnemySpawner : EnemySpawner
{

    public GameObject enemyPrefab;

    public override Enemy SpawnEnemy()
    {

        GameObject enemyOBJ = Instantiate(enemyPrefab, transform);
        return enemyOBJ.GetComponent<Enemy>();
    }
}
