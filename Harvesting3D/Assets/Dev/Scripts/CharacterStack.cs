using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class CharacterStack : MonoBehaviour
{
    public Transform ItemHolderTransform;
    bool isAlreadyCollected = false;

    int numOfItemsHolding = 0;

    void Update()
    {
        ItemHolderTransform.transform.parent = gameObject.transform;
    }
    public void AddNewItem(Transform _itemToAdd)
    {
        _itemToAdd.DOJump(ItemHolderTransform.position + new Vector3(0, 0.025f * numOfItemsHolding, 0), 1.5f, 1, 0.25f).OnComplete(
            () =>
            {
                _itemToAdd.SetParent(ItemHolderTransform, true);
                    _itemToAdd.localPosition = new Vector3(0, 5f * numOfItemsHolding, 0);
                    _itemToAdd.localRotation = Quaternion.identity;
                    numOfItemsHolding++;
               
            }
        );

    }
   

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sale"))
        {
            Transform[] children = ItemHolderTransform.GetComponentsInChildren<Transform>();
            foreach(var child in children)
            {
                child.transform.parent = null;
            }
            numOfItemsHolding = 0;
        }
    }


}

