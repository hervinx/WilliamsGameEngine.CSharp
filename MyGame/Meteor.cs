using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine;
using SFML.System;
using System.Reflection.Metadata.Ecma335;

namespace MyGame
{
    class Meteor : GameObject
    {
        private const float speed = 0.5f;

        private readonly Sprite _sprite = new Sprite();

        public Meteor(Vector2f pos)
        {
            _sprite.Texture =   Game.GetTexture("Resources/meteor.png");
            _sprite.Position = pos;
            AssignTag("Meteor");
        }
        public override void Draw()
        {
            Game.RenderWindow.Draw(_sprite);
        }
        public override void Update(Time elapsed)
        {
            int msElapsed = elapsed .AsMilliseconds();
            Vector2f pos = _sprite.Position;

            if(pos.X < _sprite.GetGlobalBounds().Width * -1)
            {
                MakeDead();
            }
            else
            {
                _sprite.Position = new Vector2f(pos.X - speed * msElapsed, pos.Y);
            }
        }

    }
}
