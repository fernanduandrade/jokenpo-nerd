Console.WriteLine("Jogador 1, escolha uma das seguites opções");
Console.Write("rock|paper|scissor|spok|lizard: ");

var player_one = Console.ReadLine();

Console.WriteLine("Jogador 2, escolha uma das seguites opções");
Console.Write("rock|paper|scissor|spok|lizard: ");

var player_two = Console.ReadLine();

var playerOne = Player.Create(player_one);
var playerTwo = Player.Create(player_two);

var outcome = playerOne.Fight(playerTwo.Type);
var winner = outcome ? "Jogador 2" : "Jogador 1";
var firstOption = outcome ? player_two : player_one;
var secondOption = outcome ? player_one : player_two;
Console.WriteLine($"{winner} venceu escolhendo {firstOption} contra {secondOption}");