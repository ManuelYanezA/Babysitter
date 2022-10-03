using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float speed = 2.5f;
    [SerializeField] private Vector2 direction;

    void Update()
    {
        direction = player.transform.position - transform.position;
        if(direction.x <= 0)
        {
            transform.localScale = new Vector2(-1f, 1f);
        }
        else
        {
            transform.localScale = new Vector2(1f, 1f);
        }
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
}
