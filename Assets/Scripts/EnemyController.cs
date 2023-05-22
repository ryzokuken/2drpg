using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] GameObject player;

    void Start()
    {
        if (player == null) player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        Debug.DrawLine(transform.position, player.transform.position);
    }
}
