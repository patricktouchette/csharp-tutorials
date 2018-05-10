using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Interfaces___Electronic_Device
{
    class Program
    {
        static void Main(string[] args)
        {
            IElectronicDevice TV = TVRemote.GetDevice();
            PowerButton powerButton = new PowerButton(TV);
            VolumeButton volumeButton = new VolumeButton(TV);

            powerButton.Execute();
            powerButton.Undo();

            volumeButton.Execute();
            volumeButton.Execute();
            volumeButton.Undo();
        }
    }

    interface IElectronicDevice
    {
        void On();
        void Off();
        void VolumeUp();
        void VolumeDown();
    }

    interface ICommand
    {
        void Execute();
        void Undo();
    }

    class Television : IElectronicDevice
    {
        public int Volume { get; set; }

        public void On()
        {
            Console.WriteLine("The TV is on");
        }

        public void Off()
        {
            Console.WriteLine("The TV is off");
        }

        public void VolumeDown()
        {
            if (Volume != 0) Volume--;
            Console.WriteLine($"The TV volume is at {Volume}");
        }

        public void VolumeUp()
        {
            if (Volume != 100) Volume++;
            Console.WriteLine($"The TV volume is at {Volume}");
        }
    }

    class PowerButton : ICommand
    {
        IElectronicDevice device;

        public PowerButton(IElectronicDevice device)
        {
            this.device = device;
        }
        public void Execute()
        {
            device.On();
        }

        public void Undo()
        {
            device.Off();
        }
        
    }

    class VolumeButton : ICommand
    {
        IElectronicDevice device;

        public VolumeButton(IElectronicDevice device)
        {
            this.device = device;
        }
        public void Execute()
        {
            device.VolumeUp();
        }

        public void Undo()
        {
            device.VolumeDown();
        }

    }

    class TVRemote
    {
        public static IElectronicDevice GetDevice()
        {
            return new Television();
        }
    }
}
