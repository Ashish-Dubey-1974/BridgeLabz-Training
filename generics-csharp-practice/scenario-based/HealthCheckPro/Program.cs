
using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

namespace HealthCheckPro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HealthCheckPro - API Metadata Validator");
            Console.WriteLine("=======================================");

            // Load the current assembly
            Assembly assembly = Assembly.GetExecutingAssembly();

            // Find all types that are controllers (end with "Controller")
            var controllers = assembly.GetTypes()
                .Where(t => t.IsClass && t.Name.EndsWith("Controller"))
                .ToList();

            List<string> missingAnnotations = new List<string>();
            List<string> apiDocumentation = new List<string>();

            foreach (var controller in controllers)
            {
                Console.WriteLine($"\nScanning Controller: {controller.Name}");

                var methods = controller.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

                foreach (var method in methods)
                {
                    var attributes = method.GetCustomAttributes().ToList();

                    bool hasPublicAPI = attributes.Any(a => a is PublicAPIAttribute);
                    bool hasRequiresAuth = attributes.Any(a => a is RequiresAuthAttribute);
                    bool hasRequiresRole = attributes.Any(a => a is RequiresRoleAttribute);

                    if (!hasPublicAPI && !hasRequiresAuth && !hasRequiresRole)
                    {
                        missingAnnotations.Add($"{controller.Name}.{method.Name}");
                    }

                    // Generate documentation
                    string annotation = hasPublicAPI ? "[PublicAPI]" :
                                        hasRequiresAuth ? "[RequiresAuth]" :
                                        hasRequiresRole ? $"[RequiresRole({((RequiresRoleAttribute)attributes.First(a => a is RequiresRoleAttribute)).Role})]" :
                                        "[No Annotation]";

                    apiDocumentation.Add($"{controller.Name}.{method.Name}: {annotation}");
                }
            }

            Console.WriteLine("\n=== Missing Annotations ===");
            if (missingAnnotations.Any())
            {
                foreach (var item in missingAnnotations)
                {
                    Console.WriteLine($"WARNING: {item} is missing required annotations.");
                }
            }
            else
            {
                Console.WriteLine("All methods have appropriate annotations.");
            }

            Console.WriteLine("\n=== API Documentation ===");
            foreach (var doc in apiDocumentation)
            {
                Console.WriteLine(doc);
            }

            Console.WriteLine("\nHealthCheckPro scan completed.");
        }
    }
}
