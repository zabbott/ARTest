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
    public GameObject lookingIN;
    public GameObject lookingOut;
    public GameObject Back; 
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Door")
        {
            door = other.gameObject; 
            foreach(var obj in objectsInScene)
            {
                if (gameObject.transform.position.z < door.transform.position.z)
                {
                    obj.layer = 0;
                    lookingIN.gameObject.SetActive(false);
                    lookingOut.gameObject.SetActive(true);
                    Back.layer = 8;
                }
                else
                {
                    obj.layer = 7;
                    lookingIN.gameObject.SetActive(true);
                    lookingOut.gameObject.SetActive(false);
                    Back.layer = 7;
                }
            }
        }
       
    }

    private void Update()
    {
        if (door != null)
        {
            TR.mytext.text = (gameObject.transform.position.z > door.transform.position.z).ToString();

        }
    }
}
