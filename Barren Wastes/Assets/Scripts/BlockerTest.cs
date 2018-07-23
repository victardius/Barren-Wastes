using UnityEngine;
using System.Collections;
using Pathfinding;

public class BlockerTest : MonoBehaviour
{
    public void Start()
    {
        var blocker = GetComponent<SingleNodeBlocker>();

        blocker.BlockAtCurrentPosition();
    }
}