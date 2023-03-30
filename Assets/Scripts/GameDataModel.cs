using System.Collections;
using System.Collections.Generic;
using Realms;
using MongoDB.Bson;

public class GameDataModel : RealmObject
{

    [PrimaryKey]
    public string Id { get; set; }

    public int Score { get; set; }

    public float X { get; set; }

    public float Y { get; set; }

}
