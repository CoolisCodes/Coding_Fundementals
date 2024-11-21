using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update


    
    public int gameDifficulty = 0;
    public GroundMover groundMover;

    public SpaceshipMover spaceshipMover;

    public GameObject cometPrefab;

    public Transform cometSpawnPoint;
    void Start()
    {
        GameObject newComet = Instantiate(cometPrefab);
        newComet.transform.position = cometSpawnPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
