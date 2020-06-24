using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class TestScript
    {

        public Ball ball;
        public Paddle paddle;
        bool etat = false;
        GameSession gameSession;

        [SetUp]
        public void Setup()
        {
            SceneManager.LoadScene(1);
        }


        [UnityTest]
        public IEnumerator Test_2vies()
        {
            LoseCollider.lives = 3;
            while (LoseCollider.lives != 2)
            {
                Paddle.paddle.theBall.LaunchWithFunction();
                yield return new WaitForSeconds(4.0f);
            }
            Assert.AreEqual(2, LoseCollider.lives);
        }


        [UnityTest]
         public IEnumerator Test_3vies()
         {
             LoseCollider.lives = 3;
             Paddle.paddle.theBall.LaunchWithFunction();
             Paddle.paddle.theGameSession.isAutoPlayEnabled = true;
             yield return new WaitForSeconds(5.1f);
             Assert.AreEqual(3, LoseCollider.lives);
         }

        


    }
}
