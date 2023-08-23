using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
  public Collider bola;
  public float multiplier;
  public Color color;
  public float score;

  public AudioMager audioManager;
  public VFXManager vfxManager;
  public ScoreManager scoreManager;
  
  private Renderer renderer;
  private Animator animator;

  private void Start()
  {
    renderer = GetComponent<Renderer>();
    animator = GetComponent<Animator>();

    renderer.material.color = color;
  }

  private void OnCollisionEnter(Collision collision)
  {
    if (collision.collider == bola)
    {
      Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
      bolaRig.velocity *= multiplier;

      animator.SetTrigger("hit");

      //playsfx
      audioManager.PlaySFX(collision.transform.position);

      //playvfx
      vfxManager.PlayVFX(collision.transform.position);

      //score
      scoreManager.AddScore(score);

    }
  }
}

