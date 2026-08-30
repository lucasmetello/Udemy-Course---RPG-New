using UnityEngine;

public abstract class EntityState
{
    protected PlayerScript playerScript;
    protected StateMachine stateMachine;
    protected string animBoolName;
    private Animator anim;
    protected Rigidbody2D rb;
    protected PlayerInputSet input;
    

    public EntityState(PlayerScript playerScript, StateMachine stateMachine, string animBoolName)
    {   
        this.playerScript = playerScript;
        this.stateMachine = stateMachine;
        this.animBoolName = animBoolName;

        anim = playerScript.anim;
        rb = playerScript.rb;
        input = playerScript.input;

    }

    public virtual void Enter()
    {
        playerScript.anim.SetBool(animBoolName, true);
    }

    public virtual void Update()
    {
        anim.SetFloat("yVelocity", rb.linearVelocity.y);
    }

    public virtual void Exit()
    {
        playerScript.anim.SetBool(animBoolName, false);
    }
}
