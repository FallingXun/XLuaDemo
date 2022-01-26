using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

[Hotfix]
public class TestHotfix 
{
    public TestHotfix()
    {

    }

    private int index = 0;

    void Call()
    {
        Debug.Log("Call");
    }

    void Call(int i)
    {
        Debug.Log("Call " + i);
    }

    int Get()
    {
        return index;
    }
}
