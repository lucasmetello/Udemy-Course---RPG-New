using UnityEngine;

public class Player_MoveState : EntityState 
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
  }
}
