using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTest : MonoBehaviour
{
    public Menu menu = new Menu();
    //Menu menu;

    [Test]
    public void ExitButtonTest()
    {
        menu.exitButton();
    }
}
