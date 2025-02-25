using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace PhiladelphiaMod.Content.Items.Tools
{
    public class SteelPickaxe : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 7;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 6;
            Item.value = Item.buyPrice(gold: 1);
            Item.rare = ItemRarityID.White;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;

            Item.pick = 60;
            Item.attackSpeedOnlyAffectsWeaponAnimation = true;
        }
    }
}