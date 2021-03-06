﻿using Hzdtf.Rabbit.Model.Standard.Utils;
using MessagePack;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hzdtf.Rabbit.Model.Standard.MessageQueue
{
    /// <summary>
    /// Rabbit交换机信息
    /// @ 黄振东
    /// </summary>
    [MessagePackObject]
    public class RabbitExchangeInfo
    {
        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("name")]
        [Key("name")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("type")]
        [Key("type")]
        public string Type
        {
            get;
            set;
        } = RabbitConfigUtil.DIRECT_EXCHANGE_NAME;

        /// <summary>
        /// 持久化
        /// </summary>
        [JsonProperty("persistent")]
        [Key("persistent")]
        public bool Persistent
        {
            get;
            set;
        }

        /// <summary>
        /// 队列集合
        /// </summary>
        [JsonProperty("queues")]
        [Key("queues")]
        public IList<RabbitQueueModel> Queues
        {
            get;
            set;
        }
    }

    /// <summary>
    /// Rabbit队列 
    /// </summary>
    [MessagePackObject]
    public class RabbitQueueModel
    {
        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("name")]
        [Key("name")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// 路由键集合
        /// </summary>
        [JsonProperty("routingKeys")]
        [Key("routingKeys")]
        public string[] RoutingKeys
        {
            get;
            set;
        }

        /// <summary>
        /// 自动删除队列
        /// </summary>
        [JsonProperty("autoDelQueue")]
        [Key("autoDelQueue")]
        public bool AutoDelQueue
        {
            get;
            set;
        }

        /// <summary>
        /// 接收质量数
        /// </summary>
        [JsonProperty("qos")]
        [Key("qos")]
        public ushort? Qos
        {
            get;
            set;
        }
    }
}
