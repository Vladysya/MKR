using System;

namespace ConsoleApp1
{
    interface ILamp
    {
        string type { get; set; }
        string manufacturer { get; set; }
        int power { set; }
        void GetInfo();
        void ChangePower();
    }
    interface ICamera
    {
        string type { get; set; }
        string manufacturer { get; set;}
        void LightSensitivity();
    }
    class Bush
    {
        public int CrownHeight { get; }

        public void GetInfo(ILamp l)
        {
            l.GetInfo();
        }

        public void ChangePower(ILamp l)
        {
            l.ChangePower();
        }
        public void ChangeLightSensitivity(ICamera l)
        {
            l.LightSensitivity();
        }
    }

    class PhotoStudio : ILamp, ICamera
    {
        public int CrownHeight => 9;

        public string type => throw new NotImplementedException();

        public int power { set => throw new NotImplementedException(); }
        public string manufacturer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string ILamp.type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string ICamera.type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ChangePower()
        {
            throw new NotImplementedException();
        }

        public void GetHeight()
        {
            Console.WriteLine($"Висота: {CrownHeight}");
        }

        public void GetInfo()
        {
            Console.WriteLine($"{GetType().Name}: Дерево");
        }

        public void LightSensitivity()
        {
            throw new NotImplementedException();
        }

        public void PlantName()
        {
            Console.WriteLine("Назва: Дуб");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
      
        }
    }
}
