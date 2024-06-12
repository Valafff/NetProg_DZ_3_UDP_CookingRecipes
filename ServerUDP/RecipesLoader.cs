using System.Text;

namespace ServerUDP
{
	internal class RecipesLoader
	{
		Config? Config;
		List<Recipe> Recipes = new List<Recipe>();

		public RecipesLoader(Config? _config)
		{
			Config = _config;
			if (Config != null)
			{
				DirectoryInfo RecipesDirectory = new DirectoryInfo(Config.TextDirectory);
				FileInfo[] RecipeFiles = RecipesDirectory.GetFiles("*.txt");

				for (int i = 0; i < RecipeFiles.Length; i++)
				{
					using (FileStream fs = new FileStream(RecipeFiles[i].FullName, FileMode.Open))
					{
						Recipe tempRecipe = new Recipe() { Id = i };
						int endIndex = RecipeFiles[i].Name.IndexOf(".txt");
						tempRecipe.RecipeName = RecipeFiles[i].Name.Substring(0, endIndex);

						byte[] buffer = new byte[RecipeFiles[i].Length];
						fs.Read(buffer, 0, buffer.Length);
						tempRecipe.Cooking = Encoding.UTF8.GetString(buffer);
						Recipes.Add(tempRecipe);
					}
				}
			}
		}

		public List<Recipe> GetRecipes()
		{
			return Recipes;
		}

	}
}
