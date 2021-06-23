using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace cc_package_simplify
{
    class Converter
    {


        string htmlContent;
        string outHtmlName = "index.html";
        string[] preload = {
            "src/settings.js",
            "main.js",
            "cocos2d-js-min.js",
            "physics-min.js"
        };

        public Converter(string url)
        {


            string indexHtml = url + "/index.html";
            string cssHtml = url + "/style-mobile.css";


            htmlContent = File.ReadAllText(indexHtml);

            //clean html
            htmlContent = Regex.Replace(htmlContent, @"<link.*/>", "");
            htmlContent = Regex.Replace(htmlContent, @"<script.[\s\S]*</script>", "");

            //title
            var m = Regex.Match(htmlContent, @"<title.*title>");
            string real = $"<title>{m.Value.Substring(23, m.Value.Length - 8 - 23)}</title>";
            htmlContent = Regex.Replace(htmlContent, @"<title.*title>", real,RegexOptions.None);

            //preload js
            foreach( var js in preload )
            {
                if (!File.Exists(url + "/" + js)) continue;
                var jsContent = File.ReadAllText(url + "/" + js);
                var tag = $"<script charset = \"utf-8\" >\n\t{jsContent}\n</script>\n</body>";
                htmlContent = htmlContent.Replace("</body>", tag);
            }

            //css
            var cssContent = File.ReadAllText(cssHtml);
            cssContent = Regex.Replace(cssContent, @"background.*no-repeat center;", "background: #f3e2e2;",RegexOptions.None);
            htmlContent = htmlContent.Replace("</head>", "<style>\n\t" + cssContent + "\n</style>\n</head>");


            //launch
            htmlContent = htmlContent.Replace("</body>", "<script type=\"text/javascript\">\nwindow.boot();\n</script>\n</body>");
        }


        public void Output(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);



            File.WriteAllText(path + '/' + outHtmlName, htmlContent);
        }
    }
}
