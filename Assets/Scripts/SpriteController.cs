using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    UP,
    DOWN,
    LEFT,
    RIGHT
}

public class SpriteController : MonoBehaviour
{
    public Direction direction;
    SpriteRenderer s_renderer;
    // Start is called before the first frame update
    void Start()
    {
        s_renderer = GetComponent<SpriteRenderer>();
        switch (direction)
        {
            case Direction.UP:
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, 90));
                break;
            case Direction.DOWN:
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, -90));
                break;
            case Direction.LEFT:
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, 180));
                break;
            case Direction.RIGHT:
                break;
            default:
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
