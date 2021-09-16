using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
public class LightEstimation : MonoBehaviour
{
    public Light MainLight;
    public ARCameraManager ARCM;
    // Start is called before the first frame update
    void Start()
    {
        ARCM.frameReceived += FrameUpdated;

    }
    private void OnEnable()
    {

    }

    private void OnDisable()
    {
        ARCM.frameReceived -= FrameUpdated;
    }
    // Update is called once per frame
 

    private void FrameUpdated(ARCameraFrameEventArgs args)
    {
        if (args.lightEstimation.averageBrightness.HasValue)
        {
            MainLight.intensity = args.lightEstimation.averageBrightness.Value;
        }
        if (args.lightEstimation.averageColorTemperature.HasValue)
        {
            MainLight.colorTemperature = args.lightEstimation.averageColorTemperature.Value;
        }
        if (args.lightEstimation.mainLightColor.HasValue)
        {
            MainLight.color = args.lightEstimation.mainLightColor.Value;
        }
    }
}
