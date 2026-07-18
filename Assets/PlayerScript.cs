using UnityEngine;

public class PlayerScript : MonoBehaviour
{
   private PlayerInputSet input;
   private StateMachine stateMachine;

   public Player_IdleState idleState{get; private set;}
   public Player_MoveState moveState{get; private set;}

   public Vector2 moveInput;

   private void Awake()
   {
    stateMachine = new StateMachine();
    input = new PlayerInputSet();

    idleState = new Player_IdleState(this, stateMachine," Idle" );
    moveState = new Player_MoveState(this, stateMachine, "Moving");

   }

   private void OnEnable()
   {
      input.Enable();

      input.Player.Movement.performed += context => moveInput = context.ReadValue<Vector2>();
      input.Player.Movement.canceled += context => moveInput = Vector2.zero;
   }

   private void OnDisable()
   {
      input.Disable();
   }

   private void Start()
   {
    stateMachine.Inicialize(idleState);
   }

   private void Update()
   {
    stateMachine.currentState.Update();
   }
}
