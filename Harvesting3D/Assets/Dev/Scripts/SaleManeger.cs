using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SaleManeger : MonoBehaviour
{
    public Transform ItemSaleTransform;
    int numOfItemsHolding = 0;
    public void AddItem(Transform _itemToAdd)
    {
        _itemToAdd.DOJump(ItemSaleTransform.position + new Vector3(0, 0.025f * numOfItemsHolding, 0), 1.5f, 1, 0.25f).OnComplete(
            () => {
                _itemToAdd.SetParent(ItemSaleTransform, true);
                _itemToAdd.localPosition = new Vector3(0, 5f * numOfItemsHolding, 0);
                _itemToAdd.localRotation = Quaternion.identity;
                numOfItemsHolding++;
            }
        );
    }


}
