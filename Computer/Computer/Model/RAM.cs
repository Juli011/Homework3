using ComputerApp.Device;
using ComputerApp.Interface;

namespace ComputerApp.Model
{
    internal class RAM : IComputerable, IRAMable
    {
        public RAM Eject()
        {
            return null;
        }

        public readonly Manufactorer RamKind;
        public RAM(Manufactorer RamKind)
        {
            this.RamKind=RamKind;   
        }
    }
}
