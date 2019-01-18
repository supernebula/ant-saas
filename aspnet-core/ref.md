
[ABP从入门到精通（2）：aspnet-zero-core 使用MySql数据库](https://www.cnblogs.com/stulzq/p/7242581.html)

[解决mysql插入数据时出现Incorrect string value: '\xF0\x9F...' for column 'name' at row 1的异常](https://blog.csdn.net/azhegps/article/details/71480633)

将已经建好的表也转换成utf8mb4

命令：alter table TABLE_NAME convert to character set utf8mb4 collate utf8mb4_bin; （将TABLE_NAME替换成你的表名）



# Issuse

1. 数据表没有主键，无法进行逆向工程以生成实体类

Scaffold-DbContext "server=127.0.0.1;User ID=root;Password=123456;database=yelp_db;" Microsoft.EntityFrameworkCore.MySql -OutputDir Models

Unable to identify the primary key for table 'attribute'.

[Entity Framework Core 工具引用的.NET CLI](https://docs.microsoft.com/zh-cn/ef/core/miscellaneous/cli/dotnet#dotnet-ef-dbcontext-scaffold)

dotnet ef dbcontext 基架

为生成代码DbContext和数据库的实体类型。 为了使此命令来生成实体类型，数据库表必须具有主键。