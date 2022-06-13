using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardManager : MonoBehaviour
{
    public Transform Player;
    public float VisibleDistance = 0;
    public List<EnemyBehaviour_Level7> Guards = new List<EnemyBehaviour_Level7>();

    void Update()
    {
        if(Guards.Count > 0)
        {
            if (Player.position.x - Guards[0].transform.position.x < VisibleDistance)
            {
                if (!Guards[0].actionPlaying)
                {
                    Guards[0].isWalking = true;
                }

                if (Player.position.x - Guards[0].transform.position.x < 3)
                {
                    Guards[0].isWalking = false;
                }
            }
            else
                Guards[0].isWalking = false;
        }        
    }

    public void RemoveGuard(EnemyBehaviour_Level7 Guard)
    {
        EnemyBehaviour_Level7 g;
        foreach(EnemyBehaviour_Level7 guard in Guards)
        {
            if(guard == Guard)
            {
                g = guard;
                Guards.Remove(g);
                return;
            }
        }            
    }
}