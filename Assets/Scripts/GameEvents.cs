using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class GameEvents
{
    public static UnityEvent gameOverEvent = new UnityEvent();
    public static UnityEvent<int> UpdateHealth = new UnityEvent<int>();

}
