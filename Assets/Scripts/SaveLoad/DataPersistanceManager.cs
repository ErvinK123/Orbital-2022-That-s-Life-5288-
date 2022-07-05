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

        Player.setUpScenarios(Player.childScene, Player.teenScene, Player.teen1frScene, Player.teen2frScene, Player.teen1enScene,
                              Player.adultScene, Player.adult1frScene, Player.adult2frScene, Player.adult1enScene, Player.elderlyScene, Player.elderly1frScene,
                              Player.elderly2frScene, Player.elderly1enScene);
        Player.allocateScenarios(Player.randomizeArray(childScenario.childArr), "Child");
        Player.allocateScenarios(Player.generateArray(teenScenario.teenArr, teen1frScenario.teen1frArr, teen2frScenario.teen2frArr, teen1enScenario.teen1enArr), "Teen");
        Player.allocateScenarios(Player.generateArray(adultScenario.adultArr, adult1frScenario.adult1frArr, adult2frScenario.adult2frArr, adult1enScenario.adult1enArr), "Adult");
        Player.allocateScenarios(Player.generateArray(elderScenario.elderArr, elder1frScenario.elder1frArr, elder2frScenario.elder2frArr, elder1enScenario.elder1enArr), "Elder");
        FriendEnemy.initializeFEPool();
        Debug.Log("I have finished setting up scenarios");
        //Debug.Log("Loaded Scenario count: " + gameData.scenarios);
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
            dataPersistanceObj.SaveData(ref gameData);
        }
        
        dataHandler.Save(gameData);
    }

    private void OnApplicationQuit()
    {
        SaveGame();
    }
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
        LoadGame();
    }

    public void OnSceneUnloaded(Scene scene)
    {
        SaveGame();
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
