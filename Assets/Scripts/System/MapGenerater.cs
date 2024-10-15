using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerater : MonoBehaviour
{
    private float _subseed = 3141592653; //�õ尪�� 11���� �̻� ��� ���
    public float subSeed
    {
        get { return _subseed; }
    }

    private float _seed;
    public float Seed
    {
        get
        {
            return _seed;
        }
        private set
        {
            _seed = value;
        }
    }
    private void Start()
    {
        NewGame();
    }

    public void NewGame()
    {
        //���� ����� �õ�
        System.Random randSeed = new System.Random();
        int seed = randSeed.Next();

        Debug.Log(seed);

    }
}
