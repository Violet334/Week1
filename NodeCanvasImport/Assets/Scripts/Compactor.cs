using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compactor : MonoBehaviour
{
    public Transform pressPad;
    public Animator animator;

    public void Crush()
    {
        animator.SetBool("IsOn", true);
    }

    public void Stop()
    {

    }
}
