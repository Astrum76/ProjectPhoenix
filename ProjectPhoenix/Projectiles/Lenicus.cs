using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ProjectPhoenix.Projectiles
{
	public class Lenicus : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lenicus");
			Main.projFrames[projectile.type] = 7; //This is an animated projectile

		}
		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 14;
            projectile.friendly = true;
            projectile.penetrate = -1;                       //this is the projectile penetration
            projectile.hostile = false;
			projectile.magic = true;                        //this make the projectile do magic damage
            projectile.tileCollide = true;                 //this make that the projectile does not go thru walls
			projectile.ignoreWater = true;
		}

		 public override void AI()
        {
                                                                //this is projectile dust
            //int DustID2 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y + 2f), projectile.width + 2, projectile.height + 2, mod.DustType("DustName"), projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 20, default(Color), 2.9f);
            //Main.dust[DustID2].noGravity = true;
                                                          //this make that the projectile faces the right way
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            projectile.localAI[0] += 1f;
            projectile.alpha = (int)projectile.localAI[0] * 2;
          
            if (projectile.localAI[0] > 130f) //projectile time left before disappears
            {
                projectile.Kill();
            }
                       // Loop through the 56 animation frames, spending 15 ticks on each.
            if (++projectile.frameCounter >= 15)
            {
                projectile.frameCounter = 0;
                if (++projectile.frame >= 56)
                {
                    projectile.frame = 0;
                }
            }
        }
		
	}
}



