namespace Svelto.ECS.Example.Survive.Player
{
	public struct HealthEntityStruct : IEntityStruct
	{
		public int currentHealth;
		public EGID ID { get; set; }
	}
}
