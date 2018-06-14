using UnityEngine;


namespace Svelto.ECS.Example.Survive.Enemies
{
	public class EnemyVFXImplementor : MonoBehaviour, IImplementor, IEnemyVFXComponent
	{
		public ParticleSystem particle; // Reference to the particle system that plays when the enemy is damaged.
		

		public Vector3 position { set { particle.transform.position = value; } }
		public DispatchOnSet<bool> play { get; set; }


		private void Awake()
		{
			// Setting up the references.
			particle = GetComponentInChildren<ParticleSystem>();
			play = new DispatchOnSet<bool>(gameObject.GetInstanceID());
			play.NotifyOnValueSet(Play);
		}

		private void Play(int sender, bool value)
		{
			if (value) particle.Play();
		}
	}
}
