using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Weather_space
{
    internal class Place
    {
        // 获取省份列表
        public static PlaceModel[] GetProvinces()
        {
            // 调用通用方法获取省份列表的JSON数据
            return GetPlaceList("http://www.weather.com.cn/data/city3jdata/china.html");
        }

        // 获取城市列表，传入省份对象
        public static PlaceModel[] GetCitys(PlaceModel province)
        {
            // 调用通用方法获取该省份下城市列表的JSON数据
            return GetPlaceList($"http://www.weather.com.cn/data/city3jdata/provshi/{province.ID}.html");
        }

        // 获取区县列表，传入省份和城市对象
        public static PlaceModel[] GetDistricts(PlaceModel province, PlaceModel city)
        {
            // 调用通用方法获取该城市下区县列表的JSON数据
            return GetPlaceList($"http://www.weather.com.cn/data/city3jdata/station/{province.ID}{city.ID}.html");
        }

        // 通用方法，用于通过URL获取地理位置数据
        static PlaceModel[] GetPlaceList(string url)
        {
            try
            {
                // 创建一个HTTP请求
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                // 发送请求并获取响应
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                // 读取响应数据
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    // 将响应数据读为字符串
                    string content = reader.ReadToEnd();
                    // 关闭响应
                    response.Close();
                    // 将JSON数据转换为PlaceModel数组并返回
                    return JsonToArray(content).ToArray();
                }
            }
            catch
            {
                // 如果出现异常，返回一个空的PlaceModel数组
                return new List<PlaceModel>().ToArray();
            }
        }

        // 将JSON字符串转换为PlaceModel数组
        static PlaceModel[] JsonToArray(string json)
        {
            List<PlaceModel> list = new List<PlaceModel>();
            // 去掉JSON字符串中的大括号，并按逗号分隔
            string[] array1 = json.Replace("{", "").Replace("}", "").Split(',');
            string[] array2;
            for (int i = 0; i < array1.Length; i++)
            {
                // 按冒号分隔键和值
                array2 = array1[i].Split(':');
                for (int j = 0; j < array2.Length; j = j + 2)
                {
                    // 创建PlaceModel对象并添加到列表中
                    list.Add(new PlaceModel { ID = array2[j].Replace("\"", ""), Name = array2[j + 1].Replace("\"", "") });
                }
            }
            // 将列表转换为数组并返回
            return list.ToArray();
        }
    }

    // 定义一个表示地理位置的类
    public class PlaceModel
    {
        // 地理位置的ID和名称
        public string ID { set; get; }
        public string Name { set; get; }

        // 重写Equals方法，用于比较两个PlaceModel对象是否相等
        public override bool Equals(object obj)
        {
            // 将传入的对象转换为PlaceModel类型
            PlaceModel pm = (PlaceModel)obj;
            // 比较ID和Name是否相等
            if (this.ID == pm.ID && this.Name == pm.Name)
                return true;
            return false;
        }

        // 重写GetHashCode方法，返回对象的哈希码
        public override int GetHashCode()
        {
            // 返回ID和Name拼接后的字符串的哈希码
            return (this.ID + this.Name).GetHashCode();
        }
    }
}
