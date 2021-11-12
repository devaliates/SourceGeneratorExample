using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

using System.Text;

namespace Source1
{
    [Generator]
    public class HelloWorldSourceGenerator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            var builder = new StringBuilder(@"
                            using System;
                            namespace HelloWorldGenerated
                            {
                                public static class HelloWorld
                                {
                                    public static void SayHello()
                                    {
                                        Console.WriteLine(""Hello from generated code!"");
                                    }
                                }
                            }");

            context.AddSource("generatedCode.cs", SourceText.From(builder.ToString(), Encoding.UTF8));
        }

        public void Initialize(GeneratorInitializationContext context)
        {
        }
    }
}