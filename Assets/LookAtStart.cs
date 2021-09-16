using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtStart : MonoBehaviour
{
    public GameObject camera;
    public Collider portalcollider;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.LookAt(camera.transform);
        gameObject.transform.eulerAngles = new Vector3(0, gameObject.transform.eulerAngles.y, 0);
        gameObject.transform.Rotate(Vector3.up, 180);
        portalcollider.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
