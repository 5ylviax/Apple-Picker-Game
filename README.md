# Apple-Picker
## Apple Picker Game in C# using Unity


Apple picker is based on the classic Atari game Kaboom!. In the game, an AppleTree moves back and forth dropping
Apples that players attempt to catch with four Baskets. 
Each Apple that is caught by the player is worth 100 points. If the player misses one Apple, then all Apple disappear, the player loses one Basket and the game continues. 
When all four Baskets have been lost, the game is over. 

Changes Made to the Game
- Added a home screen, where the player must click Start to begin the game.
- Added a game over screen with two options: Retry or Quit.
- Added an object the player must avoid; catching it with the basket results in an instant game over.
- Added rounds that trigger when the player reaches a certain point threshold, increasing the speed of the tree.
- Updated score display.

Link to game 
https://play.unity.com/en/games/4457aea4-4d8d-4469-b4ed-d5d765d37f00/apple-picker

## Known Issues

Round Display Bug
In the hierarchy → Canva → RoundCheck (legacy text), rounds are not displayed after building and publishing.

✅ Works correctly in Play Mode inside Unity (tested on Unity 2021.3.33f1).

❌ Fails to display in the built/published version.