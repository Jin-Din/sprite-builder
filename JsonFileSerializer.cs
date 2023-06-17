using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace CssSprite
{
    public static class JsonFileSerializer
    {
        /// <summary>
        /// 读取JSON配置文件
        /// </summary>
        /// <param name="jsonfile">JSON文件路径</param>
        /// <returns></returns>
        public static SpriteFile LoadFromJson(string jsonfile)
        {
            var fileName = Path.GetFileNameWithoutExtension(jsonfile);
            using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
            {
                var result = JsonSerializerHelper.Deserialize<Dictionary<string, Sprite>>(file);
                SpriteFile spriteFile = new SpriteFile()
                {
                    ImageName = fileName,
                    SpriteList = new List<Sprite>()
                };
                foreach (KeyValuePair<string, Sprite> item in result)
                {
                    Sprite jsonValue = item.Value;
                    if (jsonValue.path == null)
                    {
                        //判断图片类型
                        string ext = jsonValue.format == null ? "png" : jsonValue.format;
                        jsonValue.path = item.Key + "." + ext;
                    }

                    spriteFile.SpriteList.Add(jsonValue);
                }
                return spriteFile;
            }
        }
        public class JsonSerializerHelper
        {
            public static T Deserialize<T>(System.IO.Stream json) where T : class
            {
                if (json == null)
                {
                    throw new ArgumentNullException("json", "JSON数据源为空或NULL");
                }

                try
                {
                    System.IO.TextReader txtReader = new System.IO.StreamReader(json);
                    return Deserialize<T>(txtReader);


                }
                catch (Exception ex)
                {
                    throw new ArgumentException("解析JSON数据失败,可能是json格式无效", ex);
                }
            }

            public static T Deserialize<T>(string json) where T : class
            {
                if (json == null)
                {
                    throw new ArgumentNullException("json", "所需参数为空");
                }

                try
                {

                    System.IO.TextReader txtReader = new System.IO.StringReader(json);

                    return Deserialize<T>(txtReader);

                }
                catch (Exception ex)
                {
                    throw new ArgumentException("无效或不支持JSON", ex);
                }
            }

            public static T Deserialize<T>(System.IO.TextReader txtReader) where T : class
            {
                if (txtReader == null)
                {
                    throw new ArgumentNullException("json", "所需参数为空");
                }

                try
                {


                    JsonSerializer jsonSerializer = new JsonSerializer();

                    T results = jsonSerializer.Deserialize<T>(new JsonTextReader(txtReader));

                    if (results != null)
                    {
                        return results;
                    }
                    else
                        return null;
                }
                catch (Exception ex)
                {
                    throw new ArgumentException("无效JSON", ex);
                }
            }

            public static string Serialize(object value)
            {
                try
                {
                    return JsonConvert.SerializeObject(value);

                }
                catch (Exception ex)
                {
                    throw new ArgumentException("无效JSON", ex);
                }
            }

        }
    }
}
