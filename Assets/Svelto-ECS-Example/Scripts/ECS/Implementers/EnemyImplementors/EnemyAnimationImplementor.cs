using UnityEngine;


namespace Svelto.ECS.Example.Survive.Enemies
{
	public class EnemyAnimationImplementor : MonoBehaviour, IImplementor, IAnimationComponent, IEnemySinkComponent
	{
		public float SinkSpeed = 2.5f; // The speed at which the enemy sinks through the floor when dead.
		private Animator _anim; // Reference to the animator.

		
		public string playAnimation { set { _anim.SetTrigger(value); } }
		public float sinkAnimSpeed { get { return SinkSpeed; } }
		
		
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
			// Setting up the references.
			_anim = GetComponent<Animator>();
		}
	}
}
