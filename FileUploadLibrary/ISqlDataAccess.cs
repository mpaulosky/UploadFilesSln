namespace UploadFilesLibrary;

public interface ISqlDataAccess
{

	Task SaveData(string storedProcName, string connectionName, object parameters);

}