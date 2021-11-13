using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class OnPlane : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject placedPrefab;
    [SerializeField] int x;
    [SerializeField] int y;
    [SerializeField] int z;
    GameObject spawnedObject;
    void Start()
    {
        PlaceObject();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void PlaceObject()
    {
        spawnedObject= Instantiate(placedPrefab,new Vector3(x,y,z), new Quaternion(0,0,0,0));
    }
}


/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
public class PlaceObjectOnPlane:MonoBehaviour
{
    [SerializeField] GameObject placedPrefab;
    GameObjetc spawnedObject;
    ARRaycastManager raycaster;
    List<ARRaycastHit> hits = new List<ARRaycastHit>();
    voidStart()
    {
        raycaster= GetComponent<ARRaycastManager>();
    }
    void OnPlaceObject(InputValue value)
    {
        // get the screen touch positionVector2
        touchPosition= value.Get<Vector2>();
        // raycastfrom the touch position into the 3D scene looking for a plane// if the raycasthit a plane then
        if(raycaster.Raycast(touchPosition, hits, TrackableType.PlaneWithinPolygon)) {
            // get the hit point (pose) on the plane
            Pose hitPose= hits[0].pose;
            // if this is the first time placing an object,
            if(spawnedObject== null) {
                // instantiate the prefab at the hit position and rotation
                spawnedObject= Instantiate(placedPrefab, hitPose.position, hitPose.rotation);
                }
                else{
                    // change the position of the previously instantiated object
                    spawnedObject.transform.SetPositionAndRotation(hitPose.position, hitPose.rotation);
                    }
                }
            }
        }*/