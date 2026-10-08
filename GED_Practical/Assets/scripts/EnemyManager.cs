using System;
using System.Collections;
using System.Threading.Tasks;
using Chapter.Singleton;
using NUnit.Framework;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Chapter.Singleton
{

    public class EnemyManager : Singleton<EnemyManager>
    {


        public EnemySpawner ghostEnemySpawner;
        public EnemySpawner boxEnemySpawner;



        [HideInInspector]
        public bool gameEnded = false;
        public bool gameWin = false;



        private void Start()
        {
            
            Enemy enemy = ghostEnemySpawner.SpawnEnemy();
            Enemy box = boxEnemySpawner.SpawnEnemy();
        }

        private void Update()
        {

        }



        public void NextScene()
        {
            SceneManager.LoadScene(1);
        }



        private IEnumerator GameEnded()
        {


            yield return new WaitForSeconds(1);


        }






    }


}
