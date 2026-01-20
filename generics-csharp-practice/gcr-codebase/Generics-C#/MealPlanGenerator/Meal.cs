
class Meal<T> where T : IMealPlan, new()
{
    public void Generate()
    {
        T meal = new T();
        meal.Prepare();
    }
}
