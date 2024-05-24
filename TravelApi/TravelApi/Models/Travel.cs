using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TravelApi.Models;

public class Travel
{
    [Key]
    public long TravelId { get; set; }
    public string TravelTitle { get; set; }
    public string TravelCity { get; set; }
    public List<TodoItem> TodoItems { get; set; }
    public DateTime TravelTime { get; set; }// 行程开始时间
    public string CreatedAt { get; set; } // 创建时间

    // 外键
    public long UserId { get; set; } // 直接存储用户 Id

    // 导航属性
    [ForeignKey("UserId")]
    public User ?User { get; set; }// 暂时设置为可空，不然新建的时候总是报错

    public Travel()
    {
        // 设置创建时间为当天的日期
        CreatedAt = DateTime.Now.ToString("yyyyMMdd");
    }
}
