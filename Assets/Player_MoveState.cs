using UnityEngine;

public class Player_MoveState : Player_GroundedState
{
  public Player_MoveState(PlayerScript playerScript, StateMachine stateMachine, string stateName) : base(playerScript, stateMachine, stateName)
  {

  }

  public override void Update()
  {
    base.Update();

    if(playerScript.moveInput.x == 0)
    {
        stateMachine.ChangeState(playerScript.idleState);
    }
    playerScript.SetVelocity(playerScript.moveInput.x * playerScript.moveSpeed, rb.linearVelocity.y);

  }
}
