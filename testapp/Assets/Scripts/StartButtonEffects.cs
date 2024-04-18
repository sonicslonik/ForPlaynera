using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonEffects : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private ParticleSystem starParticles;
    

    public void Play()
    {
        animator.SetTrigger("Press");
        starParticles.Play();
    }
}
