using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonControllerTest : MonoBehaviour
{
    public FirstPersonController firstPersonController = new FirstPersonController();
    [Test]
    public void TestFirstPersonController()
    {
        firstPersonController.Jump();
    }
}
