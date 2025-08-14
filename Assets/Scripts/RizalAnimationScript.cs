using UnityEngine;

public class RizalAnimatorScript : MonoBehaviour
{
    public Animator rizalAnimator;

    // Play Dance animation
    public void PlayDance()
    {
        rizalAnimator.ResetTrigger("Flip");
        rizalAnimator.ResetTrigger("Attack");  // Reset any other active triggers
        rizalAnimator.SetTrigger("Dance");
    }

    // Play Flip animation
    public void PlayFlip()
    {
        rizalAnimator.ResetTrigger("Dance");
        rizalAnimator.ResetTrigger("Attack");  // Reset any other active triggers
        rizalAnimator.SetTrigger("Flip");
    }

    // Play Attack animation (ensure proper sequence or behavior)
    public void PlayAttack()
    {
        rizalAnimator.ResetTrigger("Dance");
        rizalAnimator.ResetTrigger("Flip");  // Reset Flip trigger first to avoid conflict

        // Trigger Attack animation
        rizalAnimator.SetTrigger("Attack");

        // You can choose to play "Dance" or "Flip" after attack, depending on the behavior
        // Example: Uncomment this line if you'd like Dance to follow Attack
        // rizalAnimator.SetTrigger("Dance");
    }
}
