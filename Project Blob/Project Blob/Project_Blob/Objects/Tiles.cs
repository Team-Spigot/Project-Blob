using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Project_Blob
{
	public class Tiles : Sprite
	{
		protected int type;

		public Tiles(Texture2D texture, Vector2 position, Color color, int type) : base(position, color, texture)
		{
			AddAnimations(texture);
			this.position = position;
			this.Color = color;
			this.type = type;

			if (type == 0)
			{
				SetAnimation("Blue");
			}
			else if (type == 1)
			{
				SetAnimation("Yellow");
			}
			else if (type == 2)
			{
				SetAnimation("Red");
			}
			else if (type == 3)
			{
				SetAnimation("Purple");
			}
			else if (type == 4)
			{
				SetAnimation("Green");
			}
			else
			{
				SetAnimation("Orange");
			}
		}

		public override void Update(GameTime gameTime)
		{

			base.Update(gameTime);
		}

		public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
		{
			base.Draw(gameTime, spriteBatch);
		}

		protected override void AddAnimations(Texture2D texture)
		{
			AddAnimation("Blue", texture, new Point(30, 30), new Point(90, 60), new Point(0, 0), 1600, false);
			AddAnimation("Yellow", texture, new Point(30, 30), new Point(90, 60), new Point(30, 0), 1600, false);
			AddAnimation("Red", texture, new Point(30, 30), new Point(90, 60), new Point(60, 0), 1600, false);
			AddAnimation("Purple", texture, new Point(30, 30), new Point(90, 60), new Point(0, 30), 1600, false);
			AddAnimation("Green", texture, new Point(30, 30), new Point(90, 60), new Point(30, 30), 1600, false);
			AddAnimation("Orange", texture, new Point(30, 30), new Point(90, 60), new Point(60, 30), 1600, false);
			SetAnimation("Blue");
		}
	}
}
