using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CssSprite
{
    public class Sprite
    {
        /// <summary>
        /// 图片路径
        /// </summary>
        private string _path;

        /// <summary>
        /// 距离x轴
        /// </summary>
        private int _locationX;

        /// <summary>
        /// 距离y轴
        /// </summary>
        private int _locationY;
        /// <summary>
        /// 图片宽度
        /// </summary>
        private int _width;
        /// <summary>
        /// 图片高度
        /// </summary>
        private int _height;

        /// <summary>
        /// 图片格式
        /// </summary>
        private string _format;

        [XmlAttribute("path")]
        public string path
        {
            get { return _path; }
            set { _path = value; }
        }

        [XmlAttribute("x")]
        public int x
        {
            get { return _locationX; }
            set { _locationX = value; }
        }

        [XmlAttribute("y")]
        public int y
        {
            get { return _locationY; }
            set { _locationY = value; }
        }

        [XmlAttribute("width")]
        public int width
        {
            get { return _width; }
            set { _width = value; }
        }

        [XmlAttribute("height")]
        public int height
        {
            get { return _height; }
            set { _height = value; }
        }
        [XmlAttribute("format")]
        public string format
        {
            get { return _format; }
            set { _format = value; }
        }
        [XmlAttribute("pixelRatio")]
        public int pixelRatio { get; set; } = 1; //默认值为1
    }

    ///// <summary>
    ///// sprite json格式存储对象，后续和Sprite合二为一
    ///// </summary>
    // class Spirte
    //{
    //    [JsonProperty(PropertyName = "x")]
    //    public int x { get; set; }
    //    public int y { get; set; }
    //    public int width { get; set; }
    //    public int height { get; set; }
    //    public int pixelRatio { get; set; } = 1; //默认值为1
    //    public string path { get; set; }
    //    public string format { get; set; }

    //}
}
