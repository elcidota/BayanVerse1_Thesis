using UnityEngine;

public class RizalAnimatorScript : MonoBehaviour
{
    public Animator rizalAnimator;

    void Start()
    {
        // Make sure Idle animation is the default state when the game starts.
        if (rizalAnimator != null)
        {
            rizalAnimator.Play("Idle");
        }
    }

    // Play Attack animation
    public void PlayAttack()
    {
        // Reset other triggers to avoid conflicts
        rizalAnimator.SetTrigger("Attack");
    }

    // Play Defend animation (Sword and Shield Impact)
    public void PlayDefend()
    {
        // Reset other triggers to avoid conflicts
        rizalAnimator.SetTrigger("Defend");
    }

    // Play Tactic animation (Sword Fight One)
    public void PlayTactic()
    {
        // Reset other triggers to avoid conflicts
        rizalAnimator.SetTrigger("Tactic");
    }
}
