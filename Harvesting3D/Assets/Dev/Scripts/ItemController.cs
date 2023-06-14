using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ItemController : MonoBehaviour
{
    bool isAlreadyCollected = false;
    int numOfItemsHolding = 0;

    public void OnTriggerEnter(Collider other)
    {
        if (isAlreadyCollected) return;

        if(other.CompareTag("Player"))
        {
            GetComponentInParent<GemsController>().timeCtrl = true;

            CharacterStack characterStack;
            if(other.TryGetComponent(out characterStack))
            {
                characterStack.AddNewItem(this.transform);
                isAlreadyCollected = true;
            }
        }

        if (other.CompareTag("Sale"))
        {
            //gameObject.transform.parent = other.transform;
            Destroy(gameObject);
            //transform.DOJump(other.transform.position + new Vector3(0, 0.025f * numOfItemsHolding, 0), 1.5f, 1, 0.25f).OnComplete(
            // () =>
            // {

            //     transform.localPosition = new Vector3(0, 5f * numOfItemsHolding, 0);
            //     transform.localRotation = Quaternion.identity;
            //     numOfItemsHolding++;
            //     transform.SetParent(other.transform, true);
            // }
         //);
        }

    }

 
}
