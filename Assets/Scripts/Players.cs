using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleSQL;

public class Players : MonoBehaviour
{
   
public class Weapon
{
    // The WeaponID field is set as the primary key in the SQLite database,
    // so we reflect that here with the PrimaryKey attribute
    [PrimaryKey]
    public int PlayerID { get; set; }
        public string PLayerName { get; set; }
        public float Score { get; set; }
}

}
