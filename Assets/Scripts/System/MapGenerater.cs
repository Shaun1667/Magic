using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerater : MonoBehaviour
{
    private float _subseed = 3141592653; //시드값을 11진수 이상 사용 고려
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
        //새로 사용할 시드
        System.Random randSeed = new System.Random();
        int seed = randSeed.Next();

        Debug.Log(seed);

    }
}
