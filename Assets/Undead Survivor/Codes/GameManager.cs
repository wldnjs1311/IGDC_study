using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public PoolManager pool;
    public Player player; //�÷��̾� ������Ʈ ������ ����

    private void Awake()
    {
        instance = this;
    }
}
