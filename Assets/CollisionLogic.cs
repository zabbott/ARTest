using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
public class CollisionLogic : MonoBehaviour
{
    public GameObject[] objectsInScene;
    public TextReceiver TR;
    public ARCameraBackground ARCB;
    public GameObject door; 
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Door")
        {
            door = other.gameObject; 
            foreach(var obj in objectsInScene)
            {
                obj.layer = 0;
            }
        }
        ARCB.enabled = false;
    }

    private void Update()
    {
        if (door != null)
        {
            TR.mytext.text = Vector3.Distance(gameObject.transform.position, door.transform.position).ToString();

        }
    }
}
