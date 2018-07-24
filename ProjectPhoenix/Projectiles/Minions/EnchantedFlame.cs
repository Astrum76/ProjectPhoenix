using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ProjectPhoenix.Projectiles.Minions
{
	public class EnchantedFlame : ModProjectile
	{
		
		private int[] dusts = {160, 600, 64, 61, 50, 60, 590}; 
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("EnchantedFlame");
		}
		public override void SetDefaults()
		{
			
			projectile.width = 75;
			projectile.height = 75;
			projectile.aiStyle = 0;
            projectile.alpha = 255;
			projectile.timeLeft = 150;
			projectile.friendly = true;
			projectile.tileCollide = true;
			projectile.ignoreWater = true;
			projectile.magic = true;          
			projectile.penetrate = 1;
		}
        public override void AI()
        {
            if (projectile.localAI[0] == 0f)
            {
                Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 20);
                projectile.localAI[0] = 1f;
            }
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 66, 0f, 0f, 100, new Color(200, 10, 200), 1.5f);
            Main.dust[dust].velocity *= 0.5f;
            if (projectile.velocity == Vector2.Zero)
            {
                Main.dust[dust].velocity.Y -= 1f;
                Main.dust[dust].scale = 1.2f;
            }
            else
            {
                Main.dust[dust].velocity += projectile.velocity * 0.2f;
            }
            Main.dust[dust].position.X = projectile.Center.X + 4f + (float)Main.rand.Next(-2, 3);
            Main.dust[dust].position.Y = projectile.Center.Y + (float)Main.rand.Next(-2, 3);
            Main.dust[dust].noGravity = true;
        }
    }
}