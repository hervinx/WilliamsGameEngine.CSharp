using GameEngine;
using SFML.Graphics;
using SFML.System;
using SFML.Window;


namespace MyGame
{
	class Ship : GameObject
	{
    private.readonly Sprite _sprite = new Sprite();
	public Ship()
	{
		_sprite.Textrue = Game.GetTexture("Resources/ship.png");
		_sprite.Position = new Vector2f(100, 100);
	}
	public override void Draw()
	{
		Game.RenderWindow.Draw(_sprite);
	}
	public override void Update(Time elapsed)
	{
		Vector2f pos = _sprite.Position;
	}

	}
}
