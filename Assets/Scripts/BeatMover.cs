using System.Collections.Generic;

using UnityEngine;

public class BeatMover : MonoBehaviour
{
    public float beatTempo;
    public float distance;

    public bool forward;

    public List<GameObject> movementColliders;
    public List<GameObject> movementTiggers;


    // Start is called before the first frame update
    void Start()
    {
        beatTempo = beatTempo / 60;
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
                    g.transform.localPosition = new Vector3(0, 0);
                    g.GetComponent<CharacterMover>().move = false;
                }
            }
            switch (i)
            {
             case 0:
                 movementColliders[i].transform.localPosition += new Vector3(beatTempo * Time.deltaTime,0f);
                 if (movementColliders[i].transform.localPosition.x > 1.5f)
                 {
                     movementColliders[i].transform.localPosition = new Vector3(0, 0);
                 }
                 break;
             case 1:
                 movementColliders[i].transform.localPosition -= new Vector3(beatTempo * Time.deltaTime,0f);
                 if (Mathf.Abs(movementColliders[i].transform.localPosition.x) > 1.5f)
                 {
                     movementColliders[i].transform.localPosition = new Vector3(0, 0);
                 }
                 break;
             case 2:
                 movementColliders[i].transform.localPosition += new Vector3(0f, beatTempo * Time.deltaTime);
                 if (Mathf.Abs(movementColliders[i].transform.localPosition.y) > 1.5f)
                 {
                     movementColliders[i].transform.localPosition = new Vector3(0, 0);
                 }
                 break;
             case 3:
                 movementColliders[i].transform.localPosition -= new Vector3(0f, beatTempo * Time.deltaTime);
                 if (Mathf.Abs(movementColliders[i].transform.localPosition.y) > 1.5f)
                 {
                     movementColliders[i].transform.localPosition = new Vector2(0, 0);
                 }
                 break;
            }

        }
              
   }
}
