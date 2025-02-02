﻿/*----------------------------------------------------------------
    Copyright (C) 2015 Senparc
    
    文件名：CardCreateData.cs
    文件功能描述：所有类型的卡券数据
    
    
    创建标识：Senparc - 20150211
    
    修改标识：Senparc - 20150303
    修改描述：整理接口
    
    修改标识：Senparc - 20150323
    修改描述：添加会议门票类型
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Senparc.Weixin.MP.Entities;

namespace Senparc.Weixin.MP.AdvancedAPIs.Card
{
    /* 所有类型的卡券数据 */


    /// <summary>
    /// 通用券数据
    /// </summary>
    public class Card_GeneralCouponData : BaseCardInfo
    {
        /// <summary>
        /// 描述文本
        /// 必填
        /// </summary>
        public string default_detail { get; set; }

        public Card_GeneralCouponData()
            : base(CardType.GENERAL_COUPON)
        {
        }
    }

    /// <summary>
    /// 团购券数据
    /// </summary>
    public class Card_GrouponData : BaseCardInfo
    {
        /// <summary>
        /// 团购券专用，团购详情
        /// 必填
        /// </summary>
        public string deal_detail { get; set; }

        public Card_GrouponData()
            : base(CardType.GROUPON)
        {
        }
    }

    /// <summary>
    /// 礼品券数据
    /// </summary>
    public class Card_GiftData : BaseCardInfo
    {
        /// <summary>
        /// 礼品券专用，表示礼品名字
        /// 必填
        /// </summary>
        public string gift { get; set; }

        public Card_GiftData()
            : base(CardType.GIFT)
        {
        }
    }

    /// <summary>
    /// 代金券数据
    /// </summary>
    public class Card_CashData : BaseCardInfo
    {
        /// <summary>
        /// 代金券专用，表示起用金额（单位为分）
        /// 非必填
        /// </summary>
        public decimal least_cost { get; set; }
        /// <summary>
        /// 代金券专用，表示减免金额（单位为分）
        /// 必填
        /// </summary>
        public decimal reduce_cost { get; set; }

        public Card_CashData()
            : base(CardType.CASH)
        {
        }
    }

    /// <summary>
    /// 折扣券数据
    /// </summary>
    public class Card_DisCountData : BaseCardInfo
    {
        /// <summary>
        ///折扣券专用，表示打折额度（百分比）。填30 就是七折。
        /// 必填
        /// </summary>
        public float discount { get; set; }
       
        public Card_DisCountData()
            : base(CardType.DISCOUNT)
        {
        }
    }

    /// <summary>
    /// 会员卡数据
    /// </summary>
    public class Card_MemberCardData : BaseCardInfo
    {
        /// <summary>
        /// 是否支持积分，填写true 或false，如填写true，积分相关字段均为必填。填写false，积分字段无需填写。储值字段处理方式相同。
        /// 必填
        /// </summary>
        public bool supply_bonus { get; set; }
        /// <summary>
        /// 是否支持储值，填写true 或false。
        /// 必填
        /// </summary>
        public bool supply_balance { get; set; }
        /// <summary>
        /// 设置为true时用户领取会员卡后系统自动将其激活，无需调用激活接口。
        /// 非必填
        /// </summary>
        public bool auto_activate { get; set; }
        /// <summary>
        /// 积分清零规则
        /// 非必填
        /// </summary>
        public string bonus_cleared { get; set; }
        /// <summary>
        /// 积分规则
        /// 非必填
        /// </summary>
        public string bonus_rules { get; set; }
        /// <summary>
        /// 储值说明
        /// 非必填
        /// </summary>
        public string balance_rules { get; set; }
        /// <summary>
        /// 特权说明
        /// 必填
        /// </summary>
        public string prerogative { get; set; }
        /// <summary>
        /// 绑定旧卡的url，与“activate_url”字段二选一必填。
        /// </summary>
        public string bind_old_card_url { get; set; }
        /// <summary>
        /// 激活会员卡的url，与“bind_old_card_url”字段二选一必填。
        /// </summary>
        public string activate_url { get; set; }
        /// <summary>
        /// 设置跳转外链查看积分详情。仅适用于积分无法通过激活接口同步的情况下使用该字段。
        /// 非必填
        /// </summary>
        public string bonus_url { get; set; }
        /// <summary>
        /// 设置跳转外链查看余额详情。仅适用于余额无法通过激活接口同步的情况下使用该字段。
        /// 非必填
        /// </summary>
        public string balance_url { get; set; }
        /// <summary>
        /// 自定义会员信息类目，会员卡激活后显示。
        /// 非必填
        /// </summary>
        public CustomField custom_field1 { get; set; }
        /// <summary>
        /// 自定义会员信息类目，会员卡激活后显示。
        /// 非必填
        /// </summary>
        public CustomField custom_field2 { get; set; }
        /// <summary>
        /// 自定义会员信息类目，会员卡激活后显示。
        /// 非必填
        /// </summary>
        public CustomField custom_field3 { get; set; }
        /// <summary>
        /// 自定义会员信息类目，会员卡激活后显示
        /// 非必填
        /// </summary>
        public CustomCell custom_cell1 { get; set; }

        public Card_MemberCardData()
            : base(CardType.MEMBER_CARD)
        {
        }
    }

    public class CustomField
    {
        /// <summary>
        /// 会员信息类目名称。FIELD_NAME_TYPE_LEVEL等级；FIELD_NAME_TYPE_COUPON优惠券；FIELD_NAME_TYPE_STAMP印花；FIELD_NAME_TYPE_DISCOUNT折扣；FIELD_NAME_TYPE_ACHIEVEMEN成就；FIELD_NAME_TYPE_MILEAGE里程。
        /// </summary>
        public MemberCard_CustomField_NameType name_type { get; set; }
        /// <summary>
        /// 点击类目跳转外链url
        /// </summary>
        public string url { get; set; }
    }

    public class CustomCell
    {
        /// <summary>
        /// 入口名称
        /// 必填
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 入口右侧提示语，6个汉字内
        /// 必填
        /// </summary>
        public string tips { get; set; }
        /// <summary>
        /// 入口跳转链接
        /// 必填
        /// </summary>
        public string url { get; set; }
    }

    /// <summary>
    /// 门票数据
    /// </summary>
    public class Card_ScenicTicketData : BaseCardInfo
    {
        /// <summary>
        /// 票类型，例如平日全票，套票等
        /// 非必填
        /// </summary>
        public string ticket_class { get; set; }
        /// <summary>
        /// 导览图url
        /// 非必填
        /// </summary>
        public string guide_url { get; set; }

        public Card_ScenicTicketData()
            : base(CardType.SCENIC_TICKET)
        {
        }
    }

    /// <summary>
    /// 电影票数据
    /// </summary>
    public class Card_MovieTicketData : BaseCardInfo
    {
        /// <summary>
        /// 电影票详请
        /// 非必填
        /// </summary>
        public string detail { get; set; }

        public Card_MovieTicketData()
            : base(CardType.MOVIE_TICKET)
        {
        }
    }

    /// <summary>
    /// 飞机票数据
    /// </summary>
    public class Card_BoardingPassData : BaseCardInfo
    {
        /// <summary>
        /// 起点，上限为18 个汉字
        /// 必填
        /// </summary>
        public string from { get; set; }
        /// <summary>
        /// 终点，上限为18 个汉字
        /// 必填
        /// </summary>
        public string to { get; set; }
        /// <summary>
        /// 航班
        /// 必填
        /// </summary>
        public string flight { get; set; }
        /// <summary>
        /// 起飞时间，上限为17 个汉字
        /// 非必填
        /// </summary>
        public string departure_time { get; set; }
        /// <summary>
        /// 降落时间，上限为17 个汉字
        /// 非必填
        /// </summary>
        public string landing_time { get; set; }
        /// <summary>
        /// 在线值机的链接
        /// 非必填
        /// </summary>
        public string check_in_url { get; set; }
        /// <summary>
        /// 登机口。如发生登机口变更，建议商家实时调用该接口变更
        /// </summary>
        public string gate { get; set; }
        /// <summary>
        /// 登机时间，只显示“时分”不显示日期，按时间戳格式填写。如发生登机时间变更，建议商家实时调用该接口变更
        /// </summary>
        public string boarding_time { get; set; }
        /// <summary>
        /// 机型，上限为8 个汉字
        /// 非必填
        /// </summary>
        public string air_model { get; set; }

        public Card_BoardingPassData()
            : base(CardType.BOARDING_PASS)
        {
        }
    }

    /// <summary>
    /// 红包数据
    /// </summary>
    public class Card_LuckyMoneyData : BaseCardInfo
    {
        public Card_LuckyMoneyData()
            : base(CardType.LUCKY_MONEY)
        {
        }
    }

    /// <summary>
    /// 会议门票数据
    /// </summary>
    public class Card_MeetingTicketData : BaseCardInfo
    {
        /// <summary>
        /// 会议详情
        /// </summary>
        public string meeting_detail { get; set; }

        /// <summary>
        /// 会场导览图
        /// </summary>
        public string map_url { get; set; }

        public Card_MeetingTicketData()
            : base(CardType.MEETING_TICKET)
        {
        }
    }
}
