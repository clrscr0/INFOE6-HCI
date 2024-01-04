using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.TestTools;

public class BallMovementTests
{
    // A Test behaves as an ordinary method
    [Test]
    public void LeftArrowTest()
    {
        Assert.AreEqual(500, BallMovement.force);
    }
}
