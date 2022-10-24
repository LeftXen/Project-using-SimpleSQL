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
        sql = "CREATE TABLE \"StarShip\" " +
        "(\"StarShipID\" INTEGER PRIMARY KEY NOT NULL, " +
        "\"StarShipName\" varchar(60), " +
        "\"HomePlanet\" varchar(100), " +
        "\"Range\" FLOAT, " +
        "\"Armor\" FLOAT, " +
        "\"Firepower\" FLOAT)";
        dbManager.Execute(sql);

        sql = "CREATE INDEX \"StarShip_StarShipName\" on \"StarShip\"(\"StarShipName\")";
        dbManager.Execute(sql);


        string sql3 = "INSERT INTO StarShip " + "(StarShipID, StarShipName, HomePlanet, Range, Armor, Firepower) " + "VALUES (?, ?, ?, ?, ?, ?)";
        dbManager.Execute(sql3, 40, "Enterprize", "Ermis", 12f, 50f, 60f);

        string sql4 = "INSERT INTO StarShip " + "(StarShipID, StarShipName, HomePlanet, Range, Armor, Firepower) " + "VALUES (?, ?, ?, ?, ?, ?)";
        dbManager.Execute(sql4, 50, "SersSpaceship", "Ermis", 17f, 50f, 60f);

        //print all from StarShip TABLE
        var results = dbManager.Query<SimpleSQL.Demos.StarShip>("SELECT * FROM StarShip");

        TextOutput.text = "";
        foreach (var result in results)
        {
            TextOutput.text += result.StarShipName + "\n";
            TextOutput.text += result.Range + "\n";

        }


        // dbManager.CreateTable<Players>();

        /* string sql = "INSERT INTO Player " +
         "(nameid, playername, score) " +
         "VALUES (?, ?, ?)";
         dbManager.Execute(sql, 1, "nikos", 50);*/

        /*Players.Player playerstuff = new Players()
        {
            nameid = 1, playername = "nikos", score = 500};
        dbManager.Insert(playerstuff);*/


    }


}
