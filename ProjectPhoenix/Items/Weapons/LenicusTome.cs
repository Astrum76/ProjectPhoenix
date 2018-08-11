using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace ProjectPhoenix.Items.Weapons
{
    public class LenicusTome : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lenicus Tome");
			Tooltip.SetDefault("Casts a [REDACTED].");
		}
        public override void SetDefaults()
        {
                    
            item.damage = 60;                        
            item.magic = true;                     //this make the item do magic damage
            item.width = 28;
            item.height = 32;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;        //this is how the item is held
            item.noMelee = true;
            item.knockBack = 2;        
            item.value = 1000;
            item.rare = 6;
            item.mana = 5;             //mana use
           // item.UseSound = SoundID.Item21;  
	
			item.UseSound = SoundID.Item44;  // sword swing sound
		   //this is the sound when you use the item
            item.autoReuse = true;
            item.shoot = mod.ProjectileType ("Lenicus");  //this make the item shoot your projectile
            item.shootSpeed = 8f;    //projectile speed when shoot
        }      
    }
}