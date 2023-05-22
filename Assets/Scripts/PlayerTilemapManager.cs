using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.U2D;

public class PlayerTilemapManager : MonoBehaviour
{
    Vector3Int playerPosition;
    [SerializeField] Tilemap playerTilemap;
    [SerializeField] Tile playerTile;

    void Start()
    {
        playerPosition = Vector3Int.zero;
    }

    void Update()
    {
        playerTilemap.ClearAllTiles();
        playerTilemap.SetTile(playerPosition, playerTile);
        if (Input.GetKeyUp(KeyCode.D))
        {
            playerPosition += Vector3Int.right;
            playerTile.gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            playerPosition += Vector3Int.left;
            playerTile.gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (Input.GetKeyUp(KeyCode.W)) playerPosition += Vector3Int.up;
        else if (Input.GetKeyUp(KeyCode.S)) playerPosition += Vector3Int.down;
    }
}
