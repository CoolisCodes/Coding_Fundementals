using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public SpaceshipMover spaceship;

    public GameObject cometPrefab;  // Enemy prefab for spawning
    public Transform[] spawnPoints; // Locations where enemies will spawn
    public int initialEnemiesPerWave = 5;  // Number of enemies to spawn initially
    public float spawnInterval = 2f;       // Time between enemy spawns
    public float difficultyIncreaseInterval = 30f;  // How often to increase difficulty (in seconds)

    public int currentWave = 1;  // The current wave number
    public int enemiesRemaining; // Number of enemies remaining in the current wave
    public float currentEnemySpeed; // Current speed of enemies
    private float currentSpawnInterval;  // Current time between spawns

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        //AccountManager.instance.Login();
        currentSpawnInterval = spawnInterval;
        StartCoroutine(StartWave());
        StartCoroutine(IncreaseDifficultyOverTime());
    }

    // Start a new wave
    private IEnumerator StartWave()
    {
        enemiesRemaining = initialEnemiesPerWave + (currentWave - 1) * 2;  // Increase number of enemies with each wave

        for (int i = 0; i < enemiesRemaining; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(currentSpawnInterval);
        }

        // Wait until all enemies are destroyed before starting the next wave
        yield return new WaitUntil(() => FindObjectsOfType<Comet>().Length == 0);  // Wait until all enemies are gone
        currentWave++;  // Increment wave number
        StartCoroutine(StartWave());  // Start the next wave
    }

    // Spawn an enemy at a random spawn point
    private void SpawnEnemy()
    {
        int spawnIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(cometPrefab, spawnPoints[spawnIndex].position, Quaternion.identity);
    }

    // Coroutine to increase difficulty over time
    private IEnumerator IncreaseDifficultyOverTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(difficultyIncreaseInterval);

            // Increase the enemy speed and decrease spawn interval (difficulty mechanics)
            currentEnemySpeed += 0.5f;  // Increase enemy speed
            currentSpawnInterval = Mathf.Max(0.5f, currentSpawnInterval - 0.1f);  // Decrease spawn interval (up to a limit)

        }
    }

    // Method to get current game difficulty settings
    public float GetEnemySpeed()
    {
        return currentEnemySpeed;
    }

    public float GetSpawnInterval()
    {
        return currentSpawnInterval;
    }
}
