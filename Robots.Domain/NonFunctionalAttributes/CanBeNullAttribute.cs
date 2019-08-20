using System;

namespace Robots.Domain
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
    public class CanBeNullAttribute : Attribute
    {

    }
}