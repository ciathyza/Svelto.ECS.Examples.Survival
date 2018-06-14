using UnityEngine;


namespace Svelto.ECS.Example.Survive.Enemies
{
	public interface IEnemySinkComponent : IComponent
	{
		float sinkAnimSpeed { get; }
	}


	public interface IEnemyMovementComponent : IComponent
	{
		bool navMeshEnabled { set; }
		Vector3 navMeshDestination { set; }
		bool setCapsuleAsTrigger { set; }
	}


	public interface IEnemyTriggerComponent : IComponent
	{
		EnemyCollisionData entityInRange { get; }
	}


	public struct EnemyCollisionData
	{
		public EGID otherEntityID;
		public readonly bool collides;

		public EnemyCollisionData(EGID otherEntityID, bool collides)
		{
			this.otherEntityID = otherEntityID;
			this.collides = collides;
		}
	}


	public interface IEnemyVFXComponent : IComponent
	{
		Vector3 position { set; }
		DispatchOnSet<bool> play { get; }
	}
}
