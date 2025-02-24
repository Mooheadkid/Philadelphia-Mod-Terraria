using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhiladelphiaMod.Content.Items.Weapons
{
    public class Lamppost : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 64;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 27;
            Item.useAnimation = 27;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 27;
            Item.crit = 20;
            Item.knockBack = 9;

            Item.value = Item.buyPrice(gold: 20);
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item1;
        }

        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
            target.AddBuff(BuffID.OnFire, 360);
        }

        public override void MeleeEffects(Player player, Rectangle hitbox) {
			if (Main.rand.NextBool(5)) {
				Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, ModContent.DustType<Dusts.LamppostFlame>());
			}
		}
    }
}