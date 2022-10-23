using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleSQL;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public SimpleSQLManager db;

    private void Awake()
    {
        //Make Singleton because we need GameManager to be in all of our scenes
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }

    }

    private int timesClicked;
    public void ClickMe()
    {
        timesClicked++;
       
       // db.Query<SimpleSQL.Demos>("SELECT * FROM Weapon");

        //sos ������ �� ������������� ���� �� 3 table (id, name, score) ���� awake ��� ������ ������
        //� �� ������� ��� ������ db ��� format ��� ����� �� SimpleSQL ��� �� ������������� �� �������� ��� 

        //var results = dbManager.Query<SimpleSQL.Demos.Weapon>("SELECT * FROM Weapon");
    }

    public void DisplayClicks()
    {
        Debug.Log(timesClicked);
    }

}