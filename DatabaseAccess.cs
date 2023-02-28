/*

using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class DatabaseAccess : MonoBehaviour
{
    MongoClient client = new MongoClient("CONNECTIONSTRING");
    IMongoDatabase database;
    IMongoCollection<BsonDocument> collection;
    // Start is called before the first frame update
    void Start()
    {
        database = client.GetDatabase("HighScoreDB");
        collection = database.GetCollection<BsonDocument>("HighScoreCollection");
    }

    public async void SaveScoreToDataBase(string userName, int score)
    {
        var document = new BsonDocument { { userName, score } };
        await collection.InsertOneAsync(document);
    }

    public async Task<List<HighScore>> GetScoresFromDataBase()
    {
        var allScoresTask = collection.FindAsync(new BsonDocument());
        var scoresAwaited = await allScoresTask;

        List<HighScore> highscores = new List<HighScore>();
        foreach (var score in scoresAwaited.ToList())
        {
            highscores.Add(Deserialize(score.ToString()));
        }

        return highscores;
    }

    private HighScore Deserialize(string rawJson)
    {
        //Raw JsonFormat "{ \"_id\" : ObjectId(\"5e9d514b2cac3a936cd25f16\"), \"username\" : 100 }"
        var highScore = new HighScore();
        // remove ID
        var stringWitoutID = rawJson.Substring(rawJson.IndexOf("),") + 4);
        var username = stringWitoutID.Substring(0, stringWitoutID.IndexOf(":") - 2);
        var score = stringWitoutID.Substring(stringWitoutID.IndexOf(":") + 2, stringWitoutID.IndexOf("}") - stringWitoutID.IndexOf(":") - 3);
        highScore.UserName = username;
        highScore.Score = Convert.ToInt32(score);
        return highScore;
    }
}

//inline class
public class HighScore
{
    public string UserName { get; set; }
    public int Score { get; set; }
}
*/
