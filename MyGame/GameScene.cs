﻿using GameEngine;
using SFML.System;


namespace MyGame
{
    class GameScene : Scene
    {
        public GameScene()
        {
            Ship ship = new Ship();
            AddGameObject(ship);

            MeteorSpawner meteorSpawner = new MeteorSpawner();
            AddGameObject(meteorSpawner);
        }
    }
}