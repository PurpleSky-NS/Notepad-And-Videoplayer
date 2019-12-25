namespace MyNotepad
{
    class TextManager
    {
        public static TextManager Instance { private set; get; } = new TextManager();

        private TextManager()
        {
            for (int i = 0; i < m_msg.Length; ++i)
                m_msg[i] = new GrayMsg();
        }

        private class GrayMsg
        {
            public int last = -1, next = -1;
            public char value = char.MinValue;
            public GrayMsg() { }
        }
        private GrayMsg[] m_msg = new GrayMsg[256];

        /// <summary>
        /// 添加文字信息
        /// </summary>
        /// <param name="gray">灰度值</param>
        /// <param name="text">文字</param>
        public void AddText(byte gray, char text)
        {
            m_msg[gray].value = text;

            for (int last = gray - 1; last >= 0 && last < gray; --last)
            {
                if (m_msg[last].value != char.MinValue)
                    break;
                m_msg[last].next = gray;
            }
            for (int next = gray + 1; next > gray && next < 256; ++next)
            {
                if (m_msg[next].value != char.MinValue)
                    break;
                m_msg[next].last = gray;
            }
        }

        /// <summary>
        /// 获取与灰度值最接近的文字
        /// </summary>
        /// <param name="gray">灰度值</param>
        /// <returns>最接近的文字</returns>
        public char GetText(byte gray)
        {
            if (m_msg[gray].value != char.MinValue)
                return m_msg[gray].value;

            if (m_msg[gray].last < 0)
                return m_msg[m_msg[gray].next].value;
            else if (m_msg[gray].next < 0)
                return m_msg[m_msg[gray].last].value;

            return (gray - m_msg[gray].last < m_msg[gray].next - gray ? m_msg[m_msg[gray].last].value : m_msg[m_msg[gray].next].value);
        }

    }
}
