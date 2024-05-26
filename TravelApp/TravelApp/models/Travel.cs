﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelApp.models;

namespace TravelApp.models
{
    public class Travel
    {
        public long TravelId { get; set; }
        public string TravelTitle { get; set; }
        public string TravelCity { get; set; }
        public List<TodoItem> TodoItems { get; set; }
        public DateTime TravelTime { get; set; }// 行程开始时间
        public string CreatedAt { get; set; } // 创建时间
        public long UserId { get; set; } // 直接存储用户 Id
        public Travel()
        {
            // 设置创建时间为当天的日期
            CreatedAt = DateTime.Now.ToString("yyyyMMdd");
        }

    }
}