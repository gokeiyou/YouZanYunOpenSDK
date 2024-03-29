# YouZanYunOpenSDK（持续更新中...）
基于有赞云开放平台SDK源码封装的有赞云SDK

# 平台版本
.NET Standard 2.0+

## 1.正常调用(AccessToken会自动刷新，无须手动刷新)

```c#
		ApiHelper apiHelper = new ApiHelper("clientId", "clientSecret", grantId);
		UsersAccountCheckRequest request = new UsersAccountCheckRequest();
		request.AccountType = "Mobile";
		request.AccountId = "13333333333";
		YouZanResponse<bool> result = apiHelper.UsersAccountCheck(request);
```

## 2.数据库日志记录（支持Sql Server、Oracle、MySql）

```sql
需提前在数据库中创建日志表，表名自定义，默认为YouZanApiLogs，以SqlServer为例：

CREATE TABLE [dbo].[YouZanApiLogs] (
  [Guid] varchar(50) NOT NULL,
  [ClientId] varchar(50) COLLATE Chinese_PRC_CI_AS  NULL,
  [GrantId] varchar(50) COLLATE Chinese_PRC_CI_AS  NULL,
  [LogTime] datetime NOT NULL,
  [ApiName] varchar(255) NOT NULL,
  [ApiVersion] varchar(255) NOT NULL,
  [ApiMethod] varchar(10) NOT NULL,
  [AuthType] varchar(255) NOT NULL,
  [RequestUrl] varchar(1000) NOT NULL,
  [Header] varchar(1000) NOT NULL,
  [PostData] ntext NOT NULL,
  [ResponseData] ntext NOT NULL,
  PRIMARY KEY CLUSTERED ([Guid])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键',
'SCHEMA', N'dbo',
'TABLE', N'YouZanApiLogs',
'COLUMN', N'Guid'
GO

EXEC sp_addextendedproperty
'MS_Description', N'客户端ID',
'SCHEMA', N'dbo',
'TABLE', N'YouZanApiLogs',
'COLUMN', N'ClientId'
GO

EXEC sp_addextendedproperty
'MS_Description', N'店铺ID',
'SCHEMA', N'dbo',
'TABLE', N'YouZanApiLogs',
'COLUMN', N'GrantId'
GO

EXEC sp_addextendedproperty
'MS_Description', N'日志时间',
'SCHEMA', N'dbo',
'TABLE', N'YouZanApiLogs',
'COLUMN', N'LogTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'Api名称',
'SCHEMA', N'dbo',
'TABLE', N'YouZanApiLogs',
'COLUMN', N'ApiName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'Api版本',
'SCHEMA', N'dbo',
'TABLE', N'YouZanApiLogs',
'COLUMN', N'ApiVersion'
GO

EXEC sp_addextendedproperty
'MS_Description', N'请求方式',
'SCHEMA', N'dbo',
'TABLE', N'YouZanApiLogs',
'COLUMN', N'ApiMethod'
GO

EXEC sp_addextendedproperty
'MS_Description', N'认证类型',
'SCHEMA', N'dbo',
'TABLE', N'YouZanApiLogs',
'COLUMN', N'AuthType'
GO

EXEC sp_addextendedproperty
'MS_Description', N'请求地址',
'SCHEMA', N'dbo',
'TABLE', N'YouZanApiLogs',
'COLUMN', N'RequestUrl'
GO

EXEC sp_addextendedproperty
'MS_Description', N'请求头',
'SCHEMA', N'dbo',
'TABLE', N'YouZanApiLogs',
'COLUMN', N'Header'
GO

EXEC sp_addextendedproperty
'MS_Description', N'请求参数',
'SCHEMA', N'dbo',
'TABLE', N'YouZanApiLogs',
'COLUMN', N'PostData'
GO

EXEC sp_addextendedproperty
'MS_Description', N'返回值',
'SCHEMA', N'dbo',
'TABLE', N'YouZanApiLogs',
'COLUMN', N'ResponseData'
GO

EXEC sp_addextendedproperty
'MS_Description', N'有赞云API日志表',
'SCHEMA', N'dbo',
'TABLE', N'YouZanApiLogs'
GO

```


## 3.Api调用凭证AccessToken记录（支持Sql Server、Oracle、MySql）
```sql
需提前在数据库中创建AccessToken记录表，表名自定义，默认为YouZanAccessToken，以SqlServer为例：

CREATE TABLE [dbo].[YouZanAccessToken] (
  [Key] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [TokenData] text COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [AddTime] datetime DEFAULT getdate() NOT NULL,
  [UpdateTime] datetime  NULL
)
GO

ALTER TABLE [dbo].[YouZanAccessToken] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键',
'SCHEMA', N'dbo',
'TABLE', N'YouZanAccessToken',
'COLUMN', N'Key'
GO

EXEC sp_addextendedproperty
'MS_Description', N'AccessToken数据',
'SCHEMA', N'dbo',
'TABLE', N'YouZanAccessToken',
'COLUMN', N'TokenData'
GO

EXEC sp_addextendedproperty
'MS_Description', N'添加时间',
'SCHEMA', N'dbo',
'TABLE', N'YouZanAccessToken',
'COLUMN', N'AddTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'修改时间',
'SCHEMA', N'dbo',
'TABLE', N'YouZanAccessToken',
'COLUMN', N'UpdateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'有赞AccessToken信息表',
'SCHEMA', N'dbo',
'TABLE', N'YouZanAccessToken'
GO

```

## 4、如若开启日志保存和AccessToken保存，在程序启动的位置添加以下代码

```c#
		YouZanConfig.DBConnectionString = "xxxxxxx"; // 默认为空
		YouZanConfig.DBType = DBType.SqlServer; // 默认
		YouZanConfig.SaveApiLogToDB = true; // 默认为false
		YouZanConfig.ApiLogTableName = "YouZanApiLogs"; // 默认
		YouZanConfig.SaveAccessTokenToDB = true; // 默认为false
		YouZanConfig.AccessTokenTableName = "YouZanAccessToken";
```

### 请求参数

    调用不同接口，使用不同的Request类，所有Request类都继承自YouZanRequest

### 响应参数

```c#
YouZanResponse<T>（继承自YouZanResponse）
```

### NuGet程序包安装

	PM> Install-Package YouzanYunOpenSDK 
