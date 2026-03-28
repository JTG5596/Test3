using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public SpawnManager spawnManager ;
    public ItemManager ItemManager ;
    public GameObject Cover ;

    public void OnclickStartButton()
    {
        // todo

        // 커버끄기
        Cover.SetActive(false);
        // 아이템 매니저 > 아이템 생성
        ItemManager.SpawnRandom();
        // 적 생성
        spawnManager.SpawnEnemy();

    }
    
}
