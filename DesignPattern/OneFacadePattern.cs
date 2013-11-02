using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{

    public interface ITakePicture
    {
        void Open();
        void TakePhoto();
        void print();
        void Close();

    }
    public class OneFacadePattern:ITakePicture
    {
        Light light = new Light();
        Camera camera = new Camera();
        Print onePrint = new Print();

        public OneFacadePattern()
        {

        }
    
        public void Open()
        {
 	        light.Open();
            camera.Open();
            onePrint.Open();
        }

        public void TakePhoto()
        {
            camera.TakePicture();
        }

        public void print()
        {
            onePrint.print();
        }

        public void Close()
        {
            light.Close();
            camera.Close();
            onePrint.Close();
        }
}

    public class Light
    {
        public void Open()
        {
            Console.WriteLine("Light is open");

        }
        public void Close()
        {
            Console.WriteLine("Light is close");
        }
    }

    public class Print
    {
        public void Open()
        {
            Console.WriteLine("Print is open");

        }
        public void print()
        {
            Console.WriteLine("Printing .....");
        }
        public void Close()
        {
            Console.WriteLine("Print is close");
        }
    }

    public class Camera
    {
        public void TakePicture()
        {
            Console.WriteLine("Taking picture .....");
        }
        public void Open()
        {
            Console.WriteLine("Camera is open");

        }
        public void Close()
        {
            Console.WriteLine("Camers is close");
        }
    }
}
