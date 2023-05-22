using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    [SerializeField] Transform player;

    void Update()
    {
        if ((Vector2)transform.position != (Vector2)player.position)
        {
            transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
        }
    }
}
