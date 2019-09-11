# YouzanYunOpenSDK
基于有赞云开放平台SDK源码封装的有赞云SDK
## 1.正常调用

```c#
		ApiHelper apiHelper = new ApiHelper("clientId", "clientSecret", grantId);
		UsersAccountCheckRequest request = new UsersAccountCheckRequest();
		request.AccountType = "Mobile";
		request.AccountId = "13333333333";
		YouZanResponse<bool> result = apiHelper.UsersAccountCheck(request);
```

### 请求参数

    调用不同接口，使用不同的Request类，所有Request类都继承自YouZanRequest

### 响应参数

```c#
YouZanResponse<T>
```