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


        [HideInInspector]
        public bool gameEnded = false;
        public bool gameWin = false;


        public GameObject player;
        public GameObject respawnPlatform;


        //UI
        [SerializeField]
        private TextMeshProUGUI conditionText;


        private void Start()
        {


        }

        private void Update()
        {
            if (gameEnded)
            {
                StartCoroutine(GameEnded());

            }
            else if (gameWin)
            {
                conditionText.text = "YOU WIN!!";
                NextScene();
            }

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
