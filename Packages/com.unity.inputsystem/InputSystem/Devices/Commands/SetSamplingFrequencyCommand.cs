using System.Runtime.InteropServices;
using UnityEngine.Experimental.Input.Utilities;

namespace UnityEngine.Experimental.Input.LowLevel
{
    /// <summary>
    /// For a device that is sampled periodically, set the frequency at which the device
    /// is sampled.
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = kSize)]
    public struct SetSamplingFrequencyCommand : IInputDeviceCommandInfo
    {
        public static FourCC Type { get { return new FourCC('S', 'S', 'P', 'L'); } }

        public const int kSize = InputDeviceCommand.kBaseCommandSize + sizeof(float);

        [FieldOffset(0)]
        public InputDeviceCommand baseCommand;

        [FieldOffset(InputDeviceCommand.kBaseCommandSize)]
        public float frequency;

        public FourCC GetTypeStatic()
        {
            return Type;
        }

        public static SetSamplingFrequencyCommand Create(float frequency)
        {
            return new SetSamplingFrequencyCommand
            {
                baseCommand = new InputDeviceCommand(Type, kSize),
                frequency = frequency
            };
        }
    }
}