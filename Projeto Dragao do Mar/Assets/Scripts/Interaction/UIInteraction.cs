using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInteraction : InteractableObject
{
    public GameObject painel;

    protected override void Interact()
    {
        PlayerInteraction.instance.OnInteractionEffected.Invoke();
        painel.SetActive(true);
        PlayerStats.instance.SetUIingMode();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
