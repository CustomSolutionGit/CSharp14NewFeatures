using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public static class ExtensionPropertiesEnabledInAdditionToExtensionMethods<T> where T : notnull
    {
        // Looks like not yet fully supported in C# 14
        //extension(IEnumerable<T> source)
        //{
        //    public string CountString() => string.Format("The count of items in collection is {0}", source.Count());

        //    // Метод-расширение для получения первого элемента
        //    public T FirstOrDefaultSafe(T defaultValue)
        //        => source.FirstOrDefault() ?? defaultValue;


        //    // Статическое свойство-расширение для самого типа
        //    public static string TypeName => $"IEnumerable<{typeof(T).Name}>";
        //}
    }
}
