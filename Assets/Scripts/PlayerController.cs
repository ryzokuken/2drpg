using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerController : MonoBehaviour
{

    Vector3 destination;
    [SerializeField] float moveSpeed = 10f;
    SpriteRenderer sprite;

    void Start()
    {
        destination = transform.position;
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (transform.position != destination)
        {
            transform.position = Vector3.Lerp(transform.position, destination, Time.deltaTime * moveSpeed);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            Move(Vector2.right);
            sprite.flipX = false;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            Move(Vector2.left);
            sprite.flipX = true;
        }
        else if (Input.GetKeyUp(KeyCode.W)) Move(Vector2.up);
        else if (Input.GetKeyUp(KeyCode.S)) Move(Vector2.down);
    }

    private void Move(Vector2 direction)
    {
        if (CanMove(direction))
        {
            destination += (Vector3)direction;
        }
    }

    private bool CanMove(Vector2 direction)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, 1.0f);
        if (hit.collider == null) return true;
        return false;
    }
}
