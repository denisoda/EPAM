namespace projects.EPAM.NET.W.2018.Dzeraziak.16.XmlSolution.DAL
{
    public interface IDataProvider<T> 
    {
        T GetData();
    }
}