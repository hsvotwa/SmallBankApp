namespace SmallBankApplication.Client
{
	public class Configuration
	{
		public string BaseUrl { get; set; }

		public Configuration()
		{
            //local
            BaseUrl = "/";

        }
    }
}
