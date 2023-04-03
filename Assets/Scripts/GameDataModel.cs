using System;
using System.Collections.Generic;
using Realms;
using MongoDB.Bson;

public class GameDataModel : RealmObject
{
    [MapTo("_id")]
    [PrimaryKey]
    public ObjectId Id { get; set; }

    [MapTo("score")]
    public int Score { get; set; }

    [MapTo("user_id")]
    [Required]
    public string UserId { get; set; }

    [MapTo("x")]
    public float X { get; set; }

    [MapTo("y")]
    public float Y { get; set; }
}

