using UnityEngine;


namespace Svelto.ECS.Example.Survive
{
	public struct DamageInfo
	{
		public int damagePerShot { get; set; }
		public Vector3 damagePoint { get; set; }
		public EGID entityDamagedID { get; set; }
		public EntityDamagedType entityType { get; set; }

		public DamageInfo(int damage, Vector3 point, EGID entity, EntityDamagedType edt) : this()
		{
			damagePerShot = damage;
			damagePoint = point;
			entityDamagedID = entity;
			entityType = edt;
		}
	}


	public enum EntityDamagedType
	{
		Player,
		Enemy
	}
}
