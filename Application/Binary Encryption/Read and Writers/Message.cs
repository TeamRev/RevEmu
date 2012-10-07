using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JCore.Utils;

namespace Revolution.Core
{
    public class Message : ByteUtil
    {
        #region Variables

        private int _pPacketLength;
        public new byte[] BytesRemain { get; private set; }

        public int HeaderId { get; private set; }

        public int PacketLength
        {
            get
            {
                if (IsServerMessage)
                {
                    return base.Bytes.Count;
                }

                return _pPacketLength;
            }
            set { _pPacketLength = value; }
        }

        public bool IsServerMessage { get; private set; }

        #endregion

        #region Getters

        public byte[] GetBytes
        {
            get
            {
                if (IsServerMessage)
                {
                    return ParsedServerBytes();
                }

                return base.Bytes.ToArray();
            }
        }

        #endregion

        #region Constructors

        public Message(byte[] bytes)
            : base(bytes)
        {
            BytesRemain = null;
            IsServerMessage = false;
            PacketLength = NextInt32();
            HeaderId = NextInt16();

            FixLength();
        }

        public Message()
        { }

        public Message(uint headerid)
        {
            BytesRemain = null;
            IsServerMessage = true;
            HeaderId = (int)headerid;

            WriteInt16((short)headerid);
        }

        #endregion

        #region Readers

        public Int16 NextInt16()
        {
            return BitConverter.ToInt16(base.ReadBytes(2, true), 0);
        }

        public Int32 NextInt32()
        {
            return BitConverter.ToInt32(base.ReadBytes(4, true), 0);
        }

        public string NextString()
        {
            byte[] Bytes = base.ReadBytes(NextInt16());

            return Encoding.Default.GetString(Bytes);
        }

        public bool NextBool()
        {
            return BitConverter.ToBoolean(base.ReadBytes(1), 0);
        }

        #endregion

        #region Setters

        public void WriteInt16(Int16 data)
        {
            base.WriteBytes(BitConverter.GetBytes(data), true);
        }

        public void WriteInt32(Int32 data)
        {
            base.WriteBytes(BitConverter.GetBytes(data), true);
        }

        public void WriteString(string data)
        {
            WriteInt16((short)data.Length);

            base.WriteBytes(Encoding.Default.GetBytes(data));
        }

        public void WriteBool(bool data)
        {
            base.WriteBytes(BitConverter.GetBytes(data));
        }

        #endregion

        #region Parser

        private byte[] ParsedServerBytes()
        {
            byte[] Length = BitConverter.GetBytes(PacketLength);
            var Result = new List<byte>(base.Bytes);

            foreach (byte Byte in Length)
            {
                Result.Insert(0, Byte);
            }

            return Result.ToArray();
        }

        private void FixLength()
        {
            int SourceIndex = PacketLength + 4;
            int Length = base.Length - SourceIndex;

            if (SourceIndex == base.Length && Length == 0)
            {
                return;
            }

            BytesRemain = new byte[Length];
            Array.Copy(GetBytes, SourceIndex, BytesRemain, 0, Length);

            var Result = new byte[SourceIndex];
            Array.Copy(GetBytes, Result, SourceIndex);

            base.Bytes = Result.ToList();
        }

        #endregion
    }
}