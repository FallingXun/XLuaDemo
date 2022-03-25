using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

[LuaCallCSharp]
public class TestGeneric 
{
    public void Test1<T>(T p) where T : Component
    {
        Debug.Log("TestGeneric.Test1<T> " + typeof(T));        
    }
}
