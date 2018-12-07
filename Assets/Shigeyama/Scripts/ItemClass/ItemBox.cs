using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    [SerializeField]
    GameObject SetItem;

    public GameObject Item()
    {
        return Instantiate(SetItem, transform.position, Quaternion.identity);
    }
}
