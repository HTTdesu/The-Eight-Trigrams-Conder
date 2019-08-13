using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 八卦密码
{
    static class Coder
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static string encode(string text)
        {
            if (text.Length == 0)
            {
                return "";
            }

            byte[] foo = System.Text.Encoding.Unicode.GetBytes(text);
            byte[] src = new byte[((foo.Length - 1) / 3 + 1) * 3];
            Array.Clear(src, 0, src.Length);
            Array.Copy(foo, src, foo.Length);
            int remainder = src.Length - foo.Length;

            Dictionary<byte, char> m = new Dictionary<byte, char>();
            for (int index = 0; index < 64; index++)
            {
                m.Add(binary[index], mark[index]);
            }

            StringBuilder sb = new StringBuilder("");
            int i = 0, tmp = 0;
            while (i < src.Length)
            {
                tmp = (src[i] & 0xFC) >> 2;
                sb.Append(m[(byte)tmp]);

                tmp = (src[i] & 0x03) << 4;
                i++;
                tmp = tmp | ((src[i] & 0xF0) >> 4);
                sb.Append(m[(byte)tmp]);

                tmp = (src[i] & 0x0F) << 2;
                i++;
                tmp = tmp | ((src[i] & 0xC0) >> 6);
                sb.Append(m[(byte)tmp]);

                tmp = src[i] & 0x3F;
                i++;
                sb.Append(m[(byte)tmp]);
            }

            return sb.ToString().Substring(0, sb.Length - remainder);
        }

        public static string decode(string text)
        {
            if (text.Length == 0)
            {
                return "";
            }

            Dictionary<char, byte> m = new Dictionary<char, byte>();
            for (int index = 0; index < 64; index++)
            {
                m.Add(mark[index], binary[index]);
            }
            StringBuilder sb = new StringBuilder("");
            for (int index = 0; index < text.Length; index++)
            {
                char t = text[index];
                if (m.ContainsKey(t))
                {
                    sb.Append(t);
                }
            }
            text = sb.ToString();

            int remainder = ((text.Length - 1) / 4 + 1) * 4 - text.Length;
            string src = null;
            switch (remainder)
            {
                case 0:
                    src = string.Copy(text);
                    break;
                case 1:
                    src = text + "\u4DC1";
                    break;
                case 2:
                    src = text + "\u4DC1\u4DC1";
                    break;
            }

            byte[] res = new byte[src.Length / 4 * 3];
            int i = 0, j = 0, tmp = 0, foo = 0;
            while (i < src.Length)
            {
                tmp = m[src[i]] << 2;
                i++;

                foo = m[src[i]];
                i++;
                tmp = tmp | ((foo & 0x30) >> 4);
                res[j] = (byte)tmp;
                j++;

                tmp = (foo & 0x0F) << 4;
                foo = m[src[i]];
                i++;
                tmp = tmp | ((foo & 0x3C) >> 2);
                res[j] = (byte)tmp;
                j++;

                tmp = (foo & 0x03) << 6;
                foo = m[src[i]];
                i++;
                tmp = tmp | foo;
                res[j] = (byte)tmp;
                j++;
            }

            byte[] bar = new byte[res.Length - remainder];
            Array.Copy(res, bar, bar.Length);
            return System.Text.Encoding.Unicode.GetString(bar);
        }

        public static char[] mark = new char[] {
            '\u4DC0',
            '\u4DC1',
            '\u4DC2',
            '\u4DC3',
            '\u4DC4',
            '\u4DC5',
            '\u4DC6',
            '\u4DC7',
            '\u4DC8',
            '\u4DC9',
            '\u4DCA',
            '\u4DCB',
            '\u4DCC',
            '\u4DCD',
            '\u4DCE',
            '\u4DCF',
            '\u4DD0',
            '\u4DD1',
            '\u4DD2',
            '\u4DD3',
            '\u4DD4',
            '\u4DD5',
            '\u4DD6',
            '\u4DD7',
            '\u4DD8',
            '\u4DD9',
            '\u4DDA',
            '\u4DDB',
            '\u4DDC',
            '\u4DDD',
            '\u4DDE',
            '\u4DDF',
            '\u4DE0',
            '\u4DE1',
            '\u4DE2',
            '\u4DE3',
            '\u4DE4',
            '\u4DE5',
            '\u4DE6',
            '\u4DE7',
            '\u4DE8',
            '\u4DE9',
            '\u4DEA',
            '\u4DEB',
            '\u4DEC',
            '\u4DED',
            '\u4DEE',
            '\u4DEF',
            '\u4DF0',
            '\u4DF1',
            '\u4DF2',
            '\u4DF3',
            '\u4DF4',
            '\u4DF5',
            '\u4DF6',
            '\u4DF7',
            '\u4DF8',
            '\u4DF9',
            '\u4DFA',
            '\u4DFB',
            '\u4DFC',
            '\u4DFD',
            '\u4DFE',
            '\u4DFF'
    };

        public static byte[] binary = new byte[] {
            0x3F,
            0x00,
            0x11,
            0x22,
            0x17,
            0x3A,
            0x02,
            0x10,
            0x37,
            0x3B,
            0x07,
            0x38,
            0x3D,
            0x2F,
            0x04,
            0x08,
            0x19,
            0x26,
            0x03,
            0x30,
            0x29,
            0x25,
            0x20,
            0x01,
            0x39,
            0x27,
            0x21,
            0x1E,
            0x12,
            0x2D,
            0x1C,
            0x0E,
            0x3C,
            0x0F,
            0x28,
            0x05,
            0x35,
            0x2B,
            0x14,
            0x0A,
            0x23,
            0x31,
            0x1F,
            0x3E,
            0x18,
            0x06,
            0x1A,
            0x16,
            0x1D,
            0x2E,
            0x09,
            0x24,
            0x34,
            0x0B,
            0x0D,
            0x2C,
            0x36,
            0x1B,
            0x32,
            0x13,
            0x33,
            0x0C,
            0x15,
            0x2A
    };
    }
}
