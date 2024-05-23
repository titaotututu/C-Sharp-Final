using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Weather_space
{
    class XmlOperator
    {
        // 序列化方法，将对象实例序列化为XML文件
        public static void Serialize<T>(string fileName, T instance)
        {
            // 创建一个XmlSerializer实例，用于序列化特定类型的对象
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            // 使用FileStream创建一个文件流，用于保存XML文件
            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                // 将对象序列化并写入文件
                xmlSerializer.Serialize(stream, instance);
            }
        }

        // 反序列化方法，从XML文件中反序列化为对象实例
        public static T Deserialize<T>(string fileName)
        {
            // 如果文件不存在，则返回默认值
            if (!File.Exists(fileName)) return default(T);
            // 创建一个XmlSerializer实例，用于反序列化特定类型的对象
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            // 使用FileStream打开文件流，用于读取XML文件
            using (FileStream stream = new FileStream(fileName, FileMode.Open))
            {
                // 将XML文件反序列化为对象并返回
                return (T)xmlSerializer.Deserialize(stream);
            }
        }
    }

    // 定义一个区域集合类，用于存储多个区域
    public class AreaCollection
    {
        // 存储区域对象的数组
        public Area[] Areas { set; get; }

        // 添加区域对象到集合中
        public void Add(Area area)
        {
            // 如果当前集合为空，则初始化为空数组
            if (this.Areas == null) this.Areas = new Area[0];
            // 将数组转换为List以便操作
            List<Area> list = this.Areas.ToList();
            // 如果集合中不包含该区域，则添加
            if (!list.Contains(area))
            {
                list.Add(area);
                // 将List转换回数组
                this.Areas = list.ToArray();
            }
        }

        // 从集合中移除区域对象
        public void Remove(Area area)
        {
            // 如果当前集合为空，则初始化为空数组
            if (this.Areas == null) this.Areas = new Area[0];
            // 将数组转换为List以便操作
            List<Area> list = this.Areas.ToList();
            // 如果集合中包含该区域，则移除
            if (list.Contains(area))
            {
                list.Remove(area);
                // 将List转换回数组
                this.Areas = list.ToArray();
            }
        }
    }

    // 定义一个区域类，实现IEquatable接口以便比较
    public class Area : IEquatable<Area>
    {
        // 区域的名称
        public string Name { set; get; }

        // 区域所属的省、市、区对象
        public PlaceModel Province { set; get; }
        public PlaceModel City { set; get; }
        public PlaceModel District { set; get; }

        // 实现Equals方法，用于比较两个区域对象是否相等
        public bool Equals(Area other)
        {
            // 比较名称、省、市、区是否相等
            if (this.Name == other.Name && this.Province.Equals(other.Province) && this.City.Equals(other.City) && this.District.Equals(other.District))
                return true;
            return false;
        }
    }
}
