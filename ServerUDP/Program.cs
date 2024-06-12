using ServerUDP;
using System.Net;
using System.Text;

//Получение конфига
Config? Config = new Config().ReadConfig();

//Получение рецептов
RecipesLoader Loader = new RecipesLoader(Config);
List<Recipe> Recipes = Loader.GetRecipes();
if (Recipes.Count>0)
{
	Console.WriteLine("В память загружены следующие рецепты:");
	foreach (var item in Recipes)
	{
		Console.WriteLine($"Id рецепта: {item.Id} Название рецепта: {item.RecipeName}");
	}
}
else
{
    Console.WriteLine("Рецепты не найдены!");
}

//Сервер
ServerUDP.ServerUDP serverUDP = new ServerUDP.ServerUDP(Recipes);
serverUDP.ServerStart();





