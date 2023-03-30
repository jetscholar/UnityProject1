using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Realms;

public class RealmController : MonoBehaviour
{

    static public RealmController Instance;

    private Realm _realm;

    private void Awake() 
    {
    DontDestroyOnLoad(gameObject);
    Instance = this;
    if(_realm == null) {
        _realm = Realm.GetInstance();
    }
    }

    private void OnDisable() 
    {
    _realm.Dispose();   
    }

    private GameDataModel GetOrCreateGameData()
    {
        GameDataModel gameDataModel = _realm.Find<GameDataModel>("nraboy");
        if(gameDataModel == null) {
            _realm.Write(() => {
                gameDataModel = _realm.Add(new GameDataModel() 
                {
                    Id = "nraboy",
                    Score = 0,
                    X = 0,
                    Y = 0
                });
            });
        }
        return gameDataModel;
    }

    public int GetScore()
    {
        GameDataModel gameDataModel = GetOrCreateGameData();
        return gameDataModel.Score;
    }

    public Vector2 GetPosition() 
    {
        GameDataModel gameDataModel = GetOrCreateGameData();
        return new Vector2(gameDataModel.X, gameDataModel.Y);
    }    

}
