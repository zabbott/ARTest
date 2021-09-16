using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARPlaneFuncs : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        ARRaycast.ARR.Planes.Add(gameObject);
    }
}
