using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColision : MonoBehaviour
{
    private ArrayList numbers;
    [SerializeField]
    int requiredNumbers;

    void OnCollisionEnter(Collision collisonInfo)
    {
        var objectName = collisonInfo.collider.name;
        var objectIntegerName = int.Parse(objectName);

        if(objectName == "1")
        {
            numbers.Add(objectIntegerName);
            Destroy(collisonInfo.gameObject);
        }

        if(objectName == "2")
        {
            numbers.Add(objectIntegerName);
            Destroy(collisonInfo.gameObject);
        }    

    }
}
