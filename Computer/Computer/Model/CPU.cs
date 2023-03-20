using ComputerApp.Device;
using ComputerApp.Interface;

namespace ComputerApp.Model
{
    internal class CPU : IComputerable, ICPUable
    {
        public CPU Unplug()
        {
            return null;
        }
        public readonly Manufactorer cpuKind;
        public CPU(Manufactorer kind)
        {
            this.cpuKind = kind;
        }
        
    }
}
