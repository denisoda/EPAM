namespace Matrix
{
    /// <summary>
    /// defines the way of addition of two elements
    /// </summary>
    /// <typeparam name="T">type of elements</typeparam>
    public interface ISum<T>
    {
        /// <summary>
        /// finds sum of two elements
        /// </summary>
        /// <param name="first">first element</param>
        /// <param name="second">second element</param>
        /// <returns>sum of two elements</returns>
        T Sum(T first, T second);
    }
}