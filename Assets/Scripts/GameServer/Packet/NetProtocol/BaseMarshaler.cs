using Nettention.Proud;
using System;
using System.Collections.Generic;
using System.Net;
using NetProtocol.Packet;
using Guid = System.Guid;
using Vector3 = System.Numerics.Vector3;

namespace NetProtocol
{
    /// <summary>
    /// 자동으로 생성할 수 없는 데이터 타입을 이곳에 정의 합니다.
    /// </summary>
    public class BaseMarshaler : Marshaler
    {
        #region >>> bool
        public new static bool Read(Message msg, out bool value)
        {
            value = false;

            return msg.Read(out value);
        }
        public static bool Read(Message msg, out List<bool> value)
        {
            value = new();

            int count = 0;
            msg.ReadScalar(ref count);

            for (int i = 0; i < count; ++i)
            {
                bool val;
                if (!Read(msg, out val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<bool> value)
        {
            msg.WriteScalar(value.Count);

            for (int i = 0; i < value.Count; ++i)
            {
                Write(msg, value[i]);
            }
        }
        public static bool Read(Message msg, out bool[] value)
        {
            int count = 0;
            msg.ReadScalar(ref count);

            value = new bool[count];

            for (int i = 0; i < count; ++i)
            {
                bool val;
                if (!Read(msg, out val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, bool[] value)
        {
            msg.WriteScalar(value.Length);

            for (int i = 0; i < value.Length; ++i)
            {
                Write(msg, value[i]);
            }
        }
        #endregion
        #region >>> byte
        public new static bool Read(Message msg, out byte value)
        {
            value = 0;

            return msg.Read(out value);
        }
        public static bool Read(Message msg, out List<byte> value)
        {
            value = new();

            int count = 0;
            msg.ReadScalar(ref count);

            for (int i = 0; i < count; ++i)
            {
                byte val;
                if (!Read(msg, out val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<byte> value)
        {
            msg.WriteScalar(value.Count);

            for (int i = 0; i < value.Count; ++i)
            {
                Write(msg, value[i]);
            }
        }
        public static bool Read(Message msg, out byte[] value)
        {
            int count = 0;
            msg.ReadScalar(ref count);

            value = new byte[count];

            for (int i = 0; i < count; ++i)
            {
                byte val;
                if (!Read(msg, out val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, byte[] value)
        {
            msg.WriteScalar(value.Length);

            for (int i = 0; i < value.Length; ++i)
            {
                Write(msg, value[i]);
            }
        }

        public new static bool Read(Message msg, out sbyte value)
        {
            value = 0;

            return msg.Read(out value);
        }
        public static bool Read(Message msg, out List<sbyte> value)
        {
            value = new();

            int count = 0;
            msg.ReadScalar(ref count);

            for (int i = 0; i < count; ++i)
            {
                sbyte val;
                if (!Read(msg, out val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<sbyte> value)
        {
            msg.WriteScalar(value.Count);

            for (int i = 0; i < value.Count; ++i)
            {
                Write(msg, value[i]);
            }
        }
        public static bool Read(Message msg, out sbyte[] value)
        {
            int count = 0;
            msg.ReadScalar(ref count);

            value = new sbyte[count];

            for (int i = 0; i < count; ++i)
            {
                sbyte val;
                if (!Read(msg, out val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, sbyte[] value)
        {
            msg.WriteScalar(value.Length);

            for (int i = 0; i < value.Length; ++i)
            {
                Write(msg, value[i]);
            }
        }
        #endregion
        #region >>> short
        public new static bool Read(Message msg, out ushort value)
        {
            value = 0;

            return msg.Read(out value);
        }
        public static bool Read(Message msg, out List<ushort> value)
        {
            value = new();

            int count = 0;
            msg.ReadScalar(ref count);

            for (int i = 0; i < count; ++i)
            {
                ushort val;
                if (!Read(msg, out val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<ushort> value)
        {
            msg.WriteScalar(value.Count);

            for (int i = 0; i < value.Count; ++i)
            {
                Write(msg, value[i]);
            }
        }
        public static bool Read(Message msg, out ushort[] value)
        {
            int count = 0;
            msg.ReadScalar(ref count);

            value = new ushort[count];

            for (int i = 0; i < count; ++i)
            {
                ushort val;
                if (!Read(msg, out val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, ushort[] value)
        {
            msg.WriteScalar(value.Length);

            for (int i = 0; i < value.Length; ++i)
            {
                Write(msg, value[i]);
            }
        }

        public new static bool Read(Message msg, out short value)
        {
            value = 0;

            return msg.Read(out value);
        }
        public static bool Read(Message msg, out List<short> value)
        {
            value = new();

            int count = 0;
            msg.ReadScalar(ref count);

            for (int i = 0; i < count; ++i)
            {
                short val;
                if (!Read(msg, out val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<short> value)
        {
            msg.WriteScalar(value.Count);

            for (int i = 0; i < value.Count; ++i)
            {
                Write(msg, value[i]);
            }
        }
        public static bool Read(Message msg, out short[] value)
        {
            int count = 0;
            msg.ReadScalar(ref count);

            value = new short[count];

            for (int i = 0; i < count; ++i)
            {
                short val;
                if (!Read(msg, out val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, short[] value)
        {
            msg.WriteScalar(value.Length);

            for (int i = 0; i < value.Length; ++i)
            {
                Write(msg, value[i]);
            }
        }
        #endregion
        #region >>> int
        public new static bool Read(Message msg, out uint value)
        {
            value = 0U;

            return msg.Read(out value);
        }
        public static bool Read(Message msg, out List<uint> value)
        {
            value = new();

            int count = 0;
            msg.ReadScalar(ref count);

            for (int i = 0; i < count; ++i)
            {
                uint val;
                if (!Read(msg, out val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<uint> value)
        {
            msg.WriteScalar(value.Count);

            for (int i = 0; i < value.Count; ++i)
            {
                Write(msg, value[i]);
            }
        }
        public static bool Read(Message msg, out uint[] value)
        {
            int count = 0;
            msg.ReadScalar(ref count);

            value = new uint[count];

            for (int i = 0; i < count; ++i)
            {
                uint val;
                if (!Read(msg, out val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, uint[] value)
        {
            msg.WriteScalar(value.Length);

            for (int i = 0; i < value.Length; ++i)
            {
                Write(msg, value[i]);
            }
        }

        public new static bool Read(Message msg, out int value)
        {
            value = 0;

            return msg.Read(out value);
        }
        public static bool Read(Message msg, out List<int> value)
        {
            value = new();

            int count = 0;
            msg.ReadScalar(ref count);
            for (int i = 0; i < count; ++i)
            {
                int val;
                if (!Read(msg, out val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<int> value)
        {
            msg.WriteScalar(value.Count);
            foreach (int temp in value)
            {
                Write(msg, temp);
            }
        }
        public static bool Read(Message msg, out int[] value)
        {
            int count = 0;
            msg.ReadScalar(ref count);

            value = new int[count];

            for (int i = 0; i < count; ++i)
            {
                int val;
                if (!Read(msg, out val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, int[] value)
        {
            msg.WriteScalar(value.Length);
            foreach (int temp in value)
            {
                Write(msg, temp);
            }
        }
        #endregion
        #region >>> long
        public new static bool Read(Message msg, out ulong value)
        {
            value = 0UL;

            return msg.Read(out value);
        }
        public static bool Read(Message msg, out List<ulong> value)
        {
            value = new();

            int count = 0;
            msg.ReadScalar(ref count);

            for (int i = 0; i < count; ++i)
            {
                ulong val;
                if (!Read(msg, out val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<ulong> value)
        {
            msg.WriteScalar(value.Count);

            for (int i = 0; i < value.Count; ++i)
            {
                Write(msg, value[i]);
            }
        }
        public static bool Read(Message msg, out ulong[] value)
        {
            int count = 0;
            msg.ReadScalar(ref count);

            value = new ulong[count];

            for (int i = 0; i < count; ++i)
            {
                ulong val;
                if (!Read(msg, out val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, ulong[] value)
        {
            msg.WriteScalar(value.Length);

            for (int i = 0; i < value.Length; ++i)
            {
                Write(msg, value[i]);
            }
        }

        public new static bool Read(Message msg, out long value)
        {
            value = 0L;

            return msg.Read(out value);
        }
        public static bool Read(Message msg, out List<long> value)
        {
            value = new();

            int count = 0;
            msg.ReadScalar(ref count);

            for (int i = 0; i < count; ++i)
            {
                long val;
                if (!Read(msg, out val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<long> value)
        {
            msg.WriteScalar(value.Count);

            for (int i = 0; i < value.Count; ++i)
            {
                Write(msg, value[i]);
            }
        }
        public static bool Read(Message msg, out long[] value)
        {
            int count = 0;
            msg.ReadScalar(ref count);

            value = new long[count];

            for (int i = 0; i < count; ++i)
            {
                long val;
                if (!Read(msg, out val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, long[] value)
        {
            msg.WriteScalar(value.Length);

            for (int i = 0; i < value.Length; ++i)
            {
                Write(msg, value[i]);
            }
        }
        #endregion
        #region >>> float
        public new static bool Read(Message msg, out float value)
        {
            value = 0.0f;

            return msg.Read(out value);
        }
        public static bool Read(Message msg, out List<float> value)
        {
            value = new();

            int count = 0;
            msg.ReadScalar(ref count);

            for (int i = 0; i < count; ++i)
            {
                float val;
                if (!Read(msg, out val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<float> value)
        {
            msg.WriteScalar(value.Count);

            for (int i = 0; i < value.Count; ++i)
            {
                Write(msg, value[i]);
            }
        }
        public static bool Read(Message msg, out float[] value)
        {
            int count = 0;
            msg.ReadScalar(ref count);

            value = new float[count];

            for (int i = 0; i < count; ++i)
            {
                float val;
                if (!Read(msg, out val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, float[] value)
        {
            msg.WriteScalar(value.Length);

            for (int i = 0; i < value.Length; ++i)
            {
                Write(msg, value[i]);
            }
        }
        #endregion
        #region >>> double
        public new static bool Read(Message msg, out double value)
        {
            value = 0.0;

            return msg.Read(out value);
        }
        public static bool Read(Message msg, out List<double> value)
        {
            value = new();

            int count = 0;
            msg.ReadScalar(ref count);

            for (int i = 0; i < count; ++i)
            {
                double val;
                if (!Read(msg, out val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<double> value)
        {
            msg.WriteScalar(value.Count);

            for (int i = 0; i < value.Count; ++i)
            {
                Write(msg, value[i]);
            }
        }
        public static bool Read(Message msg, out double[] value)
        {
            int count = 0;
            msg.ReadScalar(ref count);

            value = new double[count];

            for (int i = 0; i < count; ++i)
            {
                double val;
                if (!Read(msg, out val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, double[] value)
        {
            msg.WriteScalar(value.Length);

            for (int i = 0; i < value.Length; ++i)
            {
                Write(msg, value[i]);
            }
        }
        #endregion
        #region >>> string
        public new static bool Read(Message msg, out string value)
        {
            value = string.Empty;

            return msg.Read(out value);
        }
        public static bool Read(Message msg, out List<string> value)
        {
            value = new();

            int count = 0;
            msg.ReadScalar(ref count);

            for (int i = 0; i < count; ++i)
            {
                string val;
                if (!Read(msg, out val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<string> value)
        {
            msg.WriteScalar(value.Count);

            for (int i = 0; i < value.Count; ++i)
            {
                Write(msg, value[i]);
            }
        }
        public static bool Read(Message msg, out string[] value)
        {
            int count = 0;
            msg.ReadScalar(ref count);

            value = new string[count];

            for (int i = 0; i < count; ++i)
            {
                string val;
                if (!Read(msg, out val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, string[] value)
        {
            msg.WriteScalar(value.Length);

            for (int i = 0; i < value.Length; ++i)
            {
                Write(msg, value[i]);
            }
        }
        #endregion

        #region >>> tuple extend
        public static bool Read(Message msg, out (uint, byte) value)
        {
            value = new();

            if (!msg.Read(out value.Item1))
                return false;

            if (!msg.Read(out value.Item2))
                return false;

            return true;
        }
        public static bool Write(Message msg, (uint, byte) value)
        {
            msg.Write(value.Item1);
            msg.Write(value.Item2);

            return true;
        }
        public static bool Read(Message msg, out (uint, byte)[] value)
        {
            int count = 0;
            msg.ReadScalar(ref count);

            value = new (uint, byte)[count];

            for (int i = 0; i < count; ++i)
            {
                (uint, byte) val;
                if (!Read(msg, out val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, (uint, byte)[] value)
        {
            msg.WriteScalar(value.Length);

            for (int i = 0; i < value.Length; ++i)
            {
                Write(msg, value[i]);
            }
        }
        public static bool Read(Message msg, out (uint, ushort) value)
        {
            value = new();

            if (!msg.Read(out value.Item1))
                return false;

            if (!msg.Read(out value.Item2))
                return false;

            return true;
        }
        public static bool Write(Message msg, (uint, ushort) value)
        {
            msg.Write(value.Item1);
            msg.Write(value.Item2);

            return true;
        }
        public static bool Read(Message msg, out (uint, ushort)[] value)
        {
            int count = 0;
            msg.ReadScalar(ref count);

            value = new (uint, ushort)[count];

            for (int i = 0; i < count; ++i)
            {
                (uint, ushort) val;
                if (!Read(msg, out val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, (uint, ushort)[] value)
        {
            msg.WriteScalar(value.Length);

            for (int i = 0; i < value.Length; ++i)
            {
                Write(msg, value[i]);
            }
        }
        public static bool Read(Message msg, out (uint, uint) value)
        {
            value = new();

            if (!msg.Read(out value.Item1))
                return false;

            if (!msg.Read(out value.Item2))
                return false;

            return true;
        }
        public static bool Write(Message msg, (uint, uint) value)
        {
            msg.Write(value.Item1);
            msg.Write(value.Item2);

            return true;
        }
        public static bool Read(Message msg, out (uint, uint)[] value)
        {
            int count = 0;
            msg.ReadScalar(ref count);

            value = new (uint, uint)[count];

            for (int i = 0; i < count; ++i)
            {
                (uint, uint) val;
                if (!Read(msg, out val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, (uint, uint)[] value)
        {
            msg.WriteScalar(value.Length);

            for (int i = 0; i < value.Length; ++i)
            {
                Write(msg, value[i]);
            }
        }

        //long
        public static bool Read(Message msg, out (long, byte) value)
        {
            value = new();

            if (!msg.Read(out value.Item1))
                return false;

            if (!msg.Read(out value.Item2))
                return false;

            return true;
        }
        public static bool Write(Message msg, (long, byte) value)
        {
            msg.Write(value.Item1);
            msg.Write(value.Item2);

            return true;
        }
        public static bool Read(Message msg, out (long, byte)[] value)
        {
            int count = 0;
            msg.ReadScalar(ref count);

            value = new (long, byte)[count];

            for (int i = 0; i < count; ++i)
            {
                (long, byte) val;
                if (!Read(msg, out val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, (long, byte)[] value)
        {
            msg.WriteScalar(value.Length);

            for (int i = 0; i < value.Length; ++i)
            {
                Write(msg, value[i]);
            }
        }
        public static bool Read(Message msg, out (long, ushort) value)
        {
            value = new();

            if (!msg.Read(out value.Item1))
                return false;

            if (!msg.Read(out value.Item2))
                return false;

            return true;
        }
        public static bool Write(Message msg, (long, ushort) value)
        {
            msg.Write(value.Item1);
            msg.Write(value.Item2);

            return true;
        }
        public static bool Read(Message msg, out (long, ushort)[] value)
        {
            int count = 0;
            msg.ReadScalar(ref count);

            value = new (long, ushort)[count];

            for (int i = 0; i < count; ++i)
            {
                (long, ushort) val;
                if (!Read(msg, out val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, (long, ushort)[] value)
        {
            msg.WriteScalar(value.Length);

            for (int i = 0; i < value.Length; ++i)
            {
                Write(msg, value[i]);
            }
        }
        public static bool Read(Message msg, out (long, uint) value)
        {
            value = new();

            if (!msg.Read(out value.Item1))
                return false;

            if (!msg.Read(out value.Item2))
                return false;

            return true;
        }
        public static bool Write(Message msg, (long, uint) value)
        {
            msg.Write(value.Item1);
            msg.Write(value.Item2);

            return true;
        }
        public static bool Read(Message msg, out (long, uint)[] value)
        {
            int count = 0;
            msg.ReadScalar(ref count);

            value = new (long, uint)[count];

            for (int i = 0; i < count; ++i)
            {
                (long, uint) val;
                if (!Read(msg, out val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, (long, uint)[] value)
        {
            msg.WriteScalar(value.Length);

            for (int i = 0; i < value.Length; ++i)
            {
                Write(msg, value[i]);
            }
        }
        #endregion
        #region >>> dictionary extend
        public static bool Read(Message msg, out Dictionary<uint, byte> value)
        {
            value = new();

            int count = 0;
            msg.ReadScalar(ref count);

            for (int i = 0; i < count; ++i)
            {
                uint key = 0;
                if (!Read(msg, out key))
                    return false;

                byte val;
                if (!Read(msg, out val))
                    return false;

                value.Add(key, val);
            }

            return true;
        }
        public static void Write(Message msg, Dictionary<uint, byte> value)
        {
            msg.WriteScalar(value.Count);

            foreach (var pair in value)
            {
                msg.Write(pair.Key);
                Write(msg, pair.Value);
            }
        }
        public static bool Read(Message msg, out Dictionary<uint, ushort> value)
        {
            value = new();

            int count = 0;
            msg.ReadScalar(ref count);

            for (int i = 0; i < count; ++i)
            {
                uint key = 0;
                if (!Read(msg, out key))
                    return false;

                ushort val;
                if (!Read(msg, out val))
                    return false;

                value.Add(key, val);
            }

            return true;
        }
        public static void Write(Message msg, Dictionary<uint, ushort> value)
        {
            msg.WriteScalar(value.Count);

            foreach (var pair in value)
            {
                msg.Write(pair.Key);
                Write(msg, pair.Value);
            }
        }
        public static bool Read(Message msg, out Dictionary<uint, uint> value)
        {
            value = new();

            int count = 0;
            msg.ReadScalar(ref count);

            for (int i = 0; i < count; ++i)
            {
                uint key = 0;
                if (!Read(msg, out key))
                    return false;

                uint val;
                if (!Read(msg, out val))
                    return false;

                value.Add(key, val);
            }

            return true;
        }
        public static void Write(Message msg, Dictionary<uint, uint> value)
        {
            msg.WriteScalar(value.Count);

            foreach (var pair in value)
            {
                msg.Write(pair.Key);
                Write(msg, pair.Value);
            }
        }
        public static bool Read(Message msg, out Dictionary<long, uint> value)
        {
            value = new();

            int count = 0;
            msg.ReadScalar(ref count);

            for (int i = 0; i < count; ++i)
            {
                long key = 0;
                if (!Read(msg, out key))
                    return false;

                uint val;
                if (!Read(msg, out val))
                    return false;

                value.Add(key, val);
            }

            return true;
        }
        public static void Write(Message msg, Dictionary<long, uint> value)
        {
            msg.WriteScalar(value.Count);

            foreach (var pair in value)
            {
                msg.Write(pair.Key);
                Write(msg, pair.Value);
            }
        }
        public static bool Read(Message msg, out Dictionary<long, int> value)
        {
            value = new Dictionary<long, int>();

            int count = 0;
            msg.ReadScalar(ref count);
            for (int i = 0; i < count; ++i)
            {
                long key = 0;
                if (!Read(msg, out key))
                    return false;

                int val;
                if (!Read(msg, out val))
                    return false;

                value.Add(key, val);
            }

            return true;
        }
        public static void Write(Message msg, Dictionary<long, int> value)
        {
            msg.WriteScalar(value.Count);
            foreach (KeyValuePair<long, int> pair in value)
            {
                msg.Write(pair.Key);
                Write(msg, pair.Value);
            }
        }
        
        public static bool Read(Message msg, out Dictionary<uint, uint[]> value)
        {
            value = new();

            int count = 0;
            msg.ReadScalar(ref count);

            for (int i = 0; i < count; ++i)
            {
                uint key = 0;
                if (!Read(msg, out key))
                    return false;

                uint[] val;
                if (!Read(msg, out val))
                    return false;

                value.Add(key, val);
            }

            return true;
        }
        public static void Write(Message msg, Dictionary<uint, uint[]> value)
        {
            msg.WriteScalar(value.Count);

            foreach (var pair in value)
            {
                msg.Write(pair.Key);
                Write(msg, pair.Value);
            }
        }
        
        public static bool Read(Message msg, out Dictionary<EquipSlot, bool> value)
        {
            value = new();

            int count = 0;
            msg.ReadScalar(ref count);

            for (int i = 0; i < count; ++i)
            {
                int key = 0;
                if (!Read(msg, out key))
                    return false;

                bool val;
                if (!Read(msg, out val))
                    return false;

                value.Add((EquipSlot)key, val);
            }

            return true;
        }
        public static void Write(Message msg, Dictionary<EquipSlot, bool> value)
        {
            msg.WriteScalar(value.Count);

            foreach (var pair in value)
            {
                msg.Write((int)pair.Key);
                Write(msg, pair.Value);
            }
        }
        #endregion

        #region >>> guid
        public new static bool Read(Message msg, out Guid value) => msg.Read(out value);

        public static bool Read(Message msg, out List<Guid> value)
        {
            value = new();

            int count = 0;
            msg.ReadScalar(ref count);

            for (int i = 0; i < count; ++i)
            {
                Guid val;
                if (!Read(msg, out val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<Guid> value)
        {
            msg.WriteScalar(value.Count);

            for (int i = 0; i < value.Count; ++i)
            {
                Write(msg, value[i]);
            }
        }
        public static bool Read(Message msg, out Guid[] value)
        {
            int count = 0;
            msg.ReadScalar(ref count);

            value = new Guid[count];

            for (int i = 0; i < count; ++i)
            {
                Guid val;
                if (!Read(msg, out val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, Guid[] value)
        {
            msg.WriteScalar(value.Length);

            for (int i = 0; i < value.Length; ++i)
            {
                Write(msg, value[i]);
            }
        }
        #endregion
        #region >>> vector3
        public static bool Read(Message msg, out Vector3 value)
        {
            value = new();

            if (!msg.Read(out value.X))
                return false;

            if (!msg.Read(out value.Y))
                return false;

            if (!msg.Read(out value.Z))
                return false;

            return true;
        }
        public static bool Write(Message msg, in Vector3 value)
        {
            msg.Write(value.X);
            msg.Write(value.Y);
            msg.Write(value.Z);

            return true;
        }
        public static bool Read(Message msg, out List<Vector3> value)
        {
            value = new();

            int count = 0;
            msg.ReadScalar(ref count);

            for (int i = 0; i < count; ++i)
            {
                Vector3 val;
                if (!Read(msg, out val))
                    return false;

                value.Add(val);
            }

            return true;
        }
        public static void Write(Message msg, List<Vector3> value)
        {
            msg.WriteScalar(value.Count);

            for (int i = 0; i < value.Count; ++i)
            {
                Write(msg, value[i]);
            }
        }
        public static bool Read(Message msg, out Vector3[] value)
        {
            int count = 0;
            msg.ReadScalar(ref count);

            value = new Vector3[count];

            for (int i = 0; i < count; ++i)
            {
                if (!Read(msg, out Vector3 val))
                    return false;

                value[i] = val;
            }

            return true;
        }
        public static void Write(Message msg, Vector3[] value)
        {
            msg.WriteScalar(value.Length);

            for (int i = 0; i < value.Length; ++i)
            {
                Write(msg, value[i]);
            }
        }
        #endregion
        #region >>> datetime
        public static bool Read(Message msg, out DateTime value)
        {
            value = new();

            long val;
            if (!msg.Read(out val))
                return false;

            value = new(val);

            return true;
        }
        public static bool Write(Message msg, in DateTime value)
        {
            msg.Write(value.Ticks);

            return true;
        }
        #endregion
        #region >>> proudnet type
        public new static bool Read(Message msg, out HostID value)
        {
            value = HostID.HostID_None;

            return msg.Read(out value);
        }
        public new static bool Read(Message msg, out ErrorType value)
        {
            value = ErrorType.Ok;

            return msg.Read(out value);
        }
        public new static bool Read(Message msg, out ByteArray value)
        {
            value = new();

            return msg.Read(out value);
        }
        public new static bool Read(Message msg, out NamedAddrPort value)
        {
            value = new();

            return msg.Read(out value);
        }
        #endregion
        #region >>> etc
        public new static bool Read(Message msg, out IPEndPoint value)
        {
            value = new(0L, 0);

            return msg.Read(out value);
        }
        #endregion
    }
}