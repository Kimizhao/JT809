﻿using JT809.Protocol.Extensions;
using JT809.Protocol.Enums;
using JT809.Protocol.MessageBody;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;

namespace JT809.Protocol.Formatters.MessageBodyFormatters
{
    public class JT809_0x9007_Formatter : IJT809Formatter<JT809_0x9007>
    {
        public JT809_0x9007 Deserialize(ReadOnlySpan<byte> bytes, out int readSize)
        {
            int offset = 0;
            JT809_0x9007 jT809_0X9007 = new JT809_0x9007();
            jT809_0X9007.ReasonCode = (JT809_0x9007_ReasonCode)JT809BinaryExtensions.ReadByteLittle(bytes, ref offset);
            readSize = offset;
            return jT809_0X9007;
        }

        public int Serialize(ref byte[] bytes, int offset, JT809_0x9007 value)
        {
            offset += JT809BinaryExtensions.WriteByteLittle(bytes, offset,(byte)value.ReasonCode);
            return offset;
        }
    }
}
