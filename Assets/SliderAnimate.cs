using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Content.Interaction;

public class SliderAnimate : MonoBehaviour
{
    public XRSlider slider;
    public GameObject ScrubAnim;

    public void OnChangeValue(float value)
    {
        Debug.Log("Value =" + value);
        Animator _Animation = ScrubAnim.GetComponent<Animator>();

        _Animation.SetFloat("ScrubPosition", value);
    }
}
