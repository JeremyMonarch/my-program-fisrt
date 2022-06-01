using System;
using System.Net.Http;

namespace Lesson14.Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var notification = new ConsoleNotification();
            Animal animal = new Cat(notification);
            animal.Noise();
        }

        public interface INotification
        {
            void Notify(string message);
        }

        public class ConsoleNotification : INotification
        {
            public void Notify(string message)
            {
                Console.WriteLine("Котик каже няв!");
            }
        }

        public class HttpNotification : INotification
        {
            public void Notify(string message)
            {
                Console.WriteLine("Котик каже няв через hhtp!");
            }
        }

        public abstract class Animal
        {
            public abstract void Noise();
        }

        public class Cat : Animal
        {

            public INotification notification;
            public Cat(ConsoleNotification notification)
            {
                this.notification = notification;
            }

            public override void Noise()
            {
                notification.Notify("some message");
            }
        }

        public enum NoiseType
        {
            Console = 1,
            http = 2
        }
    }
}
