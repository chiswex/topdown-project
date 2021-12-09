using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int dmg = 1;
    public int hearts = 4;
    public int maxHearts = 8;
    [SerializeField] HealthSystem hs;

    private void Start()
    {
        hs.DrawHearts (hearts, maxHearts);
    }
    public void DamagePlayer (int dmg)
    {
        if(hearts > 0)
        {
            hearts -= dmg;
            hs.DrawHearts(hearts, maxHearts);
        }
        else
        {
            //GameController.instance.Respawn();
            SceneManager.LoadScene("GameOverScreen");
        }
    }
    public void HealPlayer(int dmg)
    {
        if (hearts < maxHearts)
        {
            hearts += dmg;
            hs.DrawHearts(hearts, maxHearts);
        }
    }
}