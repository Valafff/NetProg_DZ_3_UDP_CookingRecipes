using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ServerUDP
{
	public class RecipesLoader
	{

		List<Recipe> Recipes = new List<Recipe>();

		public RecipesLoader()
		{
			{
				try
				{
					DirectoryInfo RecipesDirectory = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\Recipes");
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
				catch (System.Exception e)
				{

					MessageBox.Show(e.Message);
				}

			}
		}
		public List<Recipe> GetRecipes()
		{
			return Recipes;
		}

	}
}
