using System;

namespace HealthCheckPro
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class PublicAPIAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class RequiresAuthAttribute : Attribute
    {
    }

    // Add more attributes as needed, e.g., for other requirements
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class RequiresRoleAttribute : Attribute
    {
        public string Role { get; }
        public RequiresRoleAttribute(string role)
        {
            Role = role;
        }
    }
}
