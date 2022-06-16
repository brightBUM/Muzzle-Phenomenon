using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PerceptionSpawner : MonoBehaviour
{
    [SerializeField] Slider perceptionMeter;
    [SerializeField] float meterDecRate = 0.5f;
    [SerializeField] TextMeshProUGUI percentage;
    //[SerializeField] List<GameObject> enemyPrefabs;
    [SerializeField] int totalEnemyCount;
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

    // Start is called before the first frame update
    void Start()
    {
        perceptionMeter.value = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        meterval = perceptionMeter.value;
        // 70 60 50 40 30
        
        UpdaterMeter();
        if(meterval<70 && !spawning)
        {
            StartCoroutine(SpawnFrequency(goblinSpawnTime));
        }
    }

    private void UpdaterMeter()
    {
        percentage.text = perceptionMeter.value.ToString(".##") + "%";
        perceptionMeter.value -= Time.deltaTime * meterDecRate;
        
    }
    IEnumerator SpawnFrequency(float time)
    {
        spawning = true;
        yield return new WaitForSeconds(time);
        SpawnGoblins();
        spawning = false;

    }
    public void SpawnGoblins()
    {
        var goblinref = Instantiate(goblinPrefab, Movement.instance.transform.position + new Vector3(Random.Range(-18,18), -4.71f, Random.Range(6,goblinSpawnDistance)), 
            Quaternion.identity,this.gameObject.transform);
        enemiesToSpawn.Add(goblinref);
        
    }

    void SpawnJuggernaut()
    {

    }

}
