using DiscordRPC.IO;
using System;
using System.IO;

namespace RecklessBoon.MacroDeck.Discord.RPC
{
    internal class PipeFrameHelper
    {
        public static PipeFrame ReadStream(Stream stream)
        {
            if (!TryReadUInt32(stream, out uint value))
            {
                return default(PipeFrame);
            }

            if (!TryReadUInt32(stream, out uint value2))
            {
                return default(PipeFrame);
            }

            uint num = value2;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                byte[] array = new byte[Min(2048, value2)];
                int count;
                while ((count = stream.Read(array, 0, Min(array.Length, num))) > 0)
                {
                    num -= (uint)array.Length;
                    memoryStream.Write(array, 0, count);
                }

                byte[] array2 = memoryStream.ToArray();
                if (array2.LongLength != value2)
                {
                    return default(PipeFrame);
                }

                return new PipeFrame()
                {
                    Opcode = (Opcode)value,
                    Data = array2
                };
            }
        }

        //
        // Summary:
        //     Returns minimum value between a int and a unsigned int
        private static int Min(int a, uint b)
        {
            if (b >= a)
            {
                return a;
            }

            return (int)b;
        }

        private static bool TryReadUInt32(Stream stream, out uint value)
        {
            byte[] array = new byte[4];
            if (stream.Read(array, 0, array.Length) != 4)
            {
                value = 0u;
                return false;
            }

            value = BitConverter.ToUInt32(array, 0);
            return true;
        }
    }
}
