using DbUp;
using System.Reflection;

namespace Tree.PostgresMigrator
{
	public class PostgresMigrator
	{
		public static void Migrate(string connectionString)
		{
			var upgrader = DeployChanges.To
				.PostgresqlDatabase(connectionString)
				.WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
				.Build();

			var result = upgrader.PerformUpgrade();

			if (!result.Successful)
			{
				throw new Exception("Migrate error: ", result.Error);
			}
		}
	}
}