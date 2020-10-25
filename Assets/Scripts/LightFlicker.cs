using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    Light2D light2D;
    float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        light2D = GetComponent<Light2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        speed += 1 * Time.deltaTime;

        if (speed > 0.15f)
        {
            light2D.intensity = Random.Range(0.8f, 1.0f);
            speed = 0;
        }
    }
}
