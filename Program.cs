// See https://aka.ms/new-console-template for more information

using Bossfight;

var Game = new Game();



var Hero = new GameCharacter("Hero", 100, 20, 40);
var Boss = new GameCharacter("Boss", 400, 0, 10);

Game.Run(Hero, Boss);

