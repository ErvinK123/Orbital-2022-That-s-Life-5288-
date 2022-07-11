using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class DataPersistanceManager : MonoBehaviour
{
    private GameData gameData; 
    private List<IDataPersistance> dataPersistanceObjects;
    [SerializeField] private string fileName;
    private FileDataHandler dataHandler;

    public static DataPersistanceManager instance {get; private set;}

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Found more than one Data Persistance Manager in the scene");
            Destroy(this.gameObject);
            Debug.Log("Destroying");
            return;
        }
        instance = this;
        DontDestroyOnLoad(this.gameObject);

        this.dataHandler = new FileDataHandler(Application.persistentDataPath, fileName);
        this.gameData = dataHandler.Load();
    }

    public void NewGame()
    {
        this.gameData = new GameData(); 
    }

    public void LoadGame()
    {
        //TODO - Load any saved data from a file using the data handler 
        //if no data to load , initialize a new game
        this.gameData = dataHandler.Load();

        if(this.gameData == null)
        {
            Debug.Log("No data was found. Initializing data to defaults.");
            return; 
        }
        //TODO - push the loaded data to all other scripts that need it 

        foreach (IDataPersistance dataPersistanceObj in dataPersistanceObjects)
        {
            dataPersistanceObj.LoadData(gameData);
        }

        Player.scenarioWrite(Player.childList, "child");
        Player.scenarioWrite(Player.teenList, "teen");
        Player.scenarioWrite(Player.adultList, "adult");
        Player.scenarioWrite(Player.elderList, "elder");

        FriendEnemy.friendWrite(FriendEnemy.friend1List, "friend1");
        FriendEnemy.friendWrite(FriendEnemy.friend2List, "friend2");
        FriendEnemy.friendWrite(FriendEnemy.enemyList, "enemy");
    }

    public void SaveGame()
    {
        //TODO- pass the data to other scripts so they can update it
        if (this.gameData == null)
        {
            Debug.LogWarning("No data was found. A new game needs to be started before data can be saved");
        }

         
        foreach (IDataPersistance dataPersistanceObj in dataPersistanceObjects)
        {
            Debug.Log("Number of dataobj: " + dataPersistanceObjects.Count);
            dataPersistanceObj.SaveData(ref gameData);
        }
        
        dataHandler.Save(gameData);
    }

    //private void OnApplicationQuit()
    //{
    //    SaveGame();
    //}

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        SceneManager.sceneUnloaded += OnSceneUnloaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
        SceneManager.sceneUnloaded -= OnSceneUnloaded;
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        this.dataPersistanceObjects = FindAllDataPersistanceObjects();
    }

    public void OnSceneUnloaded(Scene scene)
    {
    }

    private List<IDataPersistance> FindAllDataPersistanceObjects()
    {
        IEnumerable<IDataPersistance> dataPersistanceObjects = FindObjectsOfType<MonoBehaviour>().OfType<IDataPersistance>();
        return new List<IDataPersistance>(dataPersistanceObjects);
    }

    public bool HasGameData()
    {
        return gameData != null;
    }


}
