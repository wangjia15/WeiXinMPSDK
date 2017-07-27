﻿/*----------------------------------------------------------------
    Copyright (C) 2017 Senparc
    
    文件名：Enums.cs
    文件功能描述：枚举类型
    
    
    创建标识：Senparc - 20150430
 
    修改标识：Senparc - 20160726
    修改描述：RequestInfoType中加了updateauthorized，authorized

    修改标识：Senparc - 20170601
    修改描述：v2.5.0 添加ModifyDomainAction

    修改标识：Senparc - 20170726
    修改描述：完成接口开放平台-代码管理及小程序码获取

----------------------------------------------------------------*/


namespace Senparc.Weixin.Open
{
    /// <summary>
    /// 选项设置信息选项名称
    /// </summary>
    public enum OptionName
    {
        /// <summary>
        /// 地理位置上报选项
        /// 0	无上报
        /// 1	进入会话时上报
        /// 2	每5s上报
        /// </summary>
        location_report,
        /// <summary>
        /// 语音识别开关选项
        /// 0	关闭语音识别
        /// 1	开启语音识别
        /// </summary>
        voice_recognize,
        /// <summary>
        /// 客服开关选项
        /// 0	关闭多客服
        /// 1	开启多客服
        /// </summary>
        customer_service
    }

    /// <summary>
    /// 公众号第三方平台推送消息类型
    /// </summary>
    public enum RequestInfoType
    {
        /// <summary>
        /// 推送component_verify_ticket协议
        /// </summary>
        component_verify_ticket,
        /// <summary>
        /// 推送取消授权通知
        /// </summary>
        unauthorized,
        /// <summary>
        /// 更新授权
        /// </summary>
        updateauthorized,
        /// <summary>
        /// 授权成功通知
        /// </summary>
        authorized
    }

    /// <summary>
    /// 应用授权作用域
    /// </summary>
    public enum OAuthScope
    {
        /// <summary>
        /// 不弹出授权页面，直接跳转，只能获取用户openid
        /// </summary>
        snsapi_base,
        /// <summary>
        /// 弹出授权页面，可通过openid拿到昵称、性别、所在地。并且，即使在未关注的情况下，只要用户授权，也能获取其信息
        /// </summary>
        snsapi_userinfo,
        /// <summary>
        /// 网站应用授权登录
        /// </summary>
        snsapi_login,
    }

    /// <summary>
    /// 授权方公众号类型
    /// </summary>
    public enum ServiceType
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        订阅号 = 0,
        由历史老帐号升级后的订阅号 = 1,
        服务号 = 2
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }

    /// <summary>
    /// 授权方认证类型
    /// </summary>
    public enum VerifyType
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        未认证 = -1,
        微信认证 = 0,
        新浪微博认证 = 1,
        腾讯微博认证 = 2,
        已资质认证通过但还未通过名称认证 = 3,
        已资质认证通过还未通过名称认证但通过了新浪微博认证 = 4,
        已资质认证通过还未通过名称认证但通过了腾讯微博认证 = 5
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }

    /// <summary>
    /// 公众号授权给开发者的权限集列表
    /// </summary>
    public enum FuncscopeCategory
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        消息管理权限 = 1,
        用户管理权限 = 2,
        帐号服务权限 = 3,
        网页服务权限 = 4,
        微信小店权限 = 5,
        微信多客服权限 = 6,
        群发与通知权限 = 7,
        微信卡券权限 = 8,
        微信扫一扫权限 = 9,
        微信连WIFI权限 = 10,
        素材管理权限 = 11,
        微信摇周边权限 = 12,
        微信门店权限 = 13,
        微信支付权限 = 14,
        自定义菜单权限 = 15
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }

    /// <summary>
    /// 小程序“修改服务器地址”接口的action类型
    /// </summary>
    public enum ModifyDomainAction
    {
        /// <summary>
        /// 添加
        /// </summary>
        add,
        /// <summary>
        /// 删除
        /// </summary>
        delete,
        /// <summary>
        /// 覆盖
        /// </summary>
        set,
        /// <summary>
        /// 获取
        /// </summary>
        get
    }

    /// <summary>
    /// 小程序“线上代码的可见状态”接口的action类型
    /// </summary>
    public enum ChangVisitStatusAction
    {
        open,
        close
    }
}
