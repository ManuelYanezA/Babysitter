using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTeleport : MonoBehaviour
{
    
    public GameObject Player;
    private Vector2 teleportPosition;
    private float teleportX;
    private float teleportY; 

    void Start()
    {
        InvokeRepeating("RandomTeleport", 10.0f, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RandomTeleport()
    {
        do
        {
            teleportX = Random.Range(-30f, 60f);
            teleportY = Random.Range(16f, -10f);
        }while((teleportX < Player.transform.position.x + 4 && teleportX > Player.transform.position.x - 4) || (teleportY < Player.transform.position.y + 4 && teleportY > Player.transform.position.y - 4));
        teleportPosition = new Vector2(teleportX, teleportY);
        transform.position = teleportPosition;
    }
}
