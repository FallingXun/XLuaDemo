using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
using System;

[LuaCallCSharp]
public class TestGeneric
{
    public void Test1<T>(T p) where T : Component
    {
        Debug.Log("TestGeneric.Test1<T> " + typeof(T));
    }

    public void Test2<T>()
    {
        Debug.Log("TestGeneric.Test2<T> " + typeof(T));
    }

    public T2 Test3<T1, T2>()
    {
        Debug.Log("TestGeneric.Test3<T1, T2> " + typeof(T1) + " " + typeof(T2));
        return default(T2);
    }

    public void Test4<T>(T p) where T: TestInterface
    {
        Debug.Log("TestGeneric.Test4<T> " + typeof(T));
        p.Log();
    }
}

[LuaCallCSharp]
public class TestI1 : TestInterface
{
    public void Log()
    {
        Debug.Log("TestI1 Call TestInterface.Log");
    }
}

[LuaCallCSharp]
public class TestI2 : TestInterface
{
    public void Log()
    {
        Debug.Log("TestI2 Call TestInterface.Log");
    }
}

[LuaCallCSharp]
public interface TestInterface
{
    void Log();
}