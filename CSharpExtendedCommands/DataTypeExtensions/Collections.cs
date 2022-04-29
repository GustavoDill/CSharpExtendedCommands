using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExtendedCommands.DataTypeExtensions
{
    namespace Collections
    {
        public static class CollectionsExtension
        {

            public static T[] Search<T>(this T[] obj, string search, string propname) => obj.Search(search, propname, false);
            public static List<T> Search<T>(this List<T> obj, string search, string propname, bool caseSensitive) => obj.ToArray().Search(search, propname, caseSensitive).ToList();
            public static List<T> Search<T>(this List<T> obj, string search, string propname) => obj.ToList().Search(search, propname, false);
            public static List<string> Search(this List<string> obj, string search) => Search(obj.ToArray(), search).ToList();
            public static List<string> Search(this List<string> obj, string search, bool caseSensitive) => Search(obj.ToArray(), search, caseSensitive).ToList();
            public static string[] Search(this string[] obj, string search) => Search(obj, search, false);
            public static string[] Search(this string[] obj, string search, bool caseSensitive)
            {
                if (caseSensitive)
                {
                    List<string> ret = new List<string>();
                    foreach (var o in obj)
                        if (o.Contains(search))
                            ret.Add(o);
                    return ret.ToArray();
                }
                else
                {
                    List<string> ret = new List<string>();
                    foreach (var o in obj)
                        if (o.ToLower().Contains(search.ToLower()))
                            ret.Add(o);
                    return ret.ToArray();
                }
            }
            public static T[] Search<T>(this T[] obj, string search, string propname, bool caseSensitive)
            {
                List<T> res = new List<T>();
                foreach (var o in obj)
                    try { if (caseSensitive) if (o.GetType().GetProperty(propname).GetValue(o, null).ToString().Contains(search)) res.Add(o); else { } else if (o.GetType().GetProperty(propname).GetValue(o, null).ToString().ToLower().Contains(search.ToLower())) res.Add(o); }
                    catch { }
                return res.ToArray();
            }
            public static ResultType[] GetPropertyArray<ResultType>(this object[] obj, string propname)
            {
                List<ResultType> props = new List<ResultType>();
                foreach (var o in obj)
                    props.Add((ResultType)o.GetType().GetProperty(propname).GetValue(o, null));
                return props.ToArray();
            }
            public static object[] ToObjectArray<T>(this T[] obj)
            {
                List<object> objs = new List<object>();
                foreach (var o in obj)
                    objs.Add((object)o);
                return objs.ToArray();
            }
            public static Enumerator GetEnum<Enumerator>(this string obj, Enumerator defaultReturn) where Enumerator : Enum
            {
                foreach (var val in Enum.GetNames(typeof(Enumerator)))
                    if (val.ToString().ToLower() == obj.ToLower()) return (Enumerator)Enum.Parse(typeof(Enumerator), val);
                return defaultReturn;
            }
            public static Enumerator GetEnum<Enumerator>(this int obj, Enumerator defaultReturn) where Enumerator : Enum
            {
                foreach (var val in Enum.GetNames(typeof(Enumerator)))
                    if ((int)Enum.Parse(typeof(Enumerator), val) == obj)
                        return (Enumerator)Enum.Parse(typeof(Enumerator), val);
                return defaultReturn;
            }
        }
    }
}
