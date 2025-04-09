using UnityEngine;
using UnityEngine.UI;

public static class GameController
{
    private static int collettableCount;
    public static bool isGameOver
    {
        get
        {
            return collettableCount <= 0;
        }
    }
    public static void Init()
    {
        collettableCount = 4;
    }
    public static void GetCollected()
    {
        collettableCount--;
    }
}
