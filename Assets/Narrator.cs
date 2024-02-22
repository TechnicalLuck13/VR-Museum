using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Narrator : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float activationDistance = 3.0f;
    [SerializeField] private float resetDelay = 10.0f;
    [SerializeField] private string triggerName = "StartAnim";
    private float timer;
    private Animator anim;
    private AudioSource aud;
    void Start()
    {
        anim = GetComponent<Animator>();
        aud = GetComponent<AudioSource>();
    }
    void Update()
    {
        float distance = Vector3.Distance(this.transform.position, target.position);
        if (distance < activationDistance && timer <= 0)
        {
            StartAnim();
        }
        if (timer > 0) timer -= Time.deltaTime;
    }
    void StartAnim()
    {
        anim.SetTrigger("StartAnim");
        aud.Play();
        timer = resetDelay;
    }
}
