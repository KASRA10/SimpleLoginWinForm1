using Newtonsoft.Json;

namespace simpleLoginWindows.Models
{
	public class UserHolders
	{
		[JsonProperty("id")]
		public int UserHolders_Id { get; set; }

		[JsonProperty("name")]
		public string UserHolders_FullName { get; set; }

		[JsonProperty("username")]
		public string UserHolders_UserName { get; set; }

		[JsonProperty("email")]
		public string UserHolders_UserEmail { get; set; }

		[JsonProperty("phone")]
		public string UserHolders_Phone { get; set; }
	}
}
