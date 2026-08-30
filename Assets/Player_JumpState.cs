using UnityEngine;

public class Player_JumpState : EntityState
{
  public Player_JumpState(PlayerScript playerScript, StateMachine stateMachine, string animBoolName) : base(playerScript, stateMachine, animBoolName)
  {
    
  }

  public override void Enter()
  {
    base.Enter();
   
    
    playerScript.SetVelocity(rb.linearVelocity.x, playerScript.jumpForce);
  }

  public override void Update()
  {
    base.Update();

    if(rb.linearVelocity.y < 0)
    {
      stateMachine.ChangeState(playerScript.fallState);
    }
  }
}
