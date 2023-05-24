using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using GameEngine;
using SFML.Graphics;
using SFML.System;

namespace MyGame
{
    class Laser : GameObject
    {
        private const float speed = 1.2f;

        private readonly Sprite _sprite = new Sprite();

        public Laser(Vector2f pos)
        {
            _sprite.Texture = Game.GetTexture("Resources/laser.png");
            _sprite.Position = pos;
            AssignTag("laser");
        }
        public override void Draw()
        {
            Game.RenderWindow.Draw(_sprite);
        }
        public override void Update(Time Elapsed)
        {
            int msElapsed = Elapsed.AsMilliseconds();
            Vector2f pos = _sprite.Position;

            if (pos.X > Game.RenderWindow.Size.X)
            {
                MakeDead();
            }
            else
            {
                _sprite.Position = new Vector2f(pos.X + speed * msElapsed, pos.Y);



            }
        }
        public override FloatRect GetCollisionRect()
        {
            return _sprite.GetGlobalBounds();
        }

        public override void HandleCollision(GameObject otherGameObject)
        {
            if (otherGameObject.HasTag("laser"))
            {
                otherGameObject.MakeDead();
            }
            MakeDead();
        }
    }
}

