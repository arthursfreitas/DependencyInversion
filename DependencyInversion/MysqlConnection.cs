using System;
namespace DependencyInversion
{

	public class MysqlConnection: IDatabaseConnection
	{
		//Dependency Inversion
		public void Connect() { }
	}
}

