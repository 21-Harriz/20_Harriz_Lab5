using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingCoins : MonoBehaviour
{
    public int RotateSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0,RotateSpeed,0,Space.World);
    }


}
