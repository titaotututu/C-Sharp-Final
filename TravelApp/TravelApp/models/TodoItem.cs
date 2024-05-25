using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp.models
{
    public class TodoItem
    {
        public long ItemId { get; set; }
        public DateTime Time { get; set; }// 时间
        public string Place { get; set; }
        public string Description { get; set; }// 设置待办的时候写的“要做什么事情”
        public string ComplicationNote { get; set; }// 完成待办时的记录
        public string Picture { get; set; } //上传的照片
        public bool IsCompleted { get; set; }// 是否完成
        public long TravelId { get; set; }

        public TodoItem() { }

    }
}
