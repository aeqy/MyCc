# MyCc - Clean Architecture

## 目录
- [介绍](#介绍)

- #### Domain Layer (领域层): 包含业务逻辑的核心，如实体、值对象、领域服务、聚合根等。
- #### Application Layer (应用层): 包含应用服务，协调使用领域层来完成用例。
- #### Infrastructure Layer (基础设施层): 提供对数据库、消息队列、外部API等的访问支持。
- #### Presentation Layer (表现层): 负责与用户的交互，如Web API、UI等

- [安装](#安装)


- [使用](#使用)

```base
dotnet ef migrations add InitialCreate --project ../MyCc.Infrastructure
dotnet ef database update --project ../MyCc.Infrastructure
```

- [贡献](#贡献)
- [许可证](#许可证)

## 介绍
简述项目及其价值...

## 安装
按照以下步骤安装依赖项：



## 类型定义- Git 贡献提交规范

| 类型      | 描述                                               |
|-----------|----------------------------------------------------|
| `feat`    | 新功能（feature）                                   |
| `fix`     | 修复bug                                            |
| `docs`    | 文档更改                                           |
| `style`   | 不影响代码逻辑的样式调整                           |
| `refactor`| 重构代码，既不添加新功能也不修复bug                 |
| `perf`    | 性能优化                                           |
| `test`    | 增加或更新测试用例                                 |
| `chore`   | 构建过程或辅助工具的更改（例如打包、依赖更新等）    |
| `ci`      | 持续集成配置更改                                   |
| `types`   | 类型定义文件更改                                   |
| `revert`  | 撤销之前的提交                                     |
| `wip`     | 开发中（Work in Progress）                         |

