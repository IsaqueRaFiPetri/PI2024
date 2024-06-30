using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabableObject : InteractableObject
{
    public GameObject item;
    public GameObject temParent;
    public Transform guide;

    protected override void Interact()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        item.GetComponent<Rigidbody>().useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        item.GetComponent<Rigidbody>().useGravity = false;
        item.GetComponent<Rigidbody>().isKinematic = true;
        item.transform.position = guide.transform.position;
        item.transform.rotation = guide.transform.rotation;
        item.transform.parent = guide.transform.parent;
    }
    void OnMouseUp()
    {
        item.GetComponent<Rigidbody>().useGravity = true;
        item.GetComponent<Rigidbody>().isKinematic = false;
        item.transform.position = guide.transform.position;
        item.transform.parent = null;
    }
}
