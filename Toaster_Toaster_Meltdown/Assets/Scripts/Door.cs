using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour

{
    public Receiver Receiver;
    public GameObject Door_Item;
    public Transform PosClosed;
    public Transform PosOpen;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Door_Item.transform.position = Vector3.Lerp(PosClosed.position, PosOpen.position, Receiver.T);
    }
}
