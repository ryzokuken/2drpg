using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float attackRange;

    void Start()
    {
        if (player == null) player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        if (distance > attackRange) Debug.DrawLine(transform.position, player.transform.position);
        else Debug.DrawLine(transform.position, player.transform.position, Color.red);
    }
}
