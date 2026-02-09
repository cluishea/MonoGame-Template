
/*
Game scenes manager class
Partial class so code can be split to many files
*/

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MyGame.Core;
using MyGame.Scenes;

namespace MyGame.Managers 
{
    internal partial class GameSceneManager : Components
    {

        MenuScene menuScene = new MenuScene();
        GameScene gameScene = new GameScene();
    
        internal override void Load(ContentManager content)
        {
            menuScene.Load(content);
            gameScene.Load(content);
        }

        internal override void Update(GameTime gameTime)
        {
            switch (GameConfig.currentScene)
            {
                case GameConfig.Scenes.Menu:
                    menuScene.Update(gameTime);
                    break;
                case GameConfig.Scenes.Game:
                    gameScene.Update(gameTime);
                    break;
            }
        }

        internal override void Draw(SpriteBatch spriteBatch)
        {
            switch (GameConfig.currentScene)
            {
                case GameConfig.Scenes.Menu:
                    menuScene.Draw(spriteBatch);
                    break;
                case GameConfig.Scenes.Game:
                    gameScene.Draw(spriteBatch);
                    break;
            }
        }
    }

}
