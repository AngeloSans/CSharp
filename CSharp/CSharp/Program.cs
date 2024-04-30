using CSharp.Behavior;
using CSharp.Creational;
using CSharp.Structural;
using System;

class Program
{
    static void Main(string[] args)
    {
        Blog blog = new Blog();

        Sub sub1 = new Sub("Angelo");
        blog.AddObserver(sub1);
        blog.PublishPost("Angelo dominou o padrão observer");
    }
}