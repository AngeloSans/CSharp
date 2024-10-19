/*using System;
using System.Collections.Generic;

namespace CSharp.Behavior
{
    public interface IObserver
    {
        void Update(string postTitle);
    }

    public class Blog
    {
        private List<IObserver> observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void PublishPost(string postTitle)
        {
            Console.WriteLine($"Novo post publicado: {postTitle}");
            Notify(postTitle);
        }

        private void Notify(string postTitle)
        {
            foreach (var observer in observers)
            {
                observer.Update(postTitle);
            }
        }
    }

    public class Sub : IObserver
    {
        private string name;

        public Sub(string name)
        {
            this.name = name;
        }

        public void Update(string postTitle)
        {
            Console.WriteLine($"{name} recebeu uma notificação sobre o novo post: {postTitle}");
        }
    }
}
*/