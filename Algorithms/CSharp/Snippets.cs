using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.CSharp
{
    class Snippets
    {
        // Delegate and LINQ
        //    var result = AllMeals.Where(meal => meal.Days.Contains(day))
        //                .OrderBy(meal => (int)(meal.MealType));

        // Action is a Func without a return. Action param gets filled with anonymous function ()
        // LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

        // System.Func
        // public delegate TResult Func<in T, out TResult>(T arg);

        // System.Action
        // public delegate void Action();

        // Generic class DataStore that implements generic IDataStore. T is has to inherit from BaseEntity and has to have an empty constructor
        // public class DataStore<T> : IDataStore<T> where T : BaseEntity, new()

        

        // This
        //public Task<T> GetAsync()
        //{
        //    return _database.Table<T>()
        //                    .Where(i => i.Id == 5)
        //                    .FirstOrDefaultAsync();
        //}

        // Is equal to this
        //public Task<T> GetAsync(int id)
        //{
        //    return _stuff.Where(Test)
        //                .FirstOrDefaultAsync();
        //}

        //public bool Test(T i)
        //{
        //    return i.Id == 5;
        //}
    }
}
