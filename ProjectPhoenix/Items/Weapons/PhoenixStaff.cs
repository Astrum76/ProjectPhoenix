using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ProjectPhoenix.Items.Weapons
{  
    public class PhoenixStaff : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Phoenix Staff");
			Tooltip.SetDefault("Summons an enchanted phoenix scythe to fight for you");
		}
        public override void SetDefaults()
        {
            item.damage = 14;
            item.summon = true;
            item.mana = 10;
            item.width = 55;
            item.height = 70;
            item.useTime = 26;
            item.useAnimation = 26;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = Item.buyPrice(0, 30, 0, 0);
            item.rare = 11;
			item.UseSound = SoundID.Item44;
            item.shoot = mod.ProjectileType("EnchantedPhoenixScythe");
            item.shootSpeed = 7f;
            item.buffTime = 3600;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}