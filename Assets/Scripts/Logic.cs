using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleSQL;
using TMPro;

public class Logic : MonoBehaviour
{
    public TMP_Text TextOutput;
    public SimpleSQLManager dbManager;

    void Start()
    {

        string sql;
        sql = "CREATE TABLE \"Player\" " +
        "(\"PlayerID\" INTEGER PRIMARY KEY NOT NULL, " +
        "\"PlayerName\" varchar(50), " +
        "\"Score\" FLOAT, ";
        dbManager.Execute(sql);

        // dbManager.CreateTable<Players>();
    }


}
