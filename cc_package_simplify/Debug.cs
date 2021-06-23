using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace cc_package_simplify
{
    class Debug
    {
        public static string logContent = "";
        public static TextBox editorText = null;

        public static void setEditorText(TextBox t)
        {
            editorText = t;
        }

        public static void log(string content)
        {
#if DEBUG

            if (editorText != null)
                editorText.Text += $">{content}\n";
            else
                Console.WriteLine(content);

#else

            logContent += $"\n{DateTime.Now.ToString()}: {content}";
#endif
        }

        public static void outLog()
        {
            if (!Directory.Exists("log"))
                Directory.CreateDirectory("log");

            File.WriteAllText($"log/log_{DateTime.Now.ToString("yyyy_MM_dd$HH_mm_ss_fff")}.txt", logContent);
        }
    }
}
