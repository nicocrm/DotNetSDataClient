using System.IO;
using System.Text;
using System.Xml.XPath;
using Sage.SData.Client.Content;
using SimpleJson;

namespace Sage.SData.Client.Test
{
    internal static class Helpers
    {
        public static T ReadAtom<T>(string xml)
        {
            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(xml)))
            {
                return (T) new AtomContentHandler().ReadFrom(stream);
            }
        }

        public static XPathNavigator WriteAtom(object obj)
        {
            using (var stream = new MemoryStream())
            {
                new AtomContentHandler().WriteTo(obj, stream);
                stream.Seek(0, SeekOrigin.Begin);
                return new XPathDocument(stream).CreateNavigator();
            }
        }

        public static T ReadJson<T>(string json)
        {
            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(json)))
            {
                return (T) new JsonContentHandler().ReadFrom(stream);
            }
        }

        public static JsonObject WriteJson(object obj)
        {
            using (var stream = new MemoryStream())
            {
                new JsonContentHandler().WriteTo(obj, stream);
                stream.Seek(0, SeekOrigin.Begin);
                return (JsonObject) SimpleJson.SimpleJson.DeserializeObject(Encoding.UTF8.GetString(stream.ToArray()));
            }
        }
    }
}