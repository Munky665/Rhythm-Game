using System.Collections;
using System.Collections.Generic;
using System.Threading;

using UnityEngine;

public class BeatMover : MonoBehaviour
{
    public static float beatTempo;
    public float distance;

    public bool hasStarted;
    public bool forward;

    public List<GameObject> movementColliders;
    public List<GameObject> movementTiggers;

    public GameObject beatBarLeft;
    public GameObject beatBarRight;

    Vector3 rightBeatSpwan;
    Vector3 leftBeatSpawn;

    // Start is called before the first frame update
    void Start()
    {
        beatTempo = beatTempo / 60;

        rightBeatSpwan = beatBarRight.transform.position;
        leftBeatSpawn = beatBarLeft.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < movementTiggers.Count; i++)
        {
            if (movementColliders[i].GetComponent<CharacterMover>().move == true)
            {
                foreach (GameObject g in movementColliders)
                {
                    g.GetComponent<CircleCollider2D>().offset = new Vector2(0, 0);
                    g.GetComponent<CharacterMover>().move = false;
                }
            }
            switch (i)
            {
             case 0:
                 movementColliders[i].GetComponent<CircleCollider2D>().offset += new Vector2(beatTempo * Time.deltaTime,0f);
                 if (movementColliders[i].GetComponent<CircleCollider2D>().offset.x > 1.5f)
                 {
                     movementColliders[i].GetComponent<CircleCollider2D>().offset = new Vector2(0, 0);
                 }
                 break;
             case 1:
                 movementColliders[i].GetComponent<CircleCollider2D>().offset -= new Vector2(beatTempo * Time.deltaTime,0f);
                 if (Mathf.Abs(movementColliders[i].GetComponent<CircleCollider2D>().offset.x) > 1.5f)
                 {
                     movementColliders[i].GetComponent<CircleCollider2D>().offset = new Vector2(0, 0);
                 }
                 break;
             case 2:
                 movementColliders[i].GetComponent<CircleCollider2D>().offset += new Vector2(0f, beatTempo *Time.deltaTime);
                 if (Mathf.Abs(movementColliders[i].GetComponent<CircleCollider2D>().offset.y) > 1.5f)
                 {
                     movementColliders[i].GetComponent<CircleCollider2D>().offset = new Vector2(0, 0);
                 }
                 break;
             case 3:
                 movementColliders[i].GetComponent<CircleCollider2D>().offset -= new Vector2(0f, beatTempo *Time.deltaTime);
                 if (Mathf.Abs(movementColliders[i].GetComponent<CircleCollider2D>().offset.y) > 1.5f)
                 {
                     movementColliders[i].GetComponent<CircleCollider2D>().offset = new Vector2(0, 0);
                 }
                 break;
            }

        }
              
   }
}
