using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public SpriteRenderer SR;
    //For example, what if the coin teleported to a new location instead of being destroyed?
    public void GetBumped()
    {
        SR.color = Color.red;
    }
}


