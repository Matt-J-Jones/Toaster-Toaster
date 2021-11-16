using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour
{
    
    [Header("Aiming")]
    [Range(0,100)]
    public float maxDistance = 100;
    public LayerMask Layer;
    public Camera Camera;
    public Transform TorchObject;
    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        Vector3 hitPoint;

        if (Physics.Raycast(ray, out hitInfo, maxDistance, Layer))
        {
            hitPoint = hitInfo.point;
        }
        else
        {
            hitPoint = ray.origin + ray.direction * maxDistance;
        }
        
    TorchObject.LookAt(hitPoint);
    }
}
