using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class PerceptionSpawner : MonoBehaviour
{
    [SerializeField] Slider perceptionMeter;
    [SerializeField] float meterDecRate = 0.5f;
    [SerializeField] TextMeshProUGUI percentage;
    //[SerializeField] List<GameObject> enemyPrefabs;
    [SerializeField] int totalEnemyCount = 6;
    [SerializeField] public int currentEnemyCount;
    [SerializeField] List<GameObject> enemiesToSpawn;

    [Header("GoblinSpawnstats")]
    [SerializeField] GameObject goblinPrefab;
    [SerializeField] float goblinSpawnDistance;
    //[SerializeField] float goblinSpawnDistanceFar;
    [SerializeField] float goblinSpawnTime;
    [SerializeField] float goblinCount;
    //[SerializeField] Movement playerRef;
    bool spawning = false;
    float meterval;
    public static PerceptionSpawner instance;
    public enum EnemeyTypes
    {
        GOBLIN,
        GRUNT,
        JUGGERNAUT
    }
    public EnemeyTypes enemyType;
    private void Awake()
    {
        if (instance != this && instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        //SceneManager.sceneLoaded += OnSceneLoaded;

    }
    // Start is called before the first frame update
    void Start()
    {
        perceptionMeter.value = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        meterval = perceptionMeter.value;
        // 20 50 70
        
        UpdaterMeter();
        if(currentEnemyCount < totalEnemyCount)
        {
            if (meterval > 20 && !spawning)
            {
                StartCoroutine(SpawnFrequency(goblinSpawnTime,EnemeyTypes.GOBLIN));
            }
            if (meterval > 50  && !spawning)
            {
                StartCoroutine(SpawnFrequency(goblinSpawnTime,EnemeyTypes.GRUNT));
            }
            if (meterval > 70 && !spawning)
            {
                StartCoroutine(SpawnFrequency(goblinSpawnTime, EnemeyTypes.GRUNT));
            }

        }

    }

    private void UpdaterMeter()
    {
        percentage.text = perceptionMeter.value.ToString(".##") + "%";
        perceptionMeter.value -= Time.deltaTime * meterDecRate;
        if(perceptionMeter.value<=0)
        {
            SceneManager.LoadScene("Maze0");
        }
    }
    IEnumerator SpawnFrequency(float time,EnemeyTypes enemytype)
    {
        spawning = true;
        yield return new WaitForSeconds(time);
        switch(enemyType)
        {
            case EnemeyTypes.GOBLIN:
                SpawnGoblins();
                break;
            case EnemeyTypes.GRUNT:
                SpawnGrunt();
                break;
            case EnemeyTypes.JUGGERNAUT:
                SpawnJuggernaut();
                break;
        }
        spawning = false;

    }
    public void SpawnGoblins()
    {
        var goblinref = Instantiate(goblinPrefab, this.gameObject.transform);
        goblinref.transform.position = Movement.instance.transform.position + new Vector3(Random.Range(-18, 18), 0, Random.Range(6, goblinSpawnDistance));
        enemiesToSpawn.Add(goblinref);
        currentEnemyCount++;
        
    }
    void SpawnProbability(float min,float max)
    {
        float temp = Random.Range(min, max);
        for(int i=0;i<totalEnemyCount;i++)
        {
            temp = Random.Range(min, max);//min and max 
            if(temp>0f && temp<0.5f)
            {

            }
            else if (temp > 0.5f && temp < 1f)
            {

            }
            else if (temp > 1f && temp < 1.5f)
            {

            }
        }
    }

    void SpawnJuggernaut()
    {

    }
    void SpawnGrunt()
    {

    }

    public void IncreasePerMeter(float amount)
    {
        perceptionMeter.value += 5f;
    }

}
