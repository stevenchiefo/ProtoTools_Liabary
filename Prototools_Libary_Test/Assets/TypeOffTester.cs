using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ProtoTools.DataManager;

public class TypeOffTester : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        DataManager i = new DataManager();
        DataManager.GetReturnSortedList(i.GetType());
        GetComponent
    }

    // Update is called once per frame
    private void Update()
    {
    }
}