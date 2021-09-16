using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARRaycast : MonoBehaviour
{
    // Start is called before the first frame update
    public ARRaycastManager ARCM;
    public Camera ARCamera;
    public GameObject cubeRef;
    public List<GameObject> Planes;
    public ARPlaneManager ARPM;
	public static ARRaycast ARR;
    public bool canMove;
	public void Start() { 
	ARR = this; 
} 	

    private void Update()
    {

        if (canMove)
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Began)
                {
                    Ray ray = ARCamera.ScreenPointToRay(touch.position);
                    RaycastHit hitObject;
                    if (Physics.Raycast(ray, out hitObject))
                    {
                        cubeRef.transform.position = hitObject.point;
                        cubeRef.gameObject.SetActive(true);
                        TurnOffAllPlanes();
                    }
                }
            }
        }
    }
    public void TurnOffAllPlanes()
    {
        ARPM.enabled = false;

        foreach (var id in Planes)
        {
            id.gameObject.SetActive(false);
        }

    }
}
