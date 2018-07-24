using Terraria.ID;
using Terraria.ModLoader;

namespace ProjectPhoenix.Items
{
    public class BulletName : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Boolet");
			Tooltip.SetDefault("12Seconds.avi");
		}
        public override void SetDefaults()
        {
            item.damage = 100;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1.5f;
            item.value = 10;
            item.rare = 2;
            item.shoot = mod.ProjectileType("BulletName");
            item.shootSpeed = 15f;
            item.ammo = AmmoID.Bullet;
        }
        public override void AddRecipes()  //How to craft this gun
        {
            

        }
    }
}