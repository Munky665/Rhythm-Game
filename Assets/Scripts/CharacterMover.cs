using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public bool canBePressed;
    public bool move;
    public KeyCode keyToPress;

    public GameObject hitEffect, goodEffect, perfectEffect, missEffect;
    public CircleCollider2D circleCol;
    public GameObject player;

    SpriteRenderer s_renderer;
    // Start is called before the first frame update
    void Start()
    {
        s_renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canBePressed)
        {
            s_renderer.color = Color.green;
        }
        else
        {
            s_renderer.color = Color.red;
        }

        if (Input.GetKeyDown(keyToPress))
        {
            if (canBePressed && Mathf.Abs(transform.localPosition.x) > 0)
            {
                MovePositionX();

            }
            else if (canBePressed && Mathf.Abs(transform.localPosition.y) > 0)
            {
                MovePositionY();

            }
            
        }

    }

    void MovePositionX()
    {
        if (transform.localPosition.x > 0)
        {
            player.transform.position += new Vector3(1, 0, 0);
            move = true;
        }
        else
        {
            player.transform.position -= new Vector3(1, 0, 0);
            move = true;
        }
    }
    void MovePositionY()
    {
        if (transform.localPosition.y > 0)
        {
            player.transform.position += new Vector3(0, 1, 0);
            move = true;
        }
        else
        {
            player.transform.position -= new Vector3(0, 1, 0);
            move = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator" && this.gameObject.activeSelf == true)
        {
            canBePressed = false;
        }
    }

}