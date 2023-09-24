using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public PoolManager pool;
    public Player player; //플레이어 오브젝트 저장할 변수

    private void Awake()
    {
        instance = this;
    }
}
