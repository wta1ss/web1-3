using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int age;
        age = 30;
        float height1 = 160.5f;
        float height2;
        height2 = height1;
        string name;
        name = "kitamura";
        int answer;
        answer = 1 + 2;
        answer++;
        string str1 = "happy";
        string str2 = "birthday";
        string message;
        message = str1 + str2;
        int herbNum = 1;
        int hp = 200;


        //Hello,worldをコンソールウィンドウに表示する
        Debug.Log("Hello,World");
        Debug.Log(age);
        Debug.Log(height2);
        Debug.Log(name);
        Debug.Log(answer);
        Debug.Log(message);
        if(herbNum==1)
        {
            Debug.Log("HPが50回復");
        }
        if(hp>=100)
        {
            Debug.Log("攻撃");
        }
        else
        {
            Debug.Log("防御");
        }
        for(int i=0;i<5;i++)
        {
            Debug.Log(i);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
