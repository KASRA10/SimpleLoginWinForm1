using Newtonsoft.Json;
using simpleLoginWindows.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms; // For MessageBox

namespace simpleLoginWindows.Functions
{
	public static class GetPlaceHolderData
	{
		private static readonly HttpClient client = new HttpClient();

		public static async Task<List<UserHolders>> GetPlaceHoldersUsers()
		{
			List<UserHolders> usersList = new List<UserHolders>();

			try
			{
				// Using GetAsync instead of HttpRequestMessage
				HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/users");

				// Ensure the request was successful
				response.EnsureSuccessStatusCode();

				// Read the response content as string
				string jsonResponse = await response.Content.ReadAsStringAsync();

				// Deserialize using Newtonsoft.Json
				usersList = JsonConvert.DeserializeObject<List<UserHolders>>(jsonResponse);

				Console.WriteLine($"Successfully retrieved {usersList.Count} users");
			}
			catch (Exception ex)
			{
				DialogResult result = MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Console.WriteLine($"Error: {ex.Message}");
			}

			return usersList;
		}
	}
}
