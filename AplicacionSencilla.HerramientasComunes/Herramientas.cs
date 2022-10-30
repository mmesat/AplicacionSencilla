using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace AplicacionSencilla.HerramientasComunes
{
    public class Herramientas
    {
        public static string Serialize(object obj)
        {
            Encoding enc = Encoding.GetEncoding("ISO-8859-1");
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            using (MemoryStream ms = new MemoryStream())
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Encoding = enc;
                settings.Indent = true;
                using (XmlWriter writer = XmlTextWriter.Create(ms, settings))
                {
                    serializer.Serialize(writer, obj);
                }
                byte[] array = ms.ToArray();
                array = Encoding.Convert(UTF8Encoding.UTF8, enc, array);
                return enc.GetString(array);
            }
        }

        /// <summary>
        /// Obtiene la descripción de una enumeración.
        /// </summary>
        /// <param name="en">Enumeración</param>
        /// <returns>Descripción de la enumeración</returns>
        public static string GetEnumDescription<T>(T en)
        {
            if (en == null)
                return "";

            Type type = en.GetType();
            return GetEnumDescription(type, en);
        }


        public static string GetEnumDescription(Type t, object value)
        {
            MemberInfo[] memInfo = t.GetMember(value.ToString());

            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)
                    return ((DescriptionAttribute)attrs[0]).Description;
            }

            return value.ToString();
        }

        public static Array GetEnumValues<T>()
        {
            return Enum.GetValues(typeof(T));
        }
    }
}
