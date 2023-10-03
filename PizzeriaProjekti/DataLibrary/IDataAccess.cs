namespace DataLibrary
{
    public interface IDataAccess
    {
        Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectiomString);
        Task SaveData<T>(string sql, T parameters, string connectiomString);
    }
}