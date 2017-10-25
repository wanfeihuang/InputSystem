using System;

namespace ISX
{
    ////TODO: allow format to be any integer format
    public class DiscreteControl : InputControl<int>
    {
        public DiscreteControl()
        {
            m_StateBlock.format = InputStateBlock.kTypeInt;
        }

        protected override unsafe int ReadRawValueFrom(IntPtr statePtr)
        {
            var valuePtr = statePtr + (int)m_StateBlock.byteOffset;
            return *(int*)valuePtr;
        }
    }
}
