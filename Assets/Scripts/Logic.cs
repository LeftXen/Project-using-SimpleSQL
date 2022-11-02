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

    int i = 0;

    void Start()
    {

        //Create Table Players
        /* string sql6;
         sql6 = "CREATE TABLE \"Players\" " +
         "(\"PlayerID\" INTEGER PRIMARY KEY NOT NULL, " +
         "\"PlayerName\" varchar(60), " +
         "\"Score\" FLOAT";
         dbManager.Execute(sql6);*/

        /* string sql1 = "INSERT INTO StarShip " + "(PlayerID, PlayerName, Score) " + "VALUES (?, ?, ?)";
         dbManager.Execute(sql1, 1, "Nikolaos Sergis", 12f);
         string sql2 = "INSERT INTO StarShip " + "(PlayerID, PlayerName, Score) " + "VALUES (?, ?, ?)";
         dbManager.Execute(sql2, 1, "Lefteris Xenos", 22f);
         string sql3 = "INSERT INTO StarShip " + "(PlayerID, PlayerName, Score) " + "VALUES (?, ?, ?)";
         dbManager.Execute(sql3, 1, "Konstantinos Doldoukis", 2f);*/
        /*
        //print all from StarShip TABLE
        var results = dbManager.Query<SimpleSQL.Demos.Players>("SELECT * FROM StarShip");

        TextOutput.text = "";
        foreach (var result in results)
        {
            TextOutput.text += result.PlayerName + "\n";
            TextOutput.text += result.Range + "\n";

        }
        */
        /*
            string sql;
            sql = "CREATE TABLE \"StarShip\" " +
            "(\"StarShipID\" INTEGER PRIMARY KEY NOT NULL, " +
            "\"StarShipName\" varchar(60), " +
            "\"HomePlanet\" varchar(100), " +
            "\"Range\" FLOAT, " +
            "\"Armor\" FLOAT, " +
            "\"Firepower\" FLOAT)";
            dbManager.Execute(sql);
        */


        /* string sql;
         sql = "CREATE TABLE \"Players\" " +
         "(\"PlayerID\" INTEGER PRIMARY KEY NOT NULL, " +
         "\"PlayerName\" varchar(60), " +
         "\"Score\" FLOAT)";
         dbManager.Execute(sql);*/


        /* string sql1 = "INSERT INTO Players " + "(PlayerID, PlayerName, Score) " + "VALUES (?, ?, ?)";
         dbManager.Execute(sql1, 1, "Nikolaos Sergis", 12f);
         string sql2 = "INSERT INTO Players " + "(PlayerID, PlayerName, Score) " + "VALUES (?, ?, ?)";
         dbManager.Execute(sql2, 2, "Lefteris Xenos", 22f);
         string sql3 = "INSERT INTO Players " + "(PlayerID, PlayerName, Score) " + "VALUES (?, ?, ?)";
         dbManager.Execute(sql3, 3, "Konstantinos Doldoukis", 2f);*/

       /* dbManager.CreateTable<PlayerData>();

        PlayerData playerStats = new PlayerData{ PlayerID = 8, PlayerName = "yolos", Score = 500f};
        dbManager.Insert(playerStats);

        string sql = "SELECT * FROM Weapon";
        List<PlayerData> weapons = dbManager.Query<PlayerData>(sql);*/


        /*
                int row = 0;
                TextOutput.text = ""; 
                Players dt = dbManager.Query("SELECT " +
                "W.WeaponID, " +
                "W.WeaponName, " +
                "W.Damage, " +
                "W.Cost, " +
                "W.Weight, " +
                "W.WeaponTypeID, " +
                "T.Description AS
                WeaponTypeDescription " +
                "FROM " +
                "Weapon W " +
                "JOIN WeaponType T " +
                "ON W.WeaponTypeID =
                T.WeaponTypeID " +
                "ORDER BY " +
                "W.WeaponID ");
                        foreach (DataRow dr in dt.Rows)
                        {
                            text.text += "Row: " + row.ToString() + " ";
                            for (int c = 0; c < dt.Columns.Count; c++)
                            {
                                text.text += dt.Columns[c].ColumnName + "=" +
                                dr[c].ToString() + " ";
                            }
                            text.text += "\n";
                            row++;
                        }
                    }*/

        //print all from StarShip TABLE
        // var results = dbManager.Query<SimpleSQL.Demos.>("SELECT * FROM StarShip");
        /*
                TextOutput.text = "";
                foreach (var result in results)
                {
                    TextOutput.text += result.PlayerName + "\n";
                    TextOutput.text += result.Range + "\n";

                }
                */
        /*
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
        */


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
