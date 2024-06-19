using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    [SerializeField]
    private TextMeshProUGUI text;

    private int coin = 0;

    void Awake() {
        if (instance == null){
            instance = this;
        }    
    }

    public void IncreaseCoin(){
        coin += 1;
        text.SetText(coin.ToString());

        if(coin % 30 == 0){
            Player player = FindObjectOfType<Player>();
            if(player != null){
                player.Upgrade();
            }
        }
    }

    public void SetGameOver(){
        Enemyspawner enemyspawner = FindObjectOfType<Enemyspawner>();

        if (enemyspawner != null){
            enemyspawner.StopEnemyRoutine();
        }
    }
}
