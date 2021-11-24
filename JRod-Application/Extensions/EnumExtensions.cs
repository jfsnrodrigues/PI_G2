using System;
using System.Linq;
using System.Reflection;

namespace JRod_Application.Extensions
{
    public static class EnumExtensions
    {

        /// <summary>
        ///     A generic extension method that aids in reflecting 
        ///     and retrieving any attribute that is applied to an `Enum`.
        /// </summary>
        public static T GetAttribute<T>(this Enum enumValue)
                where T : Attribute
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<T>();
        }
    }
}
