using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int hp = 100;
    private int power = 50;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }
    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "のダメージを受けた");
    }
}

public class Test2 : MonoBehaviour {

    void SayHello()
    {
        Debug.Log("Hello");
    }

    void CallName(string name)
    {
        Debug.Log("Hello " + name);
    }

    int Add(int a,int b)
    {
        int c = a + b;
        return c;
    }
	// Use this for initialization
	void Start () {
        //int[] array = new int[5];

        //array[0] = 2;
        //array[1] = 10;
        //array[2] = 5;
        //array[3] = 15;
        //array[4] = 3;

        //for(int i=0;i<5;i++)
        //{
        //    Debug.Log(array[i]);
        //}
        int[] points = { 83, 99, 52, 93, 15 };
        int answer;
        answer = Add(2, 3);
        Player myPlayer = new Player();
        Vector2 playerPos = new Vector2(3.0f, 4.0f);
        playerPos.x += 8.0f;
        playerPos.y += 5.0f;
        Vector2 startPos = new Vector2(2.0f, 1.0f);
        Vector2 endPos = new Vector2(8.0f, 5.0f);
        Vector2 dir = endPos - startPos;


        for(int i=0;i<points.Length;i++)
        {
            if(points[i]>=90)
            {
                Debug.Log(points[i]);
            }
        }

        SayHello();

        CallName("Tom");

        Debug.Log(answer);

        myPlayer.Attack();
        myPlayer.Damage(30);

        Debug.Log(playerPos);

        Debug.Log(dir);

        float len = dir.magnitude;
        Debug.Log(len);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
