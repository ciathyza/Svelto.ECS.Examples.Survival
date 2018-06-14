using Svelto.ECS.Example.Survive.Camera;
using UnityEngine;


namespace Svelto.ECS.Example.Survive.Player
{
	public class PlayerMovementImplementor : MonoBehaviour, IImplementor,
	                                         IRigidBodyComponent,
	                                         IAnimationComponent,
	                                         ICameraTargetComponent,
	                                         ISpeedComponent,
	                                         ITransformComponent
	{
		public float speed = 6f; // The speed that the player will move at.
		private Animator _anim; // Reference to the animator component.
		private Rigidbody _playerRigidbody; // Reference to the player's rigidbody.
		private Transform _playerTransform;
		

		public bool       isKinematic   { set { _playerRigidbody.isKinematic = value; } }
		public Quaternion rotation      { set { _playerRigidbody.MoveRotation(value); } }
		public float      movementSpeed { get { return speed; } }
		public string     playAnimation { set { _anim.SetTrigger(value); } }
		public Vector3    position      { get { return _playerTransform.position; } set { _playerRigidbody.MovePosition(value); } }

		
		public void setState(string n, bool value)
		{
			_anim.SetBool(n, value);
		}

		public void reset()
		{
			_anim.Rebind();
		}


		private void Awake()
		{
			// Set up references.
			_anim = GetComponent<Animator>();
			_playerRigidbody = GetComponent<Rigidbody>();
			_playerTransform = transform;
		}
	}
}
