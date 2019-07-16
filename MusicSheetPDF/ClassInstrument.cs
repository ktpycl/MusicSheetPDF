using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace MusicSheetPDF
{

    public class ClassInstrument
    {

        //保存先のファイル名
        private static string fileName = @".\setting.xml";

        public class Detail
        {
            public String ShortName { get; set; }       // 略称
            public String FullName { get; set; }        // 正式名称
            public bool SheetWriteFlg { get; set; }     // 帳票表示フラグ
            public int Order { get; set; }              // 表示順
        }

        /// <summary>
        /// シリアル化できる、KeyValuePairに代わる構造体
        /// </summary>
        /// <typeparam name="TKey">Keyの型</typeparam>
        /// <typeparam name="TValue">Valueの型</typeparam>
        [Serializable]
        public struct KeyAndValue<TKey, TValue>
        {
            public TKey Key;
            public TValue Value;

            public KeyAndValue(KeyValuePair<TKey, TValue> pair)
            {
                Key = pair.Key;
                Value = pair.Value;
            }
        }

        /// <summary>
        /// DictionaryをKeyAndValueのListに変換する
        /// </summary>
        /// <typeparam name="TKey">Dictionaryのキーの型</typeparam>
        /// <typeparam name="TValue">Dictionaryの値の型</typeparam>
        /// <param name="dic">変換するDictionary</param>
        /// <returns>変換されたKeyAndValueのList</returns>
        public static List<KeyAndValue<TKey, TValue>>
            ConvertDictionaryToList<TKey, TValue>(Dictionary<TKey, TValue> dic)
        {
            List<KeyAndValue<TKey, TValue>> lst =
                new List<KeyAndValue<TKey, TValue>>();
            foreach (KeyValuePair<TKey, TValue> pair in dic)
            {
                lst.Add(new KeyAndValue<TKey, TValue>(pair));
            }
            return lst;
        }

        /// <summary>
        /// KeyAndValueのListをDictionaryに変換する
        /// </summary>
        /// <typeparam name="TKey">KeyAndValueのKeyの型</typeparam>
        /// <typeparam name="TValue">KeyAndValueのValueの型</typeparam>
        /// <param name="lst">変換するKeyAndValueのList</param>
        /// <returns>変換されたDictionary</returns>
        public static Dictionary<TKey, TValue>
            ConvertListToDictionary<TKey, TValue>(List<KeyAndValue<TKey, TValue>> lst)
        {
            Dictionary<TKey, TValue> dic = new Dictionary<TKey, TValue>();
            foreach (KeyAndValue<TKey, TValue> pair in lst)
            {
                dic.Add(pair.Key, pair.Value);
            }
            return dic;
        }

        /// <summary>
        /// DictionaryをXMLファイルに保存する
        /// </summary>
        /// <typeparam name="TKey">Dictionaryのキーの型</typeparam>
        /// <typeparam name="TValue">Dictionaryの値の型</typeparam>
        /// <param name="fileName">保存先のXMLファイル名</param>
        /// <param name="dic">保存するDictionary</param>
        public static void XmlSerialize<TKey, TValue>(
            string fileName, Dictionary<TKey, TValue> dic)
        {
            //シリアル化できる型に変換
            List<KeyAndValue<TKey, TValue>> obj = ConvertDictionaryToList(dic);

            //XMLファイルに保存
            XmlSerializer serializer =
                new XmlSerializer(typeof(List<KeyAndValue<TKey, TValue>>));
            StreamWriter sw =
                new StreamWriter(fileName, false, new UTF8Encoding(false));
            serializer.Serialize(sw, obj);
            sw.Close();
        }

        /// <summary>
        /// シリアル化されたXMLファイルをDictionaryに復元する
        /// </summary>
        /// <typeparam name="TKey">Dictionaryのキーの型</typeparam>
        /// <typeparam name="TValue">Dictionaryの値の型</typeparam>
        /// <param name="fileName">復元するXMLファイル名</param>
        /// <returns>復元されたDictionary</returns>
        public static Dictionary<TKey, TValue> XmlDeserialize<TKey, TValue>(
            string fileName)
        {
            //XMLファイルから復元
            XmlSerializer serializer =
                new XmlSerializer(typeof(List<KeyAndValue<TKey, TValue>>));
            StreamReader sr = new StreamReader(fileName, new UTF8Encoding(false));
            List<KeyAndValue<TKey, TValue>> obj =
                (List<KeyAndValue<TKey, TValue>>)serializer.Deserialize(sr);
            sr.Close();

            //Dictionaryに戻す
            Dictionary<TKey, TValue> dic = ConvertListToDictionary(obj);
            return dic;
        }

        public static Dictionary<string, Detail> readXml()
        {
            Dictionary<string, Detail> InstrumentDictionaly = new Dictionary<string, Detail>();

            //DictionaryをXMLファイルから復元する
            InstrumentDictionaly = XmlDeserialize<string, Detail>(fileName);

            return InstrumentDictionaly;
        }

        public static void writeXml(Dictionary<string, Detail> InstrumentDictionaly)
        {
            //DictionaryをXMLファイルに保存する
            XmlSerialize(fileName, InstrumentDictionaly);
        }

    }
}
