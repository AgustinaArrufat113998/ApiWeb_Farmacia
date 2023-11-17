using System;
using System.Net.Http; 

public class ClientSingeton
{
	//public ClientSingeton()
	
	
		private static ClientSingleton instancia;
		private HttpClient client;
		private ClientSingleton()
		{
			client = new HttpClient(); ///  creo una unica instancia para todo el proyecto 
		}
		public static ClientSingleton GetInstance() 
		{
			if (instancia == null)
				instancia = new ClientSingleton();
			return instancia;
		}
		public async Task<string> GetAsync(string url)
		{
			var result = await client.GetAsync(url);
			var content = "";
			if (result.IsSuccessStatusCode)
				content = await result.Content.ReadAsStringAsync();
			return content;
		}
		public async Task<string> PostAsync(string url, string data)
		{
			StringContent content = new StringContent(data, Encoding.UTF8,
			"application/json");
			var result = await client.PostAsync(url, content);
			var response = "";
			if (result.IsSuccessStatusCode)
				response = await result.Content.ReadAsStringAsync();
			return response;
		}


	public async Task<string> DeleteAsync (string url)
	{
		var result = await client.DeleteAsync(url);
		var content = "";
		if (result.IsSuccessStatusCode)
			content = await result.Content.ReadAsStringAsync();
		return content;
	}// me devuelve un task por ser asincrono, el string -> el json que recibo del 
	// servidor 

}
}

