using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMover : MonoBehaviour
{
    public bool canBePressed;
    public bool move;
    public KeyCode keyToPress;

    public GameObject hitEffect, goodEffect, perfectEffect, missEffect;
    public CircleCollider2D circleCol;
    public GameObject player;

    public Image beatMarker;
    public Sprite downButton;
    public Sprite defaultButton;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if (canBePressed && Mathf.Abs(circleCol.offset.x) > 0)
            {
                MovePositionX();

            }
            else if (canBePressed && Mathf.Abs(circleCol.offset.y) > 0)
            {
                MovePositionY();

            }
            
        }

        if (beatMarker != null)
        {
            if (canBePressed)
            {
                beatMarker.sprite = downButton;
            }
            else
            {
                beatMarker.sprite = defaultButton;
            }
        }
    }

    void MovePositionX()
    {
        if (circleCol.offset.x > 0)
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
        if (circleCol.offset.y > 0)
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