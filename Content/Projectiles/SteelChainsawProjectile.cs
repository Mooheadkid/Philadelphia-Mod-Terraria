using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhiladelphiaMod.Content.Projectiles
{

    // Copied from ExampleMod

	public class SteelChainsawProjectile : ModProjectile
	{
		public override void SetStaticDefaults() {
			// Prevents jitter when stepping up and down blocks and half blocks
			ProjectileID.Sets.HeldProjDoesNotUsePlayerGfxOffY[Type] = true;
		}

		public override void SetDefaults() {
            // Ai Style is set to the default chainsaw ai
            Projectile.aiStyle = 20;
			Projectile.width = 22;
			Projectile.height = 22;
			Projectile.friendly = true;
			Projectile.tileCollide = false;
			Projectile.penetrate = -1;
			Projectile.DamageType = DamageClass.Melee;
			Projectile.ownerHitCheck = true;
			Projectile.hide = true; // Hides the projectile, so it will draw in the player's hand when we set the player's heldProj to this one.
		}
	}
}