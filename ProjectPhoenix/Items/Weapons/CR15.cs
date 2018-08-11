using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ProjectPhoenix.Items.Weapons
{
    public class CR15 : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Can I have some help on this because i have np idesa kiwhat im foing ant it ducc thatsui ic have no ideaaaaaaaaaaaaa");
			Tooltip.SetDefault("youDidWell.avi");
		}
        public override void SetDefaults()
        {
            item.damage = 100000;  //gun damage
            item.ranged = true;   //its a gun so set this to true
            item.width = 30;     //gun image width
            item.height = 20;   //gun image  height
            item.useTime = 2;  //how fast 
            item.useAnimation = 2;
			item.useAmmo = AmmoID.Bullet;
            item.useStyle = 5;    //
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 0;
            item.value = 10000;
			//item.UseSound = SoundID.Item11;
            item.rare = 7;
            item.autoReuse = true;
            item.shoot = 10; //idk why but all the guns in the vanilla source have this
            item.shootSpeed = 5f;
        }

        public override void AddRecipes()  //How to craft this gun
        {
            

        }
		public override bool ConsumeAmmo(Player player)
		{
			return false;
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Here we manually spawn the 2nd projectile, manually specifying the projectile type that we wish to shoot.
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.BlackBolt, 100000, 0, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.StarWrath, 100000, 0, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.InfluxWaver, 100000, 0, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.Daybreak, 1000000, 0, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.VortexBeaterRocket, 1000000, 0, player.whoAmI);
			//Projectile.NewProjectile(position.X, position.Y, 3, 3, ProjectileID.DeathSickle, damage, knockBack, player.whoAmI);
			//Projectile.NewProjectile(position.X, position.Y, 3, 3, ProjectileID.SolarWhipSword, damage, knockBack, player.whoAmI);

			// By returning true, the vanilla behavior will take place, which will shoot the 1st projectile, the one determined by the ammo.
			return true;
		}
    }
}