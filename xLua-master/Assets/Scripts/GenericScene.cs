using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class GenericScene : MonoBehaviour
{
    // ����Wrap����
    private const string test1 = @"
        local o = CS.TestGeneric()

        local go = CS.UnityEngine.GameObject.Find('Camera')
        local cam = go:GetComponent(typeof(CS.UnityEngine.Camera))
        o:Test1(cam)
";

    // ���Է��ͷ�������������û���޶�
    private const string test2_1 = @"
        local o = CS.TestGeneric()

        local test2_method = xlua.get_generic_method(CS.TestGeneric,'Test2')
        local Test2 = test2_method(CS.UnityEngine.Camera)
        Test2(o)
";

    // ����Wrap���ɣ����ͷ�������������û���޶�
    private const string test2_2 = @"
        local o = CS.TestGeneric()

        o:Test2()
";

    // ���Է��ͷ�������������û���޶�����Ϊclass
    private const string test3_1 = @"

        local o = CS.TestGeneric()

        local test3_method = xlua.get_generic_method(CS.TestGeneric,'Test3')
        local Test3 = test3_method(CS.UnityEngine.Camera, CS.UnityEngine.GameObject)
        Test3(o)
";
    // ���Է��ͷ�������������û���޶�����ȫΪclass
    private const string test3_2 = @"

        local o = CS.TestGeneric()

        local test3_method = xlua.get_generic_method(CS.TestGeneric,'Test3')
        local Test3 = test3_method(CS.UnityEngine.Camera, CS.System.Int32)
        Test(o)
";

    // ���Է��ͷ������������޶�ΪInterface
    private const string test4 = @"

        local o = CS.TestGeneric()
        local i = CS.TestI1()
        local test4_method = xlua.get_generic_method(CS.TestGeneric,'Test4')
        local Test4 = test4_method(CS.TestInterface)
        Test4(o, i)
";
    private LuaEnv env;

    private void Start()
    {
        env = new LuaEnv();
        //env.DoString(test1);
        //env.DoString(test2_1);
        //env.DoString(test2_2);
        //env.DoString(test3_1);
        //env.DoString(test3_2);
        env.DoString(test4);
    }


    private void OnDestroy()
    {
        env.Dispose();
    }

    private void Compile()
    {
        var o = new TestGeneric();
        o.Test3<object, int>();
    }
}
