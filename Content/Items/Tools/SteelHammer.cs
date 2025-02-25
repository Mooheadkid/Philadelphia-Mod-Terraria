using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace PhiladelphiaMod.Content.Items.Tools
{
    public class SteelHammer : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 8;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 7;
            Item.value = Item.buyPrice(gold: 1);
            Item.rare = ItemRarityID.White;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;

            Item.hammer = 60;
            Item.attackSpeedOnlyAffectsWeaponAnimation = true;
        }
    }
}